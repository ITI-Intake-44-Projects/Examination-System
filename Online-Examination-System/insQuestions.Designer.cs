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
            btn_back = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            txt_name = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txt_type = new TextBox();
            label4 = new Label();
            txt_marks = new TextBox();
            label5 = new Label();
            txt_answer = new TextBox();
            insertBtn = new Button();
            updateBtn = new Button();
            deleteBtn = new Button();
            button4 = new Button();
            btnInsChoices = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btn_back
            // 
            btn_back.Location = new Point(696, 415);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(92, 23);
            btn_back.TabIndex = 14;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(84, 16);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(255, 23);
            comboBox1.TabIndex = 15;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 14);
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
            dataGridView1.Size = new Size(776, 257);
            dataGridView1.TabIndex = 17;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(84, 63);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(232, 23);
            txt_name.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(1, 63);
            label2.Name = "label2";
            label2.Size = new Size(75, 21);
            label2.TabIndex = 19;
            label2.Text = "Q Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(1, 89);
            label3.Name = "label3";
            label3.Size = new Size(49, 21);
            label3.TabIndex = 21;
            label3.Text = "Type :";
            // 
            // txt_type
            // 
            txt_type.Location = new Point(84, 89);
            txt_type.Name = "txt_type";
            txt_type.Size = new Size(232, 23);
            txt_type.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(336, 63);
            label4.Name = "label4";
            label4.Size = new Size(60, 21);
            label4.TabIndex = 23;
            label4.Text = "Marks :";
            // 
            // txt_marks
            // 
            txt_marks.Location = new Point(419, 63);
            txt_marks.Name = "txt_marks";
            txt_marks.Size = new Size(232, 23);
            txt_marks.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(336, 87);
            label5.Name = "label5";
            label5.Size = new Size(69, 21);
            label5.TabIndex = 25;
            label5.Text = "Answer :";
            // 
            // txt_answer
            // 
            txt_answer.Location = new Point(419, 87);
            txt_answer.Name = "txt_answer";
            txt_answer.Size = new Size(232, 23);
            txt_answer.TabIndex = 24;
            // 
            // insertBtn
            // 
            insertBtn.BackColor = Color.FromArgb(128, 255, 128);
            insertBtn.Location = new Point(116, 124);
            insertBtn.Name = "insertBtn";
            insertBtn.Size = new Size(75, 23);
            insertBtn.TabIndex = 26;
            insertBtn.Text = "Insert";
            insertBtn.UseVisualStyleBackColor = false;
            insertBtn.Click += insertBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.BackColor = Color.FromArgb(128, 128, 255);
            updateBtn.Location = new Point(241, 124);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(75, 23);
            updateBtn.TabIndex = 27;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = false;
            updateBtn.Click += updateBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.FromArgb(255, 128, 128);
            deleteBtn.Location = new Point(372, 124);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(75, 23);
            deleteBtn.TabIndex = 28;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Silver;
            button4.Location = new Point(492, 124);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 29;
            button4.Text = "Clear";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // btnInsChoices
            // 
            btnInsChoices.BackColor = Color.FromArgb(255, 128, 255);
            btnInsChoices.Location = new Point(599, 123);
            btnInsChoices.Name = "btnInsChoices";
            btnInsChoices.Size = new Size(111, 23);
            btnInsChoices.TabIndex = 30;
            btnInsChoices.Text = "Insert Choices";
            btnInsChoices.UseVisualStyleBackColor = false;
            btnInsChoices.Click += btnInsChoices_Click;
            // 
            // insQuestions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnInsChoices);
            Controls.Add(button4);
            Controls.Add(deleteBtn);
            Controls.Add(updateBtn);
            Controls.Add(insertBtn);
            Controls.Add(label5);
            Controls.Add(txt_answer);
            Controls.Add(label4);
            Controls.Add(txt_marks);
            Controls.Add(label3);
            Controls.Add(txt_type);
            Controls.Add(label2);
            Controls.Add(txt_name);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(btn_back);
            Name = "insQuestions";
            Text = "Questions";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_back;
        private ComboBox comboBox1;
        private Label label1;
        private DataGridView dataGridView1;
        private TextBox txt_name;
        private Label label2;
        private Label label3;
        private TextBox txt_type;
        private Label label4;
        private TextBox txt_marks;
        private Label label5;
        private TextBox txt_answer;
        private Button insertBtn;
        private Button updateBtn;
        private Button deleteBtn;
        private Button button4;
        private Button btnInsChoices;
    }
}