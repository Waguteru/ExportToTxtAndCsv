namespace WinFormsApp1
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
            button1 = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            color_column = new DataGridViewTextBoxColumn();
            subject_column = new DataGridViewTextBoxColumn();
            color_btn = new TextBox();
            subject_btn = new TextBox();
            label2 = new Label();
            addBtn = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 283);
            button1.Name = "button1";
            button1.Size = new Size(156, 44);
            button1.TabIndex = 1;
            button1.Text = "вывести в .txt";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(415, 17);
            label1.Name = "label1";
            label1.Size = new Size(49, 25);
            label1.TabIndex = 2;
            label1.Text = "цвет";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { color_column, subject_column });
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(360, 225);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // color_column
            // 
            color_column.HeaderText = "цвет";
            color_column.MinimumWidth = 8;
            color_column.Name = "color_column";
            color_column.Width = 150;
            // 
            // subject_column
            // 
            subject_column.HeaderText = "предмет";
            subject_column.MinimumWidth = 8;
            subject_column.Name = "subject_column";
            subject_column.Width = 150;
            // 
            // color_btn
            // 
            color_btn.Location = new Point(415, 45);
            color_btn.Name = "color_btn";
            color_btn.Size = new Size(150, 31);
            color_btn.TabIndex = 4;
            // 
            // subject_btn
            // 
            subject_btn.Location = new Point(415, 129);
            subject_btn.Name = "subject_btn";
            subject_btn.Size = new Size(150, 31);
            subject_btn.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(415, 101);
            label2.Name = "label2";
            label2.Size = new Size(81, 25);
            label2.TabIndex = 6;
            label2.Text = "предмет";
            // 
            // addBtn
            // 
            addBtn.Location = new Point(415, 193);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(156, 44);
            addBtn.TabIndex = 7;
            addBtn.Text = "добавить";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(216, 283);
            button3.Name = "button3";
            button3.Size = new Size(156, 44);
            button3.TabIndex = 8;
            button3.Text = "вывести в csv";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 355);
            Controls.Add(button3);
            Controls.Add(addBtn);
            Controls.Add(label2);
            Controls.Add(subject_btn);
            Controls.Add(color_btn);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "экспорт данных";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Label label1;
        private DataGridView dataGridView1;
        private TextBox color_btn;
        private TextBox subject_btn;
        private Label label2;
        private Button addBtn;
        private DataGridViewTextBoxColumn color_column;
        private DataGridViewTextBoxColumn subject_column;
        private Button button3;
    }
}