namespace practice_library
{
    partial class ReturnBook
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
            Username = new Label();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            textBox4 = new TextBox();
            label7 = new Label();
            button1 = new Button();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.BackColor = Color.Transparent;
            Username.Font = new Font("Segoe Print", 20F, FontStyle.Bold, GraphicsUnit.Point);
            Username.ForeColor = Color.Gold;
            Username.Location = new Point(547, 20);
            Username.Name = "Username";
            Username.Size = new Size(284, 71);
            Username.TabIndex = 29;
            Username.Text = "Return Book";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Maroon;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(274, 131);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(968, 359);
            dataGridView1.TabIndex = 28;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button2
            // 
            button2.BackColor = Color.PapayaWhip;
            button2.BackgroundImage = Properties.Resources.Maroon_color_bg;
            button2.Font = new Font("Segoe Print", 8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.Yellow;
            button2.Image = Properties.Resources.Maroon_color_bg;
            button2.Location = new Point(55, 329);
            button2.Name = "button2";
            button2.Size = new Size(154, 40);
            button2.TabIndex = 50;
            button2.Text = "Search Student";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.Maroon;
            textBox4.Font = new Font("Segoe Print", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBox4.ForeColor = Color.Yellow;
            textBox4.Location = new Point(30, 284);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(202, 39);
            textBox4.TabIndex = 49;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Gold;
            label7.Location = new Point(55, 250);
            label7.Name = "label7";
            label7.Size = new Size(158, 31);
            label7.TabIndex = 48;
            label7.Text = " Enrollment No:";
            // 
            // button1
            // 
            button1.BackColor = Color.PapayaWhip;
            button1.BackgroundImage = Properties.Resources.Maroon_color_bg;
            button1.Font = new Font("Segoe Print", 6F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Yellow;
            button1.Image = Properties.Resources.Maroon_color_bg;
            button1.Location = new Point(1032, 578);
            button1.Name = "button1";
            button1.Size = new Size(100, 37);
            button1.TabIndex = 53;
            button1.Text = "Return Book";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(789, 532);
            label1.Name = "label1";
            label1.Size = new Size(130, 31);
            label1.TabIndex = 54;
            label1.Text = "Return Date:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker1.CalendarForeColor = Color.Yellow;
            dateTimePicker1.CalendarMonthBackground = Color.Maroon;
            dateTimePicker1.Location = new Point(920, 532);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(287, 31);
            dateTimePicker1.TabIndex = 55;
            dateTimePicker1.Value = new DateTime(2023, 3, 17, 0, 0, 0, 0);
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Maroon;
            textBox1.Font = new Font("Segoe Print", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Yellow;
            textBox1.Location = new Point(490, 529);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(202, 39);
            textBox1.TabIndex = 57;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Gold;
            label2.Location = new Point(345, 532);
            label2.Name = "label2";
            label2.Size = new Size(139, 31);
            label2.TabIndex = 56;
            label2.Text = "Issue Book ID:";
            // 
            // ReturnBook
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1289, 638);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(textBox4);
            Controls.Add(label7);
            Controls.Add(Username);
            Controls.Add(dataGridView1);
            Name = "ReturnBook";
            Text = "ReturnBook";
            Load += ReturnBook_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Username;
        private DataGridView dataGridView1;
        private Button button2;
        private TextBox textBox4;
        private Label label7;
        private Button button1;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private Label label2;
    }
}