namespace WinFormAge
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
            datebirth = new Label();
            DateTimePicker = new DateTimePicker();
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // datebirth
            // 
            datebirth.AutoSize = true;
            datebirth.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            datebirth.Location = new Point(55, 54);
            datebirth.Name = "datebirth";
            datebirth.Size = new Size(166, 18);
            datebirth.TabIndex = 0;
            datebirth.Text = "Date de naissance";
            datebirth.Click += button1_Click;
            // 
            // DateTimePicker
            // 
            DateTimePicker.CalendarForeColor = SystemColors.ActiveCaption;
            DateTimePicker.CalendarTitleForeColor = SystemColors.MenuHighlight;
            DateTimePicker.Location = new Point(253, 53);
            DateTimePicker.Name = "DateTimePicker";
            DateTimePicker.Size = new Size(284, 27);
            DateTimePicker.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(393, 139);
            button1.Name = "button1";
            button1.Size = new Size(76, 29);
            button1.TabIndex = 2;
            button1.Text = "Calulez";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(55, 224);
            label1.Name = "label1";
            label1.Size = new Size(166, 18);
            label1.TabIndex = 3;
            label1.Text = "Date de naissance";
            label1.Click += label1_Click_1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(339, 224);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(258, 27);
            textBox1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(DateTimePicker);
            Controls.Add(datebirth);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label datebirth;
        private DateTimePicker DateTimePicker;
        private Button button1;
        private Label label1;
        private TextBox textBox1;
    }
}