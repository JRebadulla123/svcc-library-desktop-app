namespace practice_library
{
    partial class IssueBookReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IssueBookReport));
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            Username = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(471, 133);
            label1.Name = "label1";
            label1.Size = new Size(123, 31);
            label1.TabIndex = 58;
            label1.Text = "Book Name:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Maroon;
            textBox1.Font = new Font("Segoe Print", 11F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(610, 126);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(282, 46);
            textBox1.TabIndex = 57;
            // 
            // button1
            // 
            button1.BackColor = Color.PapayaWhip;
            button1.BackgroundImage = Properties.Resources.Maroon_color_bg;
            button1.Font = new Font("Segoe Print", 8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(909, 133);
            button1.Name = "button1";
            button1.Size = new Size(126, 34);
            button1.TabIndex = 56;
            button1.Text = "View Books";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.BackColor = Color.Transparent;
            Username.Font = new Font("Segoe Print", 20F, FontStyle.Bold, GraphicsUnit.Point);
            Username.ForeColor = Color.Gold;
            Username.Location = new Point(2984, 213);
            Username.Name = "Username";
            Username.Size = new Size(408, 71);
            Username.TabIndex = 55;
            Username.Text = "Issue Books Report";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Maroon;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(231, 198);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1003, 446);
            dataGridView1.TabIndex = 54;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // IssueBookReport
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1410, 688);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(Username);
            Controls.Add(dataGridView1);
            Name = "IssueBookReport";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IssueBookReport";
            Load += IssueBookReport_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Label Username;
        private DataGridView dataGridView1;
    }
}