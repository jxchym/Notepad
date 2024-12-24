namespace Notepad
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox5 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button6 = new Button();
            button7 = new Button();
            button2 = new Button();
            numericUpDown1 = new NumericUpDown();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(26, 26, 26);
            button1.ForeColor = Color.White;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Open file";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(26, 26, 26);
            button3.ForeColor = Color.White;
            button3.Location = new Point(577, 70);
            button3.Name = "button3";
            button3.Size = new Size(211, 27);
            button3.TabIndex = 2;
            button3.Text = "Save loaded part";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(26, 26, 26);
            button4.ForeColor = Color.White;
            button4.Location = new Point(577, 103);
            button4.Name = "button4";
            button4.Size = new Size(211, 28);
            button4.TabIndex = 3;
            button4.Text = "Discard changes and reload";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(26, 26, 26);
            button5.ForeColor = Color.White;
            button5.Location = new Point(577, 12);
            button5.Name = "button5";
            button5.Size = new Size(72, 47);
            button5.TabIndex = 4;
            button5.Text = "Toggle editing";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(26, 26, 26);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(93, 12);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(465, 23);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(26, 26, 26);
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(12, 70);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.ScrollBars = ScrollBars.Both;
            textBox2.Size = new Size(546, 368);
            textBox2.TabIndex = 6;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.FromArgb(26, 26, 26);
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.Font = new Font("Segoe UI", 11F);
            textBox5.ForeColor = Color.White;
            textBox5.Location = new Point(577, 137);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(209, 190);
            textBox5.TabIndex = 9;
            textBox5.Text = "Load a file first to show information";
            textBox5.TextAlign = HorizontalAlignment.Center;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(655, 15);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 11;
            label1.Text = "Edit Mode:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(742, 15);
            label2.Name = "label2";
            label2.Size = new Size(34, 20);
            label2.TabIndex = 12;
            label2.Text = "OFF";
            label2.Click += label2_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(26, 26, 26);
            button6.Font = new Font("Segoe UI", 15F);
            button6.ForeColor = Color.White;
            button6.ImageAlign = ContentAlignment.TopCenter;
            button6.Location = new Point(577, 401);
            button6.Name = "button6";
            button6.Size = new Size(105, 37);
            button6.TabIndex = 13;
            button6.Text = "<<<";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(26, 26, 26);
            button7.Font = new Font("Segoe UI", 15F);
            button7.ForeColor = Color.White;
            button7.Location = new Point(688, 401);
            button7.Name = "button7";
            button7.Size = new Size(100, 37);
            button7.TabIndex = 14;
            button7.Text = ">>>";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(26, 26, 26);
            button2.ForeColor = Color.White;
            button2.Location = new Point(577, 333);
            button2.Name = "button2";
            button2.Size = new Size(105, 23);
            button2.TabIndex = 17;
            button2.Text = "jump to";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // numericUpDown1
            // 
            numericUpDown1.BackColor = Color.FromArgb(26, 26, 26);
            numericUpDown1.ForeColor = Color.White;
            numericUpDown1.Location = new Point(688, 333);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(100, 23);
            numericUpDown1.TabIndex = 18;
            numericUpDown1.TextAlign = HorizontalAlignment.Center;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(577, 369);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 19;
            label3.Text = "                   ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 26);
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(numericUpDown1);
            Controls.Add(button2);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox5);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Notepad";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button3;
        private Button button4;
        private Button button5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox5;
        private Label label1;
        private Label label2;
        private Button button6;
        private Button button7;
        private Button button2;
        private NumericUpDown numericUpDown1;
        private Label label3;
    }
}
