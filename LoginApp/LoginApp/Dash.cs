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
    public partial class Dash : Form
    {
        public Dash()
        {
            InitializeComponent();
        }

        private void addAccountBtn_Click(object sender, EventArgs e)
        {
            CreateAccount createAccount = new CreateAccount();
            this.Hide();
            createAccount.Show();
        }

        private void addOrderBtn_Click(object sender, EventArgs e)
        {
            NewOrder newOrder = new NewOrder();
            this.Hide();
            newOrder.Show();
        }

        private void deleteOrderBtn_Click(object sender, EventArgs e)
        {
            FindOrder findOrder = new FindOrder();
            this.Hide();
            findOrder.Show();
        }

        private void qestionBtn_Click(object sender, EventArgs e)
        {
            Question question = new Question();
            this.Hide();
            question.Show();
        }

    }
}
