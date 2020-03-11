using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace LoginAndStarApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AutoCompleteStringCollection source = new AutoCompleteStringCollection()
        {
            "Vova",
            "Admin",
            "Marina",
            "Arseniy"
        };
            textBox1.AutoCompleteCustomSource = source;
            textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Vova" && textBox2.Text == "A9m1G5")
            {
                Process prc = new Process();
                prc.StartInfo.FileName = "Notepad++.exe";
                prc.Start();
                prc.WaitForExit();
                this.Close();
                
            }
            else if(textBox1.Text == "Admin" && textBox2.Text == "12345")
             {
                Process prc = new Process();
                prc.StartInfo.FileName = "SharpDevelop.exe";
                prc.Start();
                prc.WaitForExit();
                this.Close();

             }
            else
            {
                textBox1.Text = "";
                textBox2.Text = "";
                MessageBox.Show("неправильное имя пользователя или пароль");
            }
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
         
        }
    }
}
