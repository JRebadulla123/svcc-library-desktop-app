﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice_library
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddBooks addBooks = new AddBooks();
            addBooks.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewBooks viewBooks = new ViewBooks();
            viewBooks.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ViewStudent viewStudent = new ViewStudent();
            viewStudent.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            IssueBookReport report = new IssueBookReport();
            report.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ReturnBook returnBook = new ReturnBook();
            returnBook.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddStudent addStudent = new AddStudent();
            addStudent.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ReturnBookReport returnBookReport = new ReturnBookReport();
            returnBookReport.Show();
        }


        private void button8_Click_1(object sender, EventArgs e)
        {
            IssueBooks issueBooks = new IssueBooks();
            issueBooks.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.WindowState = FormWindowState.Maximized;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }


        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}

