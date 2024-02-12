using System;
using System.Windows.Forms;

namespace Riley_Mortgage
{
    public partial class frm_Mortgage_Calculator : Form
    {
        // Variables for the formula
        private double principal;
        private double numberOfPayments;
        private double monthlyInterestRate;

        public frm_Mortgage_Calculator()
        {
            InitializeComponent();
        }

        private void frm_Mortgage_Calculator_Load(object sender, EventArgs e)
        {
            this.Text = "Blake Riley : Mortgage Calculator";
        }
        private void TermChanged(object sender, EventArgs e)
        {
            if (RBO_15Year.Checked)
            {
                numberOfPayments = 15 * 12;
                TXT_Other.Visible = false;
            }
            else if (RBO_30Year.Checked)
            {
                numberOfPayments = 30 * 12;
                TXT_Other.Visible = false;
            }
            else if (RBO_Other.Checked)
            {
                TXT_Other.Visible = true;
            }
        }

        private void BTN_Calculate_Click(object sender, EventArgs e)
        {
            if (RBO_Other.Checked)
            {
                numberOfPayments = double.Parse(TXT_Other.Text) * 12;
            }
            monthlyInterestRate = (double.Parse(CBX_Interest.Text) / 10) + 3;
            principal = double.Parse(TXT_Principal.Text);
            monthlyInterestRate = monthlyInterestRate / 100 / 12;
            double monthlyPayment = principal * ((monthlyInterestRate * (Math.Pow(1 + monthlyInterestRate,numberOfPayments))) / ((Math.Pow(1 + monthlyInterestRate, numberOfPayments)) - 1));
            LBL_MonthlyPayment.Text = monthlyPayment.ToString("c");

        }

        private void BTN_Reset_Click(object sender, EventArgs e)
        {
            TXT_Principal.Clear();
            TXT_Principal.Select();
            TXT_Other.Clear();
            RBO_15Year.Checked = false;
            RBO_30Year.Checked = true;
            RBO_Other.Checked = false;
            TXT_Other.Visible = false;
            CBX_Interest.SelectedIndex = -1;
            LBL_MonthlyPayment.Text = "";
        }

        private void BTN_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
