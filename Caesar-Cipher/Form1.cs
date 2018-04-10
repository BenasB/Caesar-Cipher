using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caesar_Cipher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CipherButton_Click(object sender, EventArgs e)
        {
            string inputText = PlainBox.Text;

            if (inputText.Length == 0)
                return;

            if (ShiftAll.Checked)
            {
                CipherBox.Clear();

                for (int i = 1; i < 26; i++)
                {
                    CipherBox.Text += Caesar.Cipher(inputText, i);

                    if (i != 25)
                        CipherBox.Text += Environment.NewLine;
                }
            }
            else
                CipherBox.Text = Caesar.Cipher(inputText, (int)ShiftInput.Value);
        }

        private void DecipherButton_Click(object sender, EventArgs e)
        {
            string inputText = CipherBox.Text;

            if (inputText.Length == 0)
                return;

            if (ShiftAll.Checked)
            {
                PlainBox.Clear();

                for (int i = 1; i < 26; i++)
                {
                    PlainBox.Text += Caesar.Decipher(inputText, i);

                    if (i != 25)
                        PlainBox.Text += Environment.NewLine;
                }
            }
            else
                PlainBox.Text = Caesar.Decipher(inputText, (int)ShiftInput.Value);
        }

        private void ShiftAll_CheckedChanged(object sender, EventArgs e)
        {
            ShiftInput.Enabled = !ShiftAll.Checked;
        }
    }
}
