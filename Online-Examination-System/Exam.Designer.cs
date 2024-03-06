namespace Online_Examination_System
{
    partial class Exam
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            generate = new Button();
            SuspendLayout();
            // 
            // generate
            // 
            generate.Location = new Point(465, 29);
            generate.Name = "generate";
            generate.Size = new Size(176, 47);
            generate.TabIndex = 2;
            generate.Text = "RequestExam";
            generate.UseVisualStyleBackColor = true;
            generate.Click += generate_Click;
            // 
            // Exam
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1185, 763);
            Controls.Add(generate);
            Name = "Exam";
            Padding = new Padding(10);
            Text = "Exam";
            ResumeLayout(false);
        }

        #endregion
        private Button generate;
    }
}