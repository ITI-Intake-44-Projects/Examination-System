namespace Online_Examination_System
{
    partial class StudentCourses
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            coursesDgv = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)coursesDgv).BeginInit();
            SuspendLayout();
            // 
            // coursesDgv
            // 
            coursesDgv.AllowUserToAddRows = false;
            coursesDgv.AllowUserToDeleteRows = false;
            coursesDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            coursesDgv.BackgroundColor = Color.Lavender;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.Yellow;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            coursesDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            coursesDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            coursesDgv.DefaultCellStyle = dataGridViewCellStyle2;
            coursesDgv.Dock = DockStyle.Fill;
            coursesDgv.Location = new Point(0, 0);
            coursesDgv.Name = "coursesDgv";
            coursesDgv.Size = new Size(900, 546);
            coursesDgv.TabIndex = 0;
            coursesDgv.CellContentClick += coursesDgv_CellContentClick;
            // 
            // StudentCourses
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(900, 546);
            Controls.Add(coursesDgv);
            Name = "StudentCourses";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentCourses";
            Load += StudentCourses_Load;
            ((System.ComponentModel.ISupportInitialize)coursesDgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView coursesDgv;
    }
}