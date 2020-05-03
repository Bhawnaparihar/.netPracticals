using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;

namespace BackColor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ConfigureColor();
        }
        private void ConfigureColor()
        {
            try
            {
                string colorName = ConfigurationManager.
                    AppSettings["BackColor"];
                this.BackColor = Color.FromName(colorName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



    }
}
