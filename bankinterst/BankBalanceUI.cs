using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bankinterst
{
    public partial class BankBalanceUI : Form
    {
        public BankBalanceUI()
        {
            InitializeComponent();
        }
        private Double year = 0;
        private Double balance = 0;
            

        private void showButton_Click(object sender, EventArgs e)
        {
            string bankName = interst_comboBox.Text;
            year = Convert.ToInt32(yearBox.Text);
            balance = Convert.ToInt32(balanceBox.Text);
            Double total = (balance / 100 * year);
            
            if (bankName == "BRAC") 
            {
                MessageBox.Show((total * 6 + balance).ToString());
            }
            else if (bankName == "DBL")
            {
                MessageBox.Show((total * 7 + balance).ToString());
            }
            else 
            {
                MessageBox.Show((total * 8 + balance).ToString());
            }
        }
    }
}
