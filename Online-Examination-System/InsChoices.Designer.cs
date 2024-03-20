namespace Online_Examination_System
{
    partial class InsChoices
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
            label5 = new Label();
            txt_answer = new TextBox();
            label4 = new Label();
            txt_marks = new TextBox();
            label3 = new Label();
            txt_type = new TextBox();
            label2 = new Label();
            txt_name = new TextBox();
            button4 = new Button();
            deleteBtn = new Button();
            insertBtn = new Button();
            label1 = new Label();
            txt_choice = new TextBox();
            label6 = new Label();
            txt_qid = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(367, 48);
            label5.Name = "label5";
            label5.Size = new Size(69, 21);
            label5.TabIndex = 33;
            label5.Text = "Answer :";
            // 
            // txt_answer
            // 
            txt_answer.Location = new Point(450, 48);
            txt_answer.Name = "txt_answer";
            txt_answer.ReadOnly = true;
            txt_answer.Size = new Size(232, 23);
            txt_answer.TabIndex = 32;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(367, 24);
            label4.Name = "label4";
            label4.Size = new Size(60, 21);
            label4.TabIndex = 31;
            label4.Text = "Marks :";
            // 
            // txt_marks
            // 
            txt_marks.Location = new Point(450, 24);
            txt_marks.Name = "txt_marks";
            txt_marks.ReadOnly = true;
            txt_marks.Size = new Size(232, 23);
            txt_marks.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(32, 50);
            label3.Name = "label3";
            label3.Size = new Size(49, 21);
            label3.TabIndex = 29;
            label3.Text = "Type :";
            // 
            // txt_type
            // 
            txt_type.Location = new Point(115, 50);
            txt_type.Name = "txt_type";
            txt_type.ReadOnly = true;
            txt_type.Size = new Size(232, 23);
            txt_type.TabIndex = 28;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(32, 24);
            label2.Name = "label2";
            label2.Size = new Size(75, 21);
            label2.TabIndex = 27;
            label2.Text = "Q Name :";
            // 
            // txt_name
            // 
            txt_name.Location = new Point(115, 24);
            txt_name.Name = "txt_name";
            txt_name.ReadOnly = true;
            txt_name.Size = new Size(232, 23);
            txt_name.TabIndex = 26;
            // 
            // button4
            // 
            button4.BackColor = Color.Silver;
            button4.Location = new Point(523, 114);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 42;
            button4.Text = "Clear";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.FromArgb(255, 128, 128);
            deleteBtn.Location = new Point(334, 114);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(75, 23);
            deleteBtn.TabIndex = 41;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // insertBtn
            // 
            insertBtn.BackColor = Color.FromArgb(128, 255, 128);
            insertBtn.Location = new Point(147, 114);
            insertBtn.Name = "insertBtn";
            insertBtn.Size = new Size(75, 23);
            insertBtn.TabIndex = 39;
            insertBtn.Text = "Insert";
            insertBtn.UseVisualStyleBackColor = false;
            insertBtn.Click += insertBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(367, 77);
            label1.Name = "label1";
            label1.Size = new Size(64, 21);
            label1.TabIndex = 38;
            label1.Text = "Choice :";
            // 
            // txt_choice
            // 
            txt_choice.Location = new Point(450, 77);
            txt_choice.Name = "txt_choice";
            txt_choice.Size = new Size(232, 23);
            txt_choice.TabIndex = 37;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(32, 79);
            label6.Name = "label6";
            label6.Size = new Size(46, 21);
            label6.TabIndex = 36;
            label6.Text = "Q Id :";
            // 
            // txt_qid
            // 
            txt_qid.Location = new Point(115, 79);
            txt_qid.Name = "txt_qid";
            txt_qid.ReadOnly = true;
            txt_qid.Size = new Size(232, 23);
            txt_qid.TabIndex = 35;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 143);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(776, 234);
            dataGridView1.TabIndex = 34;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // InsChoices
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 389);
            Controls.Add(button4);
            Controls.Add(deleteBtn);
            Controls.Add(insertBtn);
            Controls.Add(label1);
            Controls.Add(txt_choice);
            Controls.Add(label6);
            Controls.Add(txt_qid);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Controls.Add(txt_answer);
            Controls.Add(label4);
            Controls.Add(txt_marks);
            Controls.Add(label3);
            Controls.Add(txt_type);
            Controls.Add(label2);
            Controls.Add(txt_name);
            Name = "InsChoices";
            Text = "Insert Choices";
            Load += InsChoices_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private TextBox txt_answer;
        private Label label4;
        private TextBox txt_marks;
        private Label label3;
        private TextBox txt_type;
        private Label label2;
        private TextBox txt_name;
        private Button button4;
        private Button deleteBtn;
        private Button insertBtn;
        private Label label1;
        private TextBox txt_choice;
        private Label label6;
        private TextBox txt_qid;
        private DataGridView dataGridView1;
    }
}