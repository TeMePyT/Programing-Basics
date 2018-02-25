using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyConverter
{
    public partial class FormConverter : Form
    {
        public FormConverter()
        {
            InitializeComponent();
        }
        private void FormConverter_Load(object sender, EventArgs e)
        {
            this.comboBoxCurrency.SelectedItem = "EUR";
        }
        private void numericUpDownAmmount_ValueChanged(object sender, EventArgs e)
        {
            ConvertCurrency();
        }

        private void comboBoxCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConvertCurrency();
        }

       
        private void ConvertCurrency()
        {
            var originalAmmount = this.numericUpDownAmmount.Value;
            var convertedAmmount = originalAmmount;
            if (this.comboBoxCurrency.SelectedItem.ToString() == "EUR")
            {
                convertedAmmount = originalAmmount * 0.510941664m;
            }
            else if (this.comboBoxCurrency.SelectedItem.ToString() == "USD")
            { 
                convertedAmmount = originalAmmount * 0.62317m;
            }
            else if (this.comboBoxCurrency.SelectedItem.ToString() == "GBP")
            {
                convertedAmmount = originalAmmount * 0.453778881m;
            }
            this.labelResult.Text = originalAmmount + " лв.= " + Math.Round (convertedAmmount, 2) + " " + this.comboBoxCurrency.SelectedItem;
        }
    }
}
