namespace practice_library
{
    partial class ViewBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewBooks));
            dataGridView1 = new DataGridView();
            Username = new Label();
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Maroon;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.DarkCyan;
            dataGridView1.Location = new Point(137, 149);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.PaleTurquoise;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.Aquamarine;
            dataGridViewCellStyle1.SelectionForeColor = Color.LightSeaGreen;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1108, 428);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.BackColor = Color.Transparent;
            Username.Font = new Font("Segoe Print", 20F, FontStyle.Bold, GraphicsUnit.Point);
            Username.ForeColor = Color.Yellow;
            Username.Location = new Point(592, 9);
            Username.Name = "Username";
            Username.Size = new Size(258, 71);
            Username.TabIndex = 3;
            Username.Text = "View Books";
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.Font = new Font("Segoe Print", 6F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(886, 92);
            button1.Name = "button1";
            button1.Size = new Size(99, 35);
            button1.TabIndex = 20;
            button1.Text = " View Books";
            button1.UseVisualStyleBackColor = false;
            button1.Click += ViewBooks_Load;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(370, 96);
            label1.Name = "label1";
            label1.Size = new Size(123, 31);
            label1.TabIndex = 22;
            label1.Text = "Book Name:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Maroon;
            textBox1.Font = new Font("Segoe Print", 11F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(499, 88);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(381, 46);
            textBox1.TabIndex = 21;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // ViewBooks
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1357, 589);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(Username);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewBooks";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewBooks";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label Username;
        private Button button1;
        private Label label1;
        private Button button2;
        private TextBox textBox4;
        private Label label7;
        private TextBox textBox1;
    }
}