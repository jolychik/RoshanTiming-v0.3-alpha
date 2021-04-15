﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class RT : Form
    {
        public RT()
        {
            InitializeComponent();
            //Lminute.Text = Properties.Setting.Default.Язык;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RoshanTimer_Load_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Calc_Click(object sender, EventArgs e)
        {


            if (Minute.Text == "")
            {
                label6.Visible = true;
                label6.ForeColor = Color.Red;
                label6.Text = ("Вы не ввели минуту");


            }
            else
            {
                Calc.Visible = false;
                Again.Visible = true;
                if (Second.Text == "")
                {
                    Second.Text = "00";
                }
                int min = Convert.ToInt32(Minute.Text);
                int sec = Convert.ToInt32(Second.Text);
                int time1;
                int time2;
                int time3;

                time1 = min + 5;
                time2 = min + 8;
                time3 = min + 11;

                label1.Text = ("Время смерти рошана - ") + Convert.ToString(min) + (":") + Convert.ToString(sec);

                label2.Text = ("Время окончания аегиса - ") + Convert.ToString(time1) + (":") + Convert.ToString(sec);

                label3.Text = ("Время респавна рошана (min) - ") + Convert.ToString(time2) + (":") + Convert.ToString(sec);

                label4.Text = ("Время респавна рошана (max) - ") + Convert.ToString(time3) + (":") + Convert.ToString(sec);

                label5.Text = ("Died") + ("(") + Convert.ToString(min) + (":") + Convert.ToString(sec) + (")-Aegis(") + Convert.ToString(time1) + (":") + Convert.ToString(sec) + (")-Res.Min(") + Convert.ToString(time2) + (":") + Convert.ToString(sec) + (")-Res.Max(") + Convert.ToString(time3) + (":") + Convert.ToString(sec) + (")");

                panel1.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                //label5.Visible = true;
                //Copy.Visible = true;

                if ((Second.Text == "01") || (Second.Text == "02") || (Second.Text == "03") || (Second.Text == "04") || (Second.Text == "05") || (Second.Text == "06") || (Second.Text == "07") || (Second.Text == "08") || (Second.Text == "09") ||
                    (Second.Text == "1") || (Second.Text == "2") || (Second.Text == "3") || (Second.Text == "4") || (Second.Text == "5") || (Second.Text == "6") || (Second.Text == "7") || (Second.Text == "8") || (Second.Text == "9") ||
                    (Second.Text == "0") || (Second.Text == "00"))
                {
                    label1.Text = ("Время смерти рошана - ") + Convert.ToString(min) + (":") + ("0") + Convert.ToString(sec);

                    label2.Text = ("Время окончания аегиса - ") + Convert.ToString(time1) + (":") + ("0") + Convert.ToString(sec);

                    label3.Text = ("Время респавна рошана (min) - ") + Convert.ToString(time2) + (":") + ("0") + Convert.ToString(sec);

                    label4.Text = ("Время респавна рошана (max) - ") + Convert.ToString(time3) + (":") + ("0") + Convert.ToString(sec);

                    label5.Text = ("Died") + ("(") + Convert.ToString(min) + (":") + ("0") + Convert.ToString(sec) + (")-Aegis(") + Convert.ToString(time1) + (":") + ("0") + Convert.ToString(sec) + (")-Res.Min(") + Convert.ToString(time2) + (":") + ("0") + Convert.ToString(sec) + (")-Res.Max(") + Convert.ToString(time3) + (":") + ("0") + Convert.ToString(sec) + (")");
                }

                label5.Visible = true;
                Clipboard.SetText(label5.Text);
                label7.Visible = true;
                panel2.Visible = true;
            } 
        }

        private void Minute_TextChanged(object sender, EventArgs e)
        {

            Minute.MaxLength = 3;
            Minute.TabIndex = 2;
            Minute.TabStop = true;
        }

        private void Minute_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void Second_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void Second_TextChanged(object sender, EventArgs e)
        {
            Second.MaxLength = 2;

     
            for (int i = 0; i < Second.Text.Length; i++)
                if (!Char.IsDigit(Second.Text[i]))
                    Second.Clear();
        }

        private void RoshanTimer_Load(object sender, EventArgs e)
        {
           //this.Lminute.Text = Properties.Setting.Default.Язык;
        }

        private void Lsecond_Click(object sender, EventArgs e)
        {

        }

        //private void Back_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    RoshTime MainMenu = new RoshTime();
        //    MainMenu.Show();
        //}

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Application.Exit();
        }

        private void Minute_Enter_1(object sender, EventArgs e)
        {

            label6.Visible = false;
        }

        private void Second_Enter(object sender, EventArgs e)
        {

            label6.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        internal static class GlobabalModule
        {
            public static List<string> CodeList { get; set; }

            public static void InitList()
            {
                CodeList = new List<string>();
            }
        }
        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            AboutBox1 box = new AboutBox1();
            box.ShowDialog();
        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //   label5.Visible = true;
        //    Clipboard.SetText(label5.Text);
        //    label7.Visible = true;
        //    panel2.Visible = true;
        //}

        private void Second_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode >= Keys.D0) && (e.KeyCode <= Keys.D9) ||
             ((e.KeyCode >= Keys.NumPad0) && (e.KeyCode <= Keys.NumPad9)))
            {
                int Value = Convert.ToInt32(Second.Text);
                if (((Second.Text.Length >= 2) && (Value < 0) || (Value > 59)) ||
                    ((Second.Text.Length < 2) && ((Value < 0) || (Value > 59))))
                    Second.Text = ("59");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void c_Click(object sender, EventArgs e)
        {
            Minute.Text = "";
            Second.Text = "";
            panel1.Visible = false;
            panel2.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label7.Visible = false;
            Minute.Focus();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Properties.Setting.Default.Язык = Lminute.Text;
            //Properties.Setting.Default.Save();
        }

        private void Again_Click(object sender, EventArgs e)
        {
            Minute.Text = "";
            Second.Text = "";
            panel1.Visible = false;
            panel2.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label7.Visible = false;
            Again.Visible = false;
            Calc.Visible = true;
            Minute.Focus();
        }
    }
}