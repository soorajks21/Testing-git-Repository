using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginApp
{
    public partial class Question : Form
    {
        public Question()
        {
            InitializeComponent();
            comboBox1.Items.Add("List of Users wh")
        }

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int val = comboBox1.SelectedIndex;
            int ss = val;

        }
    }
}
