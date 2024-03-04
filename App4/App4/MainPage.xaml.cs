using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App4
{
    public partial class MainPage : ContentPage
    {

        public double addOns = 0;
        public double dCharge = 0;
        public double sCharge = 0;
        public double charge = 0;
        public MainPage()
        {
            InitializeComponent();
            option1.CheckedChanged += RadioButton_CheckedChanged;
            option2.CheckedChanged += RadioButton_CheckedChanged;
            option3.CheckedChanged += RadioButton_CheckedChanged;
            option4.CheckedChanged += RadioButton_CheckedChanged;
            option5.CheckedChanged += RadioButton_CheckedChanged;
            option6.CheckedChanged += RadioButton_CheckedChanged;

            
        }

        private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            RadioButton selectedRadioButton = (RadioButton)sender;

            

            if (e.Value)
            {
                string selectedValue = selectedRadioButton.Content.ToString();

                if (selectedValue == "Less than 72")
                {
                    charge = 2.50;
                }
                else if (selectedValue == "Less than or equal to 150")
                {
                    charge = 3.50;
                }
                else if (selectedValue == "Less than or equal to 300")
                {
                    charge = 4.50;
                }

                else if (selectedValue == "Less than or equal to 400")
                {
                    charge = 5.50;
                }

                else if (selectedValue == "Less than or equal to 500")
                {
                    charge = 6.00;
                }

                else
                {
                    charge = 6.50;
                }

                
            }
        }
        
            private void Button_Clicked_1(object sender, EventArgs e)
        {
            // VARIABLE
             

            
            if (check1.IsChecked)
            {
                addOns = 2500;
                dCharge = 20;
                sCharge = 5;
            }
            if (check2.IsChecked)
            {
                addOns = 0;
                dCharge = 40;
                sCharge = 10;
            }



            // PRINT VALUES

            add.Text = addOns.ToString();
            double conValue = double.Parse(consumption.Text);
            double eCharge = conValue * charge;
            double pAmount = eCharge + sCharge + addOns;
            double Vat = pAmount * 0.05;
            double aPayable = pAmount + Vat;


            chargeValue.Text = charge.ToString();
            vat.Text = Vat.ToString();
            amountpayable.Text = aPayable.ToString();
            principal.Text = pAmount.ToString();
        }


    }
}
