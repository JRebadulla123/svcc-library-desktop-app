namespace practice_library
{
    partial class AddBooks
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
            textBox1 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox5 = new TextBox();
            label5 = new Label();
            textBox6 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            textBox4 = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.BackColor = Color.Transparent;
            Username.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Username.ForeColor = Color.Gold;
            Username.Location = new Point(118, 110);
            Username.Name = "Username";
            Username.Size = new Size(123, 31);
            Username.TabIndex = 2;
            Username.Text = "Book Name:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Maroon;
            textBox1.Font = new Font("Segoe Print", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Yellow;
            textBox1.Location = new Point(263, 102);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(287, 39);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.PapayaWhip;
            button1.BackgroundImage = Properties.Resources.Maroon_color_bg;
            button1.Font = new Font("Segoe Print", 8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Yellow;
            button1.Image = Properties.Resources.Maroon_color_bg;
            button1.Location = new Point(337, 433);
            button1.Name = "button1";
            button1.Size = new Size(108, 40);
            button1.TabIndex = 5;
            button1.Text = "Add Books";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(99, 167);
            label1.Name = "label1";
            label1.Size = new Size(142, 31);
            label1.TabIndex = 6;
            label1.Text = "Author Name:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Gold;
            label2.Location = new Point(121, 218);
            label2.Name = "label2";
            label2.Size = new Size(118, 31);
            label2.TabIndex = 7;
            label2.Text = "Publication:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Gold;
            label3.Location = new Point(90, 266);
            label3.Name = "label3";
            label3.Size = new Size(149, 31);
            label3.TabIndex = 8;
            label3.Text = "Purchase Date:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Gold;
            label4.Location = new Point(119, 324);
            label4.Name = "label4";
            label4.Size = new Size(115, 31);
            label4.TabIndex = 9;
            label4.Text = "Book Price:";
            label4.Click += label4_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Maroon;
            textBox2.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.ForeColor = Color.Yellow;
            textBox2.Location = new Point(263, 159);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(287, 39);
            textBox2.TabIndex = 10;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Maroon;
            textBox3.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.ForeColor = Color.Yellow;
            textBox3.Location = new Point(263, 210);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(287, 39);
            textBox3.TabIndex = 11;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.Maroon;
            textBox5.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox5.ForeColor = Color.Yellow;
            textBox5.Location = new Point(263, 316);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(287, 39);
            textBox5.TabIndex = 13;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Gold;
            label5.Location = new Point(90, 377);
            label5.Name = "label5";
            label5.Size = new Size(151, 31);
            label5.TabIndex = 14;
            label5.Text = "Book Quantity:";
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.Maroon;
            textBox6.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox6.ForeColor = Color.Yellow;
            textBox6.Location = new Point(263, 374);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(287, 39);
            textBox6.TabIndex = 15;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker1.CalendarForeColor = Color.Yellow;
            dateTimePicker1.CalendarMonthBackground = Color.Maroon;
            dateTimePicker1.Location = new Point(263, 266);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(287, 31);
            dateTimePicker1.TabIndex = 16;
            dateTimePicker1.Value = new DateTime(2023, 3, 10, 11, 21, 29, 0);
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.Maroon;
            textBox4.Font = new Font("Segoe Print", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBox4.ForeColor = Color.Yellow;
            textBox4.Location = new Point(263, 42);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(287, 39);
            textBox4.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Gold;
            label6.Location = new Point(118, 50);
            label6.Name = "label6";
            label6.Size = new Size(112, 31);
            label6.TabIndex = 18;
            label6.Text = "book ISBN:";
            // 
            // AddBooks
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(701, 501);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox6);
            Controls.Add(label5);
            Controls.Add(textBox5);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(Username);
            Name = "AddBooks";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += AddBooks_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Username;
        private TextBox textBox1;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox6;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox4;
        private Label label6;
    }
}