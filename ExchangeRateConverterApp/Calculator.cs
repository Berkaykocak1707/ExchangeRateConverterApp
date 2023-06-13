using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ExchangeRateConverterApp
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
        double dolarbuying = 0;
        double dolarselling = 0;

        double euroSelling = 0;
        double euroBuying = 0;
        
        double sterlinBuying = 0;
        double sterlinSelling = 0;
        
        double CADBuying = 0;
        double CADSelling = 0;
        
        double aedBuying = 0;
        double aedSelling = 0;
        
        double nokBuying = 0;
        double nokSelling = 0;
        
        double chfBuying = 0;
        double chfSelling = 0;
        
        double sekBuying = 0;
        double sekSelling = 0;
        
        double aznBuying = 0;
        double aznSelling = 0;
        private bool isUpdating = false;
        private void Forex_Buying_button_Click(object sender, EventArgs e)
        {
            TRY_Buy_Textbox.Visible = true;
            USD_Buy_textBox.Visible = true;
            EUR_Buy_textBox.Visible = true;
            USD_Buy_textBox.Visible = true;
            EUR_Buy_textBox.Visible = true;
            GBP_Buy_textBox.Visible = true;
            CAD_Buy_textBox.Visible = true;
            AZN_Buy_textBox.Visible = true;
            AED_Buy_textBox.Visible = true;
            NOK_Buy_textBox.Visible = true;
            CHF_Buy_textBox.Visible = true;
            SEK_Buy_textBox.Visible = true;
            TRY_Sell_TextBox.Visible = false;
            EUR_Sell_textBox.Visible = false;
            USD_Sell_textBox.Visible = false;
            EUR_Sell_textBox.Visible = false;
            GBP_Sell_textBox.Visible = false;
            CAD_Sell_textBox.Visible = false;
            AZN_Sell_textBox.Visible = false;
            AED_Sell_textBox.Visible = false;
            NOK_Sell_textBox.Visible = false;
            CHF_Sell_textBox.Visible = false;
            SEK_Sell_textBox.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TRY_Sell_TextBox.Visible = true;
            USD_Buy_textBox.Visible = false;
            EUR_Buy_textBox.Visible = false;
            USD_Buy_textBox.Visible = false;
            EUR_Buy_textBox.Visible = false;
            GBP_Buy_textBox.Visible = false;
            CAD_Buy_textBox.Visible = false;
            AZN_Buy_textBox.Visible = false;
            AED_Buy_textBox.Visible = false;
            NOK_Buy_textBox.Visible = false;
            CHF_Buy_textBox.Visible = false;
            SEK_Buy_textBox.Visible = false;
            TRY_Buy_Textbox.Visible = false;
            EUR_Sell_textBox.Visible = true;
            USD_Sell_textBox.Visible = true;
            EUR_Sell_textBox.Visible = true;
            GBP_Sell_textBox.Visible = true;
            CAD_Sell_textBox.Visible = true;
            AZN_Sell_textBox.Visible = true;
            AED_Sell_textBox.Visible = true;
            NOK_Sell_textBox.Visible = true;
            CHF_Sell_textBox.Visible = true;
            SEK_Sell_textBox.Visible = true;
        }

        private void TRY_Buy_Textbox_TextChanged(object sender, EventArgs e)
        {
            if (isUpdating)
                return;

            isUpdating = true;
            if (string.IsNullOrWhiteSpace(TRY_Buy_Textbox.Text))
            {

            }
            else
            {

                double limit;
                if (double.TryParse(TRY_Buy_Textbox.Text, out limit))
                {
                    double currentValue = Convert.ToDouble(TRY_Buy_Textbox.Text);

                    USD_Buy_textBox.Text = (currentValue / dolarbuying).ToString();
                    EUR_Buy_textBox.Text = (currentValue / euroBuying).ToString();
                    GBP_Buy_textBox.Text = (currentValue / sterlinBuying).ToString();
                    CAD_Buy_textBox.Text = (currentValue / CADBuying).ToString();
                    AED_Buy_textBox.Text = (currentValue / aedBuying).ToString();
                    NOK_Buy_textBox.Text = (currentValue / nokBuying).ToString();
                    CHF_Buy_textBox.Text = (currentValue / chfBuying).ToString();
                    SEK_Buy_textBox.Text = (currentValue / sekBuying).ToString();
                    AZN_Buy_textBox.Text = (currentValue / aznBuying).ToString();
                }
                else
                {

                }
            }
            
            isUpdating = false;

        }
        private void Calculator_Load(object sender, EventArgs e)
        {
            currentexchangerateclass currentexchangerateclass = new currentexchangerateclass();
            currentexchangerateclass.GetForexData();

            dolarbuying = currentexchangerateclass.DolarForexBuying;
            dolarselling = currentexchangerateclass.DolarForexSelling;

            euroBuying = currentexchangerateclass.EuroForexBuying;
            euroSelling = currentexchangerateclass.EuroForexSelling;

            sterlinBuying = currentexchangerateclass.SterlinForexBuying;
            sterlinSelling = currentexchangerateclass.SterlinForexSelling;

            CADBuying = currentexchangerateclass.CADForexBuying;
            CADSelling = currentexchangerateclass.CADForexSelling;

            aznBuying = currentexchangerateclass.AZNForexBuying;
            aznSelling = currentexchangerateclass.AZNForexSelling;

            aedBuying = currentexchangerateclass.AEDForexBuying;
            aedSelling = currentexchangerateclass.AEDForexSelling;

            nokBuying = currentexchangerateclass.NOKForexBuying;
            nokSelling = currentexchangerateclass.NOKForexSelling;


            chfBuying = currentexchangerateclass.CHFForexBuying;
            chfSelling = currentexchangerateclass.CHFForexSelling;

            sekBuying = currentexchangerateclass.SEKForexBuying;
            sekSelling = currentexchangerateclass.SEKForexSelling;
        }
        private void USD_Buy_textBox_TextChanged(object sender, EventArgs e)
        {
            if (isUpdating)
                return;

            isUpdating = true;
            if (string.IsNullOrWhiteSpace(USD_Buy_textBox.Text))
            {

            }
            else
            {

                double limit;
                if (double.TryParse(USD_Buy_textBox.Text, out limit))
                {
                    double currentValue = Convert.ToDouble(USD_Buy_textBox.Text);

                    TRY_Buy_Textbox.Text = (currentValue * dolarbuying).ToString();
                    EUR_Buy_textBox.Text = (currentValue * dolarbuying / euroBuying).ToString();
                    GBP_Buy_textBox.Text = (currentValue * dolarbuying / sterlinBuying).ToString();
                    CAD_Buy_textBox.Text = (currentValue * dolarbuying / CADBuying).ToString();
                    AED_Buy_textBox.Text = (currentValue * dolarbuying / aedBuying).ToString();
                    NOK_Buy_textBox.Text = (currentValue * dolarbuying / nokBuying).ToString();
                    CHF_Buy_textBox.Text = (currentValue * dolarbuying / chfBuying).ToString();
                    SEK_Buy_textBox.Text = (currentValue * dolarbuying / sekBuying).ToString();
                    AZN_Buy_textBox.Text = (currentValue * dolarbuying / aznBuying).ToString();
                }
                else
                {

                }
            }
            
            isUpdating = false;
        }

        private void EUR_Buy_textBox_TextChanged(object sender, EventArgs e)
        {
            if (isUpdating)
                return;

            isUpdating = true;
            if (string.IsNullOrWhiteSpace(USD_Buy_textBox.Text))
            {

            }
            else
            {

                double limit;
                if (double.TryParse(USD_Buy_textBox.Text, out limit))
                {
                    double currentValue = Convert.ToDouble(EUR_Buy_textBox.Text);

                    TRY_Buy_Textbox.Text = (currentValue * euroBuying).ToString();
                    USD_Buy_textBox.Text = (currentValue * euroBuying / dolarbuying).ToString();
                    GBP_Buy_textBox.Text = (currentValue * euroBuying / sterlinBuying).ToString();
                    CAD_Buy_textBox.Text = (currentValue * euroBuying / CADBuying).ToString();
                    AED_Buy_textBox.Text = (currentValue * euroBuying / aedBuying).ToString();
                    NOK_Buy_textBox.Text = (currentValue * euroBuying / nokBuying).ToString();
                    CHF_Buy_textBox.Text = (currentValue * euroBuying / chfBuying).ToString();
                    SEK_Buy_textBox.Text = (currentValue * euroBuying / sekBuying).ToString();
                    AZN_Buy_textBox.Text = (currentValue * euroBuying / aznBuying).ToString();
                }
                else
                {

                }
            }
            
            isUpdating = false;
        }

        private void GBP_Buy_textBox_TextChanged(object sender, EventArgs e)
        {
            if (isUpdating)
                return;

            isUpdating = true;
            if (string.IsNullOrWhiteSpace(GBP_Buy_textBox.Text))
            {

            }
            else
            {

                double limit;
                if (double.TryParse(GBP_Buy_textBox.Text, out limit))
                {
                    double currentValue = Convert.ToDouble(GBP_Buy_textBox.Text);

                    TRY_Buy_Textbox.Text = (currentValue * sterlinBuying).ToString();
                    USD_Buy_textBox.Text = (currentValue * sterlinBuying / dolarbuying).ToString();
                    EUR_Buy_textBox.Text = (currentValue * sterlinBuying / euroBuying).ToString();
                    CAD_Buy_textBox.Text = (currentValue * sterlinBuying / CADBuying).ToString();
                    AED_Buy_textBox.Text = (currentValue * sterlinBuying / aedBuying).ToString();
                    NOK_Buy_textBox.Text = (currentValue * sterlinBuying / nokBuying).ToString();
                    CHF_Buy_textBox.Text = (currentValue * sterlinBuying / chfBuying).ToString();
                    SEK_Buy_textBox.Text = (currentValue * sterlinBuying / sekBuying).ToString();
                    AZN_Buy_textBox.Text = (currentValue * sterlinBuying / aznBuying).ToString();
                }
                else
                {

                }
            }
            
            isUpdating = false;
        }

        private void CAD_Buy_textBox_TextChanged(object sender, EventArgs e)
        {
            if (isUpdating)
                return;

            isUpdating = true;
            if (string.IsNullOrWhiteSpace(CAD_Buy_textBox.Text))
            {

            }
            else
            {

                double limit;
                if (double.TryParse(CAD_Buy_textBox.Text, out limit))
                {
                    double currentValue = Convert.ToDouble(CAD_Buy_textBox.Text);

                    TRY_Buy_Textbox.Text = (currentValue * CADBuying).ToString();
                    USD_Buy_textBox.Text = (currentValue * CADBuying / dolarbuying).ToString();
                    EUR_Buy_textBox.Text = (currentValue * CADBuying / euroBuying).ToString();
                    GBP_Buy_textBox.Text = (currentValue * CADBuying / sterlinBuying).ToString();
                    AED_Buy_textBox.Text = (currentValue * CADBuying / aedBuying).ToString();
                    NOK_Buy_textBox.Text = (currentValue * CADBuying / nokBuying).ToString();
                    CHF_Buy_textBox.Text = (currentValue * CADBuying / chfBuying).ToString();
                    SEK_Buy_textBox.Text = (currentValue * CADBuying / sekBuying).ToString();
                    AZN_Buy_textBox.Text = (currentValue * CADBuying / aznBuying).ToString();
                }
                else
                {

                }
            }
            
            isUpdating = false;
        }

        private void AZN_Buy_textBox_TextChanged(object sender, EventArgs e)
        {
            if (isUpdating)
                return;

            isUpdating = true;
            if (string.IsNullOrWhiteSpace(AZN_Buy_textBox.Text))
            {

            }
            else
            {

                double limit;
                if (double.TryParse(AZN_Buy_textBox.Text, out limit))
                {
                    double currentValue = Convert.ToDouble(AZN_Buy_textBox.Text);

                    TRY_Buy_Textbox.Text = (currentValue * aznBuying).ToString();
                    USD_Buy_textBox.Text = (currentValue * aznBuying / dolarbuying).ToString();
                    EUR_Buy_textBox.Text = (currentValue * aznBuying / euroBuying).ToString();
                    GBP_Buy_textBox.Text = (currentValue * aznBuying / sterlinBuying).ToString();
                    CAD_Buy_textBox.Text = (currentValue * aznBuying / CADBuying).ToString();
                    AED_Buy_textBox.Text = (currentValue * aznBuying / aedBuying).ToString();
                    NOK_Buy_textBox.Text = (currentValue * aznBuying / nokBuying).ToString();
                    CHF_Buy_textBox.Text = (currentValue * aznBuying / chfBuying).ToString();
                    SEK_Buy_textBox.Text = (currentValue * aznBuying / sekBuying).ToString();
                }
                else
                {

                }
            }
            
            isUpdating = false;
        }

        private void AED_Buy_textBox_TextChanged(object sender, EventArgs e)
        {
            if (isUpdating)
                return;

            isUpdating = true;
            if (string.IsNullOrWhiteSpace(AED_Buy_textBox.Text))
            {

            }
            else
            {

                double limit;
                if (double.TryParse(AED_Buy_textBox.Text, out limit))
                {
                    double currentValue = Convert.ToDouble(AED_Buy_textBox.Text);

                    TRY_Buy_Textbox.Text = (currentValue * aedBuying).ToString();
                    USD_Buy_textBox.Text = (currentValue * aedBuying / dolarbuying).ToString();
                    EUR_Buy_textBox.Text = (currentValue * aedBuying / euroBuying).ToString();
                    GBP_Buy_textBox.Text = (currentValue * aedBuying / sterlinBuying).ToString();
                    CAD_Buy_textBox.Text = (currentValue * aedBuying / CADBuying).ToString();
                    NOK_Buy_textBox.Text = (currentValue * aedBuying / nokBuying).ToString();
                    CHF_Buy_textBox.Text = (currentValue * aedBuying / chfBuying).ToString();
                    SEK_Buy_textBox.Text = (currentValue * aedBuying / sekBuying).ToString();
                    AZN_Buy_textBox.Text = (currentValue * aedBuying / aznBuying).ToString();
                }
                else
                {

                }
            }
            
            isUpdating = false;
        }

        private void NOK_Buy_textBox_TextChanged(object sender, EventArgs e)
        {
            if (isUpdating)
                return;

            isUpdating = true;
            if (string.IsNullOrWhiteSpace(NOK_Buy_textBox.Text))
            {

            }
            else
            {

                double limit;
                if (double.TryParse(NOK_Buy_textBox.Text, out limit))
                {
                    double currentValue = Convert.ToDouble(NOK_Buy_textBox.Text);

                    TRY_Buy_Textbox.Text = (currentValue * nokBuying).ToString();
                    USD_Buy_textBox.Text = (currentValue * nokBuying / dolarbuying).ToString();
                    EUR_Buy_textBox.Text = (currentValue * nokBuying / euroBuying).ToString();
                    GBP_Buy_textBox.Text = (currentValue * nokBuying / sterlinBuying).ToString();
                    CAD_Buy_textBox.Text = (currentValue * nokBuying / CADBuying).ToString();
                    AED_Buy_textBox.Text = (currentValue * nokBuying / aedBuying).ToString();
                    CHF_Buy_textBox.Text = (currentValue * nokBuying / chfBuying).ToString();
                    SEK_Buy_textBox.Text = (currentValue * nokBuying / sekBuying).ToString();
                    AZN_Buy_textBox.Text = (currentValue * nokBuying / aznBuying).ToString();
                }
                else
                {

                }
            }
            
            isUpdating = false;
        }

        private void CHF_Buy_textBox_TextChanged(object sender, EventArgs e)
        {
            if (isUpdating)
                return;

            isUpdating = true;
            if (string.IsNullOrWhiteSpace(CHF_Buy_textBox.Text))
            {

            }
            else
            {

                double limit;
                if (double.TryParse(CHF_Buy_textBox.Text, out limit))
                {
                    double currentValue = Convert.ToDouble(CHF_Buy_textBox.Text);

                    TRY_Buy_Textbox.Text = (currentValue * chfBuying).ToString();
                    USD_Buy_textBox.Text = (currentValue * chfBuying / dolarbuying).ToString();
                    EUR_Buy_textBox.Text = (currentValue * chfBuying / euroBuying).ToString();
                    GBP_Buy_textBox.Text = (currentValue * chfBuying / sterlinBuying).ToString();
                    CAD_Buy_textBox.Text = (currentValue * chfBuying / CADBuying).ToString();
                    AED_Buy_textBox.Text = (currentValue * chfBuying / aedBuying).ToString();
                    NOK_Buy_textBox.Text = (currentValue * chfBuying / nokBuying).ToString();
                    SEK_Buy_textBox.Text = (currentValue * chfBuying / sekBuying).ToString();
                    AZN_Buy_textBox.Text = (currentValue * chfBuying / aznBuying).ToString();
                }
                else
                {

                }
            }
            
            isUpdating = false;
        }

        private void SEK_Buy_textBox_TextChanged(object sender, EventArgs e)
        {
            if (isUpdating)
                return;

            isUpdating = true;
            if (string.IsNullOrWhiteSpace(SEK_Buy_textBox.Text))
            {

            }
            else
            {

                double limit;
                if (double.TryParse(SEK_Buy_textBox.Text, out limit))
                {
                    double currentValue = Convert.ToDouble(SEK_Buy_textBox.Text);

                    TRY_Buy_Textbox.Text = (currentValue * sekBuying).ToString();
                    USD_Buy_textBox.Text = (currentValue * sekBuying / dolarbuying).ToString();
                    EUR_Buy_textBox.Text = (currentValue * sekBuying / euroBuying).ToString();
                    GBP_Buy_textBox.Text = (currentValue * sekBuying / sterlinBuying).ToString();
                    CAD_Buy_textBox.Text = (currentValue * sekBuying / CADBuying).ToString();
                    AED_Buy_textBox.Text = (currentValue * sekBuying / aedBuying).ToString();
                    NOK_Buy_textBox.Text = (currentValue * sekBuying / nokBuying).ToString();
                    CHF_Buy_textBox.Text = (currentValue * sekBuying / chfBuying).ToString();
                    AZN_Buy_textBox.Text = (currentValue * sekBuying / aznBuying).ToString();
                }
                else
                {

                }
            }
            isUpdating = false;
        }

        private void TRY_Sell_TextBox_TextChanged(object sender, EventArgs e)
        {
            if (isUpdating)
                return;

            isUpdating = true;
            if (string.IsNullOrWhiteSpace(TRY_Sell_TextBox.Text))
            {

            }
            else
            {

                double limit;
                if (double.TryParse(TRY_Sell_TextBox.Text, out limit))
                {
                    double currentValue = Convert.ToDouble(TRY_Sell_TextBox.Text);

                    USD_Sell_textBox.Text = (currentValue / dolarselling).ToString();
                    EUR_Sell_textBox.Text = (currentValue / euroSelling).ToString();
                    GBP_Sell_textBox.Text = (currentValue / sterlinSelling).ToString();
                    CAD_Sell_textBox.Text = (currentValue / CADSelling).ToString();
                    AED_Sell_textBox.Text = (currentValue / aedSelling).ToString();
                    NOK_Sell_textBox.Text = (currentValue / nokSelling).ToString();
                    CHF_Sell_textBox.Text = (currentValue / chfSelling).ToString();
                    SEK_Sell_textBox.Text = (currentValue / sekSelling).ToString();
                    AZN_Sell_textBox.Text = (currentValue / sekSelling).ToString();
                }
                else
                {

                }
            }

            isUpdating = false;
        }

        private void USD_Sell_textBox_TextChanged(object sender, EventArgs e)
        {
            if (isUpdating)
                return;

            isUpdating = true;
            if (string.IsNullOrWhiteSpace(USD_Sell_textBox.Text))
            {

            }
            else
            {

                double limit;
                if (double.TryParse(USD_Sell_textBox.Text, out limit))
                {
                    double currentValue = Convert.ToDouble(USD_Sell_textBox.Text);

                    TRY_Sell_TextBox.Text = (currentValue * dolarselling).ToString();
                    EUR_Sell_textBox.Text = (currentValue * dolarselling / euroSelling).ToString();
                    GBP_Sell_textBox.Text = (currentValue * dolarselling / sterlinSelling).ToString();
                    CAD_Sell_textBox.Text = (currentValue * dolarselling / CADSelling).ToString();
                    AED_Sell_textBox.Text = (currentValue * dolarselling / aedSelling).ToString();
                    NOK_Sell_textBox.Text = (currentValue * dolarselling / nokSelling).ToString();
                    CHF_Sell_textBox.Text = (currentValue * dolarselling / chfSelling).ToString();
                    SEK_Sell_textBox.Text = (currentValue * dolarselling / sekSelling).ToString();
                    AZN_Sell_textBox.Text = (currentValue * dolarselling / sekSelling).ToString();
                }
                else
                {

                }
            }

            isUpdating = false;
        }

        private void EUR_Sell_textBox_TextChanged(object sender, EventArgs e)
        {
            if (isUpdating)
                return;

            isUpdating = true;
            if (string.IsNullOrWhiteSpace(USD_Sell_textBox.Text))
            {

            }
            else
            {

                double limit;
                if (double.TryParse(USD_Sell_textBox.Text, out limit))
                {
                    double currentValue = Convert.ToDouble(EUR_Sell_textBox.Text);

                    TRY_Sell_TextBox.Text = (currentValue * euroSelling).ToString();
                    USD_Sell_textBox.Text = (currentValue * euroSelling / dolarselling).ToString();
                    GBP_Sell_textBox.Text = (currentValue * euroSelling / sterlinSelling).ToString();
                    CAD_Sell_textBox.Text = (currentValue * euroSelling / CADSelling).ToString();
                    AED_Sell_textBox.Text = (currentValue * euroSelling / aedSelling).ToString();
                    NOK_Sell_textBox.Text = (currentValue * euroSelling / nokSelling).ToString();
                    CHF_Sell_textBox.Text = (currentValue * euroSelling / chfSelling).ToString();
                    SEK_Sell_textBox.Text = (currentValue * euroSelling / sekSelling).ToString();
                    AZN_Sell_textBox.Text = (currentValue * euroSelling / aznSelling).ToString();
                }
                else
                {

                }
            }

            isUpdating = false;
        }

        private void GBP_Sell_textBox_TextChanged(object sender, EventArgs e)
        {
            if (isUpdating)
                return;

            isUpdating = true;
            if (string.IsNullOrWhiteSpace(USD_Sell_textBox.Text))
            {

            }
            else
            {

                double limit;
                if (double.TryParse(USD_Sell_textBox.Text, out limit))
                {
                    double currentValue = Convert.ToDouble(GBP_Sell_textBox.Text);

                    TRY_Sell_TextBox.Text = (currentValue * sterlinSelling).ToString();
                    USD_Sell_textBox.Text = (currentValue * sterlinSelling / dolarselling).ToString();
                    EUR_Sell_textBox.Text = (currentValue * sterlinSelling / euroSelling).ToString();
                    CAD_Sell_textBox.Text = (currentValue * sterlinSelling / CADSelling).ToString();
                    AED_Sell_textBox.Text = (currentValue * sterlinSelling / aedSelling).ToString();
                    NOK_Sell_textBox.Text = (currentValue * sterlinSelling / nokSelling).ToString();
                    CHF_Sell_textBox.Text = (currentValue * sterlinSelling / chfSelling).ToString();
                    SEK_Sell_textBox.Text = (currentValue * sterlinSelling / sekSelling).ToString();
                    AZN_Sell_textBox.Text = (currentValue * sterlinSelling / aznSelling).ToString();
                }
                else
                {

                }
            }

            isUpdating = false;
        }

        private void CAD_Sell_textBox_TextChanged(object sender, EventArgs e)
        {
            if (isUpdating)
                return;

            isUpdating = true;
            if (string.IsNullOrWhiteSpace(USD_Sell_textBox.Text))
            {

            }
            else
            {

                double limit;
                if (double.TryParse(USD_Sell_textBox.Text, out limit))
                {
                    double currentValue = Convert.ToDouble(CAD_Sell_textBox.Text);

                    TRY_Sell_TextBox.Text = (currentValue * CADSelling).ToString();
                    USD_Sell_textBox.Text = (currentValue * CADSelling / dolarselling).ToString();
                    EUR_Sell_textBox.Text = (currentValue * CADSelling / euroSelling).ToString();
                    GBP_Sell_textBox.Text = (currentValue * CADSelling / sterlinSelling).ToString();
                    AED_Sell_textBox.Text = (currentValue * CADSelling / aedSelling).ToString();
                    NOK_Sell_textBox.Text = (currentValue * CADSelling / nokSelling).ToString();
                    CHF_Sell_textBox.Text = (currentValue * CADSelling / chfSelling).ToString();
                    SEK_Sell_textBox.Text = (currentValue * CADSelling / sekSelling).ToString();
                    AZN_Sell_textBox.Text = (currentValue * CADSelling / aznSelling).ToString();
                }
                else
                {

                }
            }

            isUpdating = false;
        }

        private void AZN_Sell_textBox_TextChanged(object sender, EventArgs e)
        {
            if (isUpdating)
                return;

            isUpdating = true;
            if (string.IsNullOrWhiteSpace(USD_Sell_textBox.Text))
            {

            }
            else
            {

                double limit;
                if (double.TryParse(USD_Sell_textBox.Text, out limit))
                {
                    double currentValue = Convert.ToDouble(AZN_Sell_textBox.Text);

                    TRY_Sell_TextBox.Text = (currentValue * aznSelling).ToString();
                    USD_Sell_textBox.Text = (currentValue * aznSelling / dolarselling).ToString();
                    EUR_Sell_textBox.Text = (currentValue * aznSelling / euroSelling).ToString();
                    GBP_Sell_textBox.Text = (currentValue * aznSelling / sterlinSelling).ToString();
                    CAD_Sell_textBox.Text = (currentValue * aznSelling / CADSelling).ToString();
                    AED_Sell_textBox.Text = (currentValue * aznSelling / aedSelling).ToString();
                    NOK_Sell_textBox.Text = (currentValue * aznSelling / nokSelling).ToString();
                    CHF_Sell_textBox.Text = (currentValue * aznSelling / chfSelling).ToString();
                    SEK_Sell_textBox.Text = (currentValue * aznSelling / sekSelling).ToString();
                }
                else
                {

                }
            }

            isUpdating = false;
        }

        private void AED_Sell_textBox_TextChanged(object sender, EventArgs e)
        {
            if (isUpdating)
                return;

            isUpdating = true;
            if (string.IsNullOrWhiteSpace(USD_Sell_textBox.Text))
            {

            }
            else
            {

                double limit;
                if (double.TryParse(USD_Sell_textBox.Text, out limit))
                {
                    double currentValue = Convert.ToDouble(AED_Sell_textBox.Text);

                    TRY_Sell_TextBox.Text = (currentValue * aedSelling).ToString();
                    USD_Sell_textBox.Text = (currentValue * aedSelling / dolarselling).ToString();
                    EUR_Sell_textBox.Text = (currentValue * aedSelling / euroSelling).ToString();
                    GBP_Sell_textBox.Text = (currentValue * aedSelling / sterlinSelling).ToString();
                    CAD_Sell_textBox.Text = (currentValue * aedSelling / CADSelling).ToString();
                    AZN_Sell_textBox.Text = (currentValue * aedSelling / aznSelling).ToString();
                    NOK_Sell_textBox.Text = (currentValue * aedSelling / nokSelling).ToString();
                    CHF_Sell_textBox.Text = (currentValue * aedSelling / chfSelling).ToString();
                    SEK_Sell_textBox.Text = (currentValue * aedSelling / sekSelling).ToString();
                }
                else
                {

                }
            }

            isUpdating = false;
        }

        private void NOK_Sell_textBox_TextChanged(object sender, EventArgs e)
        {
            if (isUpdating)
                return;

            isUpdating = true;
            if (string.IsNullOrWhiteSpace(USD_Sell_textBox.Text))
            {

            }
            else
            {

                double limit;
                if (double.TryParse(USD_Sell_textBox.Text, out limit))
                {
                    double currentValue = Convert.ToDouble(NOK_Sell_textBox.Text);

                    TRY_Sell_TextBox.Text = (currentValue * nokSelling).ToString();
                    USD_Sell_textBox.Text = (currentValue * nokSelling / dolarselling).ToString();
                    EUR_Sell_textBox.Text = (currentValue * nokSelling / euroSelling).ToString();
                    GBP_Sell_textBox.Text = (currentValue * nokSelling / sterlinSelling).ToString();
                    CAD_Sell_textBox.Text = (currentValue * nokSelling / CADSelling).ToString();
                    AED_Sell_textBox.Text = (currentValue * nokSelling / aedSelling).ToString();
                    CHF_Sell_textBox.Text = (currentValue * nokSelling / chfSelling).ToString();
                    SEK_Sell_textBox.Text = (currentValue * nokSelling / sekSelling).ToString();
                    AZN_Sell_textBox.Text = (currentValue * nokSelling / aznSelling).ToString();
                }
                else
                {

                }
            }

            isUpdating = false;
        }

        private void CHF_Sell_textBox_TextChanged(object sender, EventArgs e)
        {
            if (isUpdating)
                return;

            isUpdating = true;
            if (string.IsNullOrWhiteSpace(USD_Sell_textBox.Text))
            {

            }
            else
            {

                double limit;
                if (double.TryParse(USD_Sell_textBox.Text, out limit))
                {
                    double currentValue = Convert.ToDouble(CHF_Sell_textBox.Text);

                    TRY_Sell_TextBox.Text = (currentValue * chfSelling).ToString();
                    USD_Sell_textBox.Text = (currentValue * chfSelling / dolarselling).ToString();
                    EUR_Sell_textBox.Text = (currentValue * chfSelling / euroSelling).ToString();
                    GBP_Sell_textBox.Text = (currentValue * chfSelling / sterlinSelling).ToString();
                    CAD_Sell_textBox.Text = (currentValue * chfSelling / CADSelling).ToString();
                    AED_Sell_textBox.Text = (currentValue * chfSelling / aedSelling).ToString();
                    NOK_Sell_textBox.Text = (currentValue * chfSelling / nokSelling).ToString();
                    SEK_Sell_textBox.Text = (currentValue * chfSelling / sekSelling).ToString();
                    AZN_Sell_textBox.Text = (currentValue * chfSelling / aznSelling).ToString();
                }
                else
                {

                }
            }

            isUpdating = false;
        }

        private void SEK_Sell_textBox_TextChanged(object sender, EventArgs e)
        {
            if (isUpdating)
                return;

            isUpdating = true;
            if (string.IsNullOrWhiteSpace(USD_Sell_textBox.Text))
            {

            }
            else
            {

                double limit;
                if (double.TryParse(USD_Sell_textBox.Text, out limit))
                {
                    double currentValue = Convert.ToDouble(SEK_Sell_textBox.Text);

                    TRY_Sell_TextBox.Text = (currentValue * sekSelling).ToString();
                    USD_Sell_textBox.Text = (currentValue * sekSelling / dolarselling).ToString();
                    EUR_Sell_textBox.Text = (currentValue * sekSelling / euroSelling).ToString();
                    GBP_Sell_textBox.Text = (currentValue * sekSelling / sterlinSelling).ToString();
                    CAD_Sell_textBox.Text = (currentValue * sekSelling / CADSelling).ToString();
                    AED_Sell_textBox.Text = (currentValue * sekSelling / aedSelling).ToString();
                    NOK_Sell_textBox.Text = (currentValue * sekSelling / nokSelling).ToString();
                    CHF_Sell_textBox.Text = (currentValue * sekSelling / chfSelling).ToString();
                    AZN_Sell_textBox.Text = (currentValue * sekSelling / aznSelling).ToString();
                }
                else
                {

                }
            }

            isUpdating = false;
        }
    }
}
