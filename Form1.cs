using System.IO;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace Notepad
{
    public partial class Form1 : Form
    {

        string filepath;
        bool onlyread = true;
        string textcontent;
        int loadnum = 1000;
        int currentline;
        int lastline;
        long linenum = 0;
        long totallines;
        int numval;
        int pagenum = 1;
        StreamReader reader;
        BufferedStream bufferstream;
        public Form1()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            button2.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            textBox5.Text = "Please load a file";
        }


        private void button1_Click(object sender, EventArgs e)  //choose file
        {

            using OpenFileDialog open = new OpenFileDialog();
            {
                totallines = 0;
                textBox5.Clear();
                open.Filter = "Text files|*.txt|JSON files|*.json|CSV files|*.csv";
                open.Multiselect = false;

                if (open.ShowDialog() == DialogResult.OK)
                {
                    textBox5.Text = "File loading, scrolling disabled" + "\r\n" + "Please wait";
                    button2.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    filepath = open.FileName;
                    textBox1.Text = filepath;

                    FileStream fileStream = new FileStream(filepath, FileMode.Open, FileAccess.Read, FileShare.Read, 524288, FileOptions.SequentialScan);
                    bufferstream = new BufferedStream(fileStream, 524288);
                    reader = new StreamReader(bufferstream);

                    currentline = 0;
                    textBox2.Clear();
                    loadlines();
                    totallines = fastcounter(filepath);
                    numericUpDown1.Maximum = totallines - 1;
                    textBox5.Text = ($"current lines: 0 - {currentline}\r\n");
                    textBox5.AppendText($"Total lines: {totallines}\r\n");
                    label3.Text = ($"Page: {pagenum} out of {pagecount()} ");
                    if (totallines < loadnum)
                    {
                        button2.Enabled = true;
                    }
                    else
                    {
                        button2.Enabled = true;
                        button6.Enabled = true;
                        button7.Enabled = true;
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) //filepath
        {
            textBox1.ReadOnly = true;
        }

        private void button5_Click(object sender, EventArgs e) //edit
        {
            onlyread = !onlyread;
            textBox2.ReadOnly = onlyread;
            status();
        }

        private void textBox2_TextChanged(object sender, EventArgs e) //text show
        {

        }

        private void button3_Click(object sender, EventArgs e)  //save as
        {

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "text file|*.txt";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {

                    {

                        File.WriteAllText(saveFileDialog.FileName, textBox2.Text);
                    }

                }
            }
        }
        private void button4_Click(object sender, EventArgs e) //discard chagnes
        {
            currentline = currentline - loadnum;
            reader.DiscardBufferedData();
            reader.BaseStream.Seek(0, SeekOrigin.Begin);
            for (int i = 0; i < currentline; i++)
            {
                if (reader.ReadLine() == null) break;
            }
            textBox2.Clear();
            loadlines();
            lastline = currentline + loadnum;
            textBox5.Text = ($"current lines: {currentline - loadnum} - {currentline}");

        }

        private void status() //edting status
        {
            if (onlyread)
            {
                label2.Text = "OFF";
                label2.ForeColor = Color.Red;
            }
            else
            {

                label2.Text = "ON";
                label2.ForeColor = Color.Green;
            }
        }


        private void loadlines() //loading
        {
            if (reader == null) return;
            var lines = new List<string>();
            for (int i = 0; i < loadnum; i++)
            {
                string? line = reader.ReadLine();
                if (line == null)
                {
                    break;
                }
                lines.Add(line);
                currentline++;

            }
            textBox2.Text = string.Join(Environment.NewLine, lines);
            lastline = currentline + loadnum;
        }

        private void jumptoline(int linenumber)
        {
            {
                if (linenumber < 0)
                {
                    linenumber = 0;
                }

                if (linenumber >= totallines)
                {
                    linenumber = (int)totallines - 1;
                }

                reader.DiscardBufferedData();
                bufferstream.Position = 0;

                for (int i = 0; i < linenumber; i++)
                {
                    if (reader.ReadLine() == null)
                    {
                        break;
                    }
                }
                currentline = linenumber;
                pagenum = (currentline / loadnum) + 1;
                label3.Text = $"Page: {pagenum} out of {pagecount()}";
            }
        }
        //private long linecount(string filepath) //counting lines for percentage  OLD COUNTER SLOW
        //{
        //    using (StreamReader reader1 = new StreamReader(filepath))
        //    {
        //        while (reader1.ReadLine() != null)
        //        {
        //            linenum++;
        //        }
        //    }
        //    return linenum;

        //}

        private long fastcounter(string filepath)
        {
            long linecountfast = 0;

            using (FileStream filestream = new FileStream(filepath, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                byte[] buffer = new byte[524288];
                int bytes;

                while ((bytes = filestream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    for (int i = 0; i < bytes; i++)
                    {
                        if (buffer[i] == '\n')
                        {
                            linecountfast++;
                        }
                    }
                }
            }

            return linecountfast;
        }


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e) //file stats, current line, info
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e) //back
        {
            if (currentline - loadnum <= 0)
            {
                return;
            }
            jumptoline(currentline -= 2 * loadnum);
            textBox2.Clear();
            loadlines();
            lastline = currentline + loadnum;
            textBox5.Text = ($"current lines: {currentline - loadnum} - {currentline}\r\n");
            textBox5.AppendText($"Total lines: {totallines}");
            pagenum -= 1;
            label3.Text = ($"Page: {pagenum} out of {pagecount()} ");

        }

        private void button7_Click(object sender, EventArgs e) //next page
        {

            textBox2.Clear();
            loadlines();
            lastline = currentline + loadnum;
            textBox5.Text = ($"current lines: {currentline - loadnum} - {currentline}\r\n");
            textBox5.AppendText($"Total lines: {totallines}");
            pagenum +=1;
            label3.Text = ($"Page: {pagenum} out of {pagecount()} ");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e) //jump to number
        {

        }



        private void button2_Click_1(object sender, EventArgs e) //jumpto
        {
            jumptoline(numval);
            textBox2.Clear();
            loadlines();
            lastline = currentline + loadnum;
            textBox5.Text = ($"current lines: {numval} - {currentline}\r\n");
            textBox5.AppendText($"Total lines: {totallines}");
        }

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {
            numval = Math.Min(Convert.ToInt32(numericUpDown1.Value), (int)totallines - 1);
        }

        private int pagecount()
        {
            return (int)(totallines / loadnum);
        }
    }
}

