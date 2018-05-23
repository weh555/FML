using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pipASCII
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = string.Empty;
            textBox1.Text = "115.104.105";
            /*
             * 
             * */
            //byte[] aaa = new byte[3];
            //aaa[0] = 115;
            //aaa[1] = 104;
            //aaa[2] = 105;
            //string shi = Convert.ToString(System.Text.Encoding.ASCII.GetString(aaa));
            //label1.Text = shi;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            byte[] toresult;
            if(textBox1.Text.Contains("."))
            {
                if (e.KeyCode == Keys.Enter)
                {
                    string[] text = textBox1.Text.Split(new char[] { '.' });
                    byte[] forlength = System.Text.Encoding.ASCII.GetBytes(textBox1.Text);
                    toresult = new byte[forlength.Length];
                    for (int i = 0; i < text.Length; i++)
                    {
                        int num = Convert.ToInt32(text[i]);
                        toresult[i] = (byte)num;
                    }
                    string result = Convert.ToString(System.Text.Encoding.ASCII.GetString(toresult));
                    label1.Font = new Font("Adobe Arabic", 15, FontStyle.Bold);
                    label1.Text = result;
                    this.Text = "Love Forever";
                    this.Icon = new Icon(Application.StartupPath +"\\image\\love.ico");
                    this.BackColor = Color.Pink;
                    this.textBox1.BackColor = Color.Pink;
                    this.ForeColor = Color.White;
                    this.label1.ForeColor = Color.White;
                    this.textBox1.ForeColor = Color.White;
                }
            }
        }
    }
}
