using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random random = new Random();
        string secretKey;
        private void button1_Click(object sender, EventArgs e)
        {
            string guess = textBox1.Text;
            if (guess==secretKey)
            {
                MessageBox.Show("Kazandınız...");

            }
            else
            {
                char[] letters = guess.ToCharArray();
                string matchedLetters = "";
                foreach (char letter in letters)
                {
                    if (secretKey.Contains(letter))
                    {
                        matchedLetters += $"{letter},";
                    }
                }
                if (matchedLetters != "")
                {
                    matchedLetters = matchedLetters.TrimEnd(',');
                    listBox1.Items.Add(matchedLetters);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string[] secretKeys = { "Elma", "Armut", "bilgisayar", "silgi", "futbol" };
            secretKey = secretKeys[random.Next(0, 5)];
            textBox1.Enabled = true;
            button1.Enabled = true;
            textBox1.Text = "";
        }
    }
}
