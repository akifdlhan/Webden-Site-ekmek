using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wepdensiteçekmek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                webBrowser1.ScriptErrorsSuppressed = true;
                webBrowser1.Navigate("https://www.fotomac.com.tr");
            }else if(comboBox1.SelectedIndex == 1)
            {
                webBrowser1.ScriptErrorsSuppressed = true;
                webBrowser1.Navigate("https://www.sahibinden.com");
            }else if (comboBox1.SelectedIndex == 2)
            {
                webBrowser1.ScriptErrorsSuppressed = true;
                webBrowser1.Navigate("https://www.kariyer.net");

            }else if (comboBox1.SelectedIndex == 3)
            {
                webBrowser1.ScriptErrorsSuppressed = true;
                webBrowser1.Navigate("https://obs.yyu.edu.tr/login.aspx");
            }else if(comboBox1.SelectedIndex == 4)
            {
                webBrowser1.ScriptErrorsSuppressed = true;
                webBrowser1.Navigate("https://www.netflix.com/browse");

            }
        }

    }
}
