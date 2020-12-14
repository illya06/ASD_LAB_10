using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASD_LAB_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void clear()
        {
            result.Text = "";
        }

        private void start_Click(object sender, EventArgs e)
        {
            clear();
            string pt = pattern.Text;
            string tg = target.Text;

            for (int i = 0; i < tg.Length - pt.Length + 1; i++)
            {
                int j = i;
                bool check = false;
                string temp = pt;
                foreach(char ch in pt)
                {
                    
                    if (ch == '?')
                    {
                        temp = temp.Replace('?', tg[j]);
                    }
                    else 
                    {
                        if (ch == tg[j])
                        {
                            check = true;
                        }
                        else
                        {
                            check = false;
                            break;
                        }
                    }
                    
                    j++;
                }
                if (check)
                {
                    result.Text += $"\nINDEX ({i}) : {temp}";
                }
            }
        }
    }
}
