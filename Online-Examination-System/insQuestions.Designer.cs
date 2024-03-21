namespace Online_Examination_System
{
    partial class insQuestions
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
            comboBox1 = new ComboBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            txt_name = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            txt_answer = new TextBox();
            insertBtn = new Button();
            updateBtn = new Button();
            deleteBtn = new Button();
            button4 = new Button();
            btnInsChoices = new Button();
            ques_type = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(408, 16);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(255, 23);
            comboBox1.TabIndex = 15;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(321, 16);
            label1.Name = "label1";
            label1.Size = new Size(66, 21);
            label1.TabIndex = 16;
            label1.Text = "Course :";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 152);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(928, 257);
            dataGridView1.TabIndex = 17;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(107, 63);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(232, 23);
            txt_name.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 63);
            label2.Name = "label2";
            label2.Size = new Size(75, 21);
            label2.TabIndex = 19;
            label2.Text = "Q Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(696, 69);
            label3.Name = "label3";
            label3.Size = new Size(49, 21);
            label3.TabIndex = 21;
            label3.Text = "Type :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(362, 67);
            label5.Name = "label5";
            label5.Size = new Size(69, 21);
            label5.TabIndex = 25;
            label5.Text = "Answer :";
            // 
            // txt_answer
            // 
            txt_answer.Location = new Point(452, 67);
            txt_answer.Name = "txt_answer";
            txt_answer.Size = new Size(185, 23);
            txt_answer.TabIndex = 24;
            // 
            // insertBtn
            // 
            insertBtn.BackColor = Color.White;
            insertBtn.Location = new Point(133, 123);
            insertBtn.Name = "insertBtn";
            insertBtn.Size = new Size(75, 23);
            insertBtn.TabIndex = 26;
            insertBtn.Text = "Insert";
            insertBtn.UseVisualStyleBackColor = false;
            insertBtn.Click += insertBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.BackColor = Color.White;
            updateBtn.Location = new Point(312, 123);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(75, 23);
            updateBtn.TabIndex = 27;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = false;
            updateBtn.Click += updateBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.White;
            deleteBtn.Location = new Point(452, 123);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(75, 23);
            deleteBtn.TabIndex = 28;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.Location = new Point(588, 124);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 29;
            button4.Text = "Clear";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // btnInsChoices
            // 
            btnInsChoices.BackColor = Color.White;
            btnInsChoices.Location = new Point(720, 124);
            btnInsChoices.Name = "btnInsChoices";
            btnInsChoices.Size = new Size(111, 23);
            btnInsChoices.TabIndex = 30;
            btnInsChoices.Text = "Insert Choices";
            btnInsChoices.UseVisualStyleBackColor = false;
            btnInsChoices.Click += btnInsChoices_Click;
            // 
            // ques_type
            // 
            ques_type.FormattingEnabled = true;
            ques_type.Location = new Point(768, 69);
            ques_type.Name = "ques_type";
            ques_type.Size = new Size(106, 23);
            ques_type.TabIndex = 31;
            // 
            // insQuestions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 51, 76);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(952, 450);
            Controls.Add(ques_type);
            Controls.Add(btnInsChoices);
            Controls.Add(button4);
            Controls.Add(deleteBtn);
            Controls.Add(updateBtn);
            Controls.Add(insertBtn);
            Controls.Add(label5);
            Controls.Add(txt_answer);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_name);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            DoubleBuffered = true;
            Name = "insQuestions";
            Text = "Questions";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBox1;
        private Label label1;
        private DataGridView dataGridView1;
        private TextBox txt_name;
        private Label label2;
        private Label label3;
        private Label label5;
        private TextBox txt_answer;
        private Button insertBtn;
        private Button updateBtn;
        private Button deleteBtn;
        private Button button4;
        private Button btnInsChoices;
        private ComboBox ques_type;
    }
}