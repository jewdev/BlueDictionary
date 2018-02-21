using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace Blue_Dictionary
{
    public partial class Form1 : Form
    {
        string title = "Blue Dictionary";
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text =="")
            {
                richTextBox1.Text = "ENTER A WORD!";
                MessageBox.Show("Enter a word to define!", title, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                richTextBox1.Text = "";
                lookupTheSexyWORD();
            }
        }
        public void lookupTheSexyWORD()
        {
            WebRequest.Create("https://api.apithis.net/dictionary.php?define=" + textBox1);
            richTextBox1.Text = new System.Net.WebClient().DownloadString("https://api.apithis.net/dictionary.php?define=" + textBox1.Text);
        }
    }
}
