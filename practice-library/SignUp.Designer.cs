namespace practice_library
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            emailTextBox = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // usernameTextBox
            // 
            usernameTextBox.Font = new Font("Segoe Print", 11F, FontStyle.Regular, GraphicsUnit.Point);
            usernameTextBox.Location = new Point(477, 158);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(316, 46);
            usernameTextBox.TabIndex = 0;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Segoe Print", 11F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTextBox.Location = new Point(477, 216);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(316, 46);
            passwordTextBox.TabIndex = 1;
            // 
            // emailTextBox
            // 
            emailTextBox.Font = new Font("Segoe Print", 11F, FontStyle.Regular, GraphicsUnit.Point);
            emailTextBox.Location = new Point(477, 275);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(316, 46);
            emailTextBox.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.WindowText;
            button1.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Yellow;
            button1.Location = new Point(551, 327);
            button1.Name = "button1";
            button1.Size = new Size(112, 37);
            button1.TabIndex = 3;
            button1.Text = "Sign Up";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(329, 161);
            label1.Name = "label1";
            label1.Size = new Size(133, 38);
            label1.TabIndex = 4;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(329, 219);
            label2.Name = "label2";
            label2.Size = new Size(128, 38);
            label2.TabIndex = 5;
            label2.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Print", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(362, 275);
            label3.Name = "label3";
            label3.Size = new Size(86, 38);
            label3.TabIndex = 6;
            label3.Text = "Email:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(974, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(153, 129);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.Window;
            pictureBox2.Image = Properties.Resources.svcc_logo_removebg_preview__1_;
            pictureBox2.Location = new Point(25, 24);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(144, 129);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(1155, 678);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(emailTextBox);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Name = "SignUp";
            Text = "SignUp";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private TextBox emailTextBox;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}