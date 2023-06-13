using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExchangeRateConverterApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            currentexchangerateclass currentexchangerateclass = new currentexchangerateclass();
            currentexchangerateclass.GetForexData();

            double dolarbuying = currentexchangerateclass.DolarForexBuying;
            double dolarselling = currentexchangerateclass.DolarForexSelling;
            USD_Buy_label.Text = dolarbuying.ToString();
            USD_Sell_label.Text = dolarselling.ToString();

            double euroBuying = currentexchangerateclass.EuroForexBuying;
            double euroSelling = currentexchangerateclass.EuroForexSelling;
            EUR_Buy_label.Text = euroBuying.ToString();
            EUR_Sell_label.Text = euroSelling.ToString();

            double sterlinBuying = currentexchangerateclass.SterlinForexBuying;
            double sterlinSelling = currentexchangerateclass.SterlinForexSelling;
            GBP_Buy_label.Text = sterlinBuying.ToString();
            GBP_Sell_label.Text = sterlinSelling.ToString();

            double kanadaDolariBuying = currentexchangerateclass.CADForexBuying;
            double kanadaDolariSelling = currentexchangerateclass.CADForexSelling;
            CAD_Buy_label.Text = kanadaDolariBuying.ToString();
            CAD_Sell_label.Text = kanadaDolariSelling.ToString();

            double aznBuying = currentexchangerateclass.AZNForexBuying;
            double aznSelling = currentexchangerateclass.AZNForexSelling;
            AZN_Buy_label.Text = aznBuying.ToString();
            AZN_Sell_label.Text = aznSelling.ToString();

            double aedBuying = currentexchangerateclass.AEDForexBuying;
            double aedSelling = currentexchangerateclass.AEDForexSelling;
            AED_Buy_label.Text = aedBuying.ToString();
            AED_Sell_label.Text = aedSelling.ToString();

            double nokBuying = currentexchangerateclass.NOKForexBuying;
            double nokSelling = currentexchangerateclass.NOKForexSelling;
            NOK_Buy_label.Text = nokBuying.ToString();
            NOK_Sell_label.Text = nokSelling.ToString();

            double chfBuying = currentexchangerateclass.CHFForexBuying;
            double chfSelling = currentexchangerateclass.CHFForexSelling;
            CHF_Buy_label.Text = chfBuying.ToString();
            CHF_Sell_label.Text = chfSelling.ToString();

            double sekBuying = currentexchangerateclass.SEKForexBuying;
            double sekSelling = currentexchangerateclass.SEKForexSelling;
            SEK_Buy_label.Text = sekBuying.ToString();
            SEK_Sell_label.Text = sekSelling.ToString();

        }

        private void Calculator_button_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();
            calculator.Show();
        }
    }
}
