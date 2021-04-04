using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarTravel
{
    public partial class CarTravel : Form
    {
        double euro=90;
        double dollar=75;
        double deliver = 0;
        double recyclingFee = 400;
        double pfl = 500;//pensioner
        double sbktsRF = 871;//??????????????????????????????????????????????
        double roma = 1400;
        double registrationCost = 50;

        public class Car
        {
            public int Age { get; set; }
            public double EngineCapacity { get; set; }
            public double CarCost { get; set; }
            public Car(int age, double engineCapacity, double carCost)
            {
                Age = age;
                EngineCapacity = engineCapacity;
                CarCost = carCost;
            }
        }
        public String CustomsPayment(Car car, double euro, double dollar)
        {
            double registrationCost = 0;
            double recyclingFee = 20000;
            double customDuties = 0;

            if (car.Age < 3)
            {
                recyclingFee *= 0.17;
                if (car.CarCost > 169000)
                {
                    // customDuties calc block
                    registrationCost = 30000 / euro;
                    if (car.CarCost * 0.48 < 20 * car.EngineCapacity)
                    {
                        customDuties = 20 * car.EngineCapacity;
                    }
                    else
                    {
                        customDuties = car.CarCost * 0.48;
                    }
                }
                else if (car.CarCost > 84500)
                {
                    //registration cost calc block
                    registrationCost = 23000 / euro;
                    if (car.CarCost >= 111111)
                    {
                        registrationCost = 30000 / euro;//30k rub
                    }
                    else if (car.CarCost >= 100000)
                    {
                        registrationCost = 27000 / euro;//27k rub
                    }
                    else if (car.CarCost >= 88888)
                    {
                        registrationCost = 25000 / euro;//25
                    }
                    // custom duties calc block
                    if (car.CarCost * 0.48 < 15 * car.EngineCapacity)
                    {
                        customDuties = 15 * car.EngineCapacity;
                    }
                    else
                    {
                        customDuties = car.CarCost * 0.48;
                    }
                }
                else if (car.CarCost > 42300)
                {
                    //registration cost calc block
                    registrationCost = 12000 / euro;
                    if (car.CarCost >= 77777)
                    {
                        registrationCost = 23000 / euro;//23
                    }
                    else if (car.CarCost >= 61111)
                    {
                        registrationCost = 20000 / euro;//20
                    }
                    else if (car.CarCost >= 46666)
                    {
                        registrationCost = 15500 / euro;//15500
                    }
                    // custom duties calc block
                    if (car.CarCost * 0.48 < 7.5 * car.EngineCapacity)
                    {
                        customDuties = 7.5 * car.EngineCapacity;
                    }
                    else
                    {
                        customDuties = car.CarCost * 0.48;
                    }
                }
                else if (car.CarCost > 16700)
                {
                    //registration cost calc block
                    registrationCost = 8550 / euro;//8550
                    if (car.CarCost >= 30000)
                    {
                        registrationCost = 12000 / euro;//12
                    }
                    //custom duties calc block
                    if (car.CarCost * 0.48 < 5.5 * car.EngineCapacity)
                    {
                        customDuties = 5.5 * car.EngineCapacity;
                    }
                    else
                    {
                        customDuties = car.CarCost * 0.48;
                    }
                }
                else if (car.CarCost > 8500)
                {
                    //registration cost calc block
                    registrationCost = 3100 / euro;
                    if (car.CarCost >= 13333)
                    {
                        registrationCost = 8550 / euro;
                    }

                    if (car.CarCost * 0.48 < 3.5 * car.EngineCapacity)
                    {
                        customDuties = 3.5 * car.EngineCapacity;
                    }
                    else
                    {
                        customDuties = car.CarCost * 0.48;
                    }
                }
                else
                {
                    //registration cost calc block

                    if (car.CarCost > 5000)
                    {
                        registrationCost = 3100 / euro;
                    }
                    else if (car.CarCost > 2222)
                    {
                        registrationCost = 1550 / euro;
                    }
                    else { registrationCost = 775 / euro; }
                    ////

                    if (car.CarCost * 0.54 < 2.5 * car.EngineCapacity)
                    {
                        customDuties = 2.5 * car.EngineCapacity;
                    }
                    else
                    {
                        customDuties = car.CarCost * 0.54;
                    }
                }
            }

            else if (3 <= car.Age && car.Age <= 5)
            {
                //registration cost calc block
                if (car.CarCost >= 111111)
                {
                    registrationCost = 30000 / euro;//30k rub
                }
                else if (car.CarCost >= 100000)
                {
                    registrationCost = 27000 / euro;//27k rub
                }
                else if (car.CarCost >= 88888)
                {
                    registrationCost = 25000 / euro;//25
                }
                else if (car.CarCost >= 77777)
                {
                    registrationCost = 23000 / euro;//23
                }
                else if (car.CarCost >= 61111)
                {
                    registrationCost = 20000 / euro;//20
                }
                else if (car.CarCost >= 46666)
                {
                    registrationCost = 15500 / euro;//15500
                }
                else if (car.CarCost >= 30000)
                {
                    registrationCost = 12000 / euro;//12
                }
                else if (car.CarCost >= 13333)
                {
                    registrationCost = 8550 / euro;//8550
                }
                else if (car.CarCost > 5000)
                {
                    registrationCost = 3100 / euro;//3100
                }
                else if (car.CarCost > 2222)
                {
                    registrationCost = 1550 / euro;//1550
                }
                else { registrationCost = 775 / euro; }//775                                              
                                                       ////////
                recyclingFee *= 0.26;
                if (car.EngineCapacity > 3001)
                {
                    customDuties = car.EngineCapacity * 3.6;
                }
                else if (car.EngineCapacity > 2300)
                {
                    customDuties = car.EngineCapacity * 3;
                }
                else if (car.EngineCapacity > 1800)
                {
                    customDuties = car.EngineCapacity * 2.7;
                }
                else if (car.EngineCapacity > 1500)
                {
                    customDuties = car.EngineCapacity * 2.5;
                }
                else if (car.EngineCapacity > 1000)
                {
                    customDuties = car.EngineCapacity * 1.7;
                }
                else
                {
                    customDuties = car.EngineCapacity * 1.5;
                }
            }

            else if (car.Age > 5)
            {
                //registration cost calc block
                if (car.CarCost >= 111111)
                {
                    registrationCost = 30000 / euro;//30k rub
                }
                else if (car.CarCost >= 100000)
                {
                    registrationCost = 27000 / euro;//27k rub
                }
                else if (car.CarCost >= 88888)
                {
                    registrationCost = 25000 / euro;//25
                }
                else if (car.CarCost >= 77777)
                {
                    registrationCost = 23000 / euro;//23
                }
                else if (car.CarCost >= 61111)
                {
                    registrationCost = 20000 / euro;//20
                }
                else if (car.CarCost >= 46666)
                {
                    registrationCost = 15500 / euro;//15500
                }
                else if (car.CarCost >= 30000)
                {
                    registrationCost = 12000 / euro;//12
                }
                if (car.CarCost >= 13333)
                {
                    registrationCost = 8550 / euro;//8550
                }
                if (car.CarCost > 5000)
                {
                    registrationCost = 3100 / euro;
                }
                else if (car.CarCost > 2222)
                {
                    registrationCost = 1550 / euro;
                }
                else { registrationCost = 775 / euro; }
                /////////
                if (car.EngineCapacity > 3001)
                {
                    customDuties = car.EngineCapacity * 5.7;
                }
                else if (car.EngineCapacity > 2300)
                {
                    customDuties = car.EngineCapacity * 5;
                }
                else if (car.EngineCapacity > 1800)
                {
                    customDuties = car.EngineCapacity * 4.8;
                }
                else if (car.EngineCapacity > 1500)
                {
                    customDuties = car.EngineCapacity * 3.5;
                }
                else if (car.EngineCapacity > 1000)
                {
                    customDuties = car.EngineCapacity * 3.2;
                }
                else
                {
                    customDuties = car.EngineCapacity * 3;
                }
            }

            customDuties *= euro;
            registrationCost *= euro;
            return registrationCost.ToString() + "|" + recyclingFee.ToString() + "`" + customDuties.ToString() + "!" + (registrationCost + recyclingFee + customDuties).ToString();
        }
        public String AuctionerPayment(Car car)
        {
            double cost = car.CarCost;
            double auc, auc1, auc2;

            if (Copart.Checked)
            {
                if (cost < 100)
                {
                    auc1 = 1;
                }
                else if (cost >= 100 && cost < 200)
                {
                    auc1 = 25;
                }
                else if (cost >= 200 && cost < 300)
                {
                    auc1 = 50;
                }
                else if (cost >= 300 && cost < 400)
                {
                    auc1 = 75;
                }
                else if (cost >= 400 && cost < 500)
                {
                    auc1 = 110;
                }
                else if (cost >= 500 && cost < 550)
                {
                    auc1 = 125;
                }
                else if (cost >= 550 && cost < 600)
                {
                    auc1 = 130;
                }
                else if (cost >= 600 && cost < 700)
                {
                    auc1 = 140;
                }
                else if (cost >= 700 && cost < 800)
                {
                    auc1 = 155;
                }
                else if (cost >= 800 && cost < 900)
                {
                    auc1 = 170;
                }
                else if (cost >= 900 && cost < 1000)
                {
                    auc1 = 185;
                }
                else if (cost >= 1000 && cost < 1200)
                {
                    auc1 = 200;
                }
                else if (cost >= 1200 && cost < 1300)
                {
                    auc1 = 225;
                }
                else if (cost >= 1300 && cost < 1400)
                {
                    auc1 = 240;
                }
                else if (cost >= 1400 && cost < 1500)
                {
                    auc1 = 250;
                }
                else if (cost >= 1500 && cost < 1600)
                {
                    auc1 = 260;
                }
                else if (cost >= 1600 && cost < 1700)
                {
                    auc1 = 275;
                }
                else if (cost >= 1700 && cost < 1800)
                {
                    auc1 = 285;
                }
                else if (cost >= 1800 && cost < 2000)
                {
                    auc1 = 300;
                }
                else if (cost >= 2000 && cost < 2400)
                {
                    auc1 = 325;
                }
                else if (cost >= 2400 && cost < 2500)
                {
                    auc1 = 335;
                }
                else if (cost >= 2500 && cost < 3000)
                {
                    auc1 = 350;
                }
                else if (cost >= 3000 && cost < 3500)
                {
                    auc1 = 400;
                }
                else if (cost >= 3500 && cost < 4000)
                {
                    auc1 = 450;
                }
                else if (cost >= 4000 && cost < 4500)
                {
                    auc1 = 475;
                }
                else if (cost >= 4500 && cost < 5000)
                {
                    auc1 = 500;
                }
                else if (cost >= 5000 && cost < 6000)
                {
                    auc1 = 525;
                }
                else if (cost >= 6000 && cost < 7500)
                {
                    auc1 = 550;
                }
                else if (cost >= 7500 && cost < 10000)
                {
                    auc1 = 575;
                }
                else if (cost >= 10000 && cost < 15000)
                {
                    auc1 = 600;
                }
                else
                {
                    auc1 = cost / 25;
                }
                //Аукционный сбор таблица 2

                if (cost < 100)
                {
                    auc2 = 0;
                }
                else if (cost >= 100 && cost < 500)
                {
                    auc2 = 39;
                }
                else if (cost >= 500 && cost < 1000)
                {
                    auc2 = 49;
                }
                else if (cost >= 1000 && cost < 1500)
                {
                    auc2 = 69;
                }
                else if (cost >= 1500 && cost < 2000)
                {
                    auc2 = 79;
                }
                else if (cost >= 2000 && cost < 4000)
                {
                    auc2 = 89;
                }
                else if (cost >= 4000 && cost < 6000)
                {
                    auc2 = 99;
                }
                else if (cost >= 6000 && cost < 8000)
                {
                    auc2 = 119;
                }
                else
                {
                    auc2 = 129;
                }
            }
            else// If Iaai.Checked
            {
                if (cost < 100)
                {
                    auc1 = 1;
                }
                else if (cost >= 100 && cost < 200)
                {
                    auc1 = 40;
                }
                else if (cost >= 200 && cost < 300)
                {
                    auc1 = 60;
                }
                else if (cost >= 300 && cost < 350)
                {
                    auc1 = 75;
                }
                else if (cost >= 350 && cost < 400)
                {
                    auc1 = 90;
                }
                else if (cost >= 400 && cost < 500)
                {
                    auc1 = 100;
                }
                else if (cost >= 500 && cost < 600)
                {
                    auc1 = 130;
                }
                else if (cost >= 600 && cost < 700)
                {
                    auc1 = 145;
                }
                else if (cost >= 700 && cost < 800)
                {
                    auc1 = 160;
                }
                else if (cost >= 800 && cost < 900)
                {
                    auc1 = 175;
                }
                else if (cost >= 900 && cost < 1000)
                {
                    auc1 = 190;
                }
                else if (cost >= 1000 && cost < 1100)
                {
                    auc1 = 205;
                }
                else if (cost >= 1100 && cost < 1200)
                {
                    auc1 = 220;
                }
                else if (cost >= 1200 && cost < 1300)
                {
                    auc1 = 230;
                }
                else if (cost >= 1300 && cost < 1400)
                {
                    auc1 = 240;
                }
                else if (cost >= 1400 && cost < 1500)
                {
                    auc1 = 255;
                }
                else if (cost >= 1500 && cost < 1600)
                {
                    auc1 = 270;
                }
                else if (cost >= 1600 && cost < 1700)
                {
                    auc1 = 290;
                }
                else if (cost >= 1700 && cost < 1800)
                {
                    auc1 = 300;
                }
                else if (cost >= 1800 && cost < 2000)
                {
                    auc1 = 310;
                }
                else if (cost >= 2000 && cost < 2200)
                {
                    auc1 = 325;
                }
                else if (cost >= 2200 && cost < 2400)
                {
                    auc1 = 330;
                }
                else if (cost >= 2400 && cost < 2500)
                {
                    auc1 = 345;
                }
                else if (cost >= 2500 && cost < 3000)
                {
                    auc1 = 360;
                }
                else if (cost >= 3000 && cost < 3500)
                {
                    auc1 = 400;
                }
                else if (cost >= 3500 && cost < 4000)
                {
                    auc1 = 450;
                }
                else if (cost >= 4000 && cost < 4500)
                {
                    auc1 = 475;
                }
                else if (cost >= 4500 && cost < 5000)
                {
                    auc1 = 500;
                }
                else if (cost >= 5000 && cost < 6000)
                {
                    auc1 = 525;
                }
                else if (cost >= 6000 && cost < 7500)
                {
                    auc1 = 550;
                }
                else if (cost >= 7500 && cost < 20000)
                {
                    auc1 = 500 + (cost / 100);
                }
                else
                {
                    auc1 = cost / 25;
                }
                //Аукционный сбор таблица 2

                if (cost < 100)
                {
                    auc2 = 0;
                }
                else if (cost >= 100 && cost < 500)
                {
                    auc2 = 29;
                }
                else if (cost >= 500 && cost < 1000)
                {
                    auc2 = 39;
                }
                else if (cost >= 1000 && cost < 1500)
                {
                    auc2 = 59;
                }
                else if (cost >= 1500 && cost < 2000)
                {
                    auc2 = 69;
                }
                else if (cost >= 2000 && cost < 4000)
                {
                    auc2 = 79;
                }
                else if (cost >= 4000 && cost < 6000)
                {
                    auc2 = 89;
                }
                else if (cost >= 6000 && cost < 8000)
                {
                    auc2 = 99;
                }
                else
                {
                    auc2 = 119;
                }
            }
            //ТОЧНАЯ ЦЕНА АВТО ДЛЯ ТАМОЖНИ

            auc = auc1 + auc2 + 109; //Комиссия аукциона


            return auc.ToString();
        }

        public CarTravel()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            //ВСЁ В ЕВРО!
            double releaseYear = Convert.ToDouble(textBox1.Text);
            double engineCapacity = Convert.ToDouble(textBox3.Text);
            double carCost = Convert.ToDouble(textBox2.Text);
            int age = Convert.ToInt32(DateTime.Now.Year - releaseYear);
            Car car = new Car(age, engineCapacity, carCost * dollar / euro);

            string auctioneerPayment = AuctionerPayment(car);
            string customsPayment = CustomsPayment(car, euro, dollar);
            string customsPaymentSave = customsPayment;

            carCostRub.Text = carCost * dollar+ " rub";
            carCostDol.Text = carCost + " $";

            auctioneerPaymentDol.Text = auctioneerPayment + " $";
            auctioneerPaymentRub.Text = Convert.ToDouble(auctioneerPayment) * dollar + " rub";
            {///Russian Customs Output
                deliverCostRusRub.Text = deliver.ToString() + " $";
                deliverCostRusDol.Text = (deliver * dollar).ToString() + " rub";

                string temp = customsPayment.Substring(0, customsPayment.IndexOf("|"));
                registrationCostRub.Text = temp + " rub";
                registrationcostDol.Text = Convert.ToDouble(temp) / dollar + " $";
                customsPayment = customsPayment.Remove(0, customsPayment.IndexOf("|") + 1);

                temp = customsPayment.Substring(0, customsPayment.IndexOf("`"));
                recyclingFeeRub.Text = temp + " rub";
                recyclingFeeDol.Text = Convert.ToDouble(temp) / dollar + " $";
                customsPayment = customsPayment.Remove(0, customsPayment.IndexOf("`") + 1);

                temp = customsPayment.Substring(0, customsPayment.IndexOf("!"));
                customDutiesRub.Text = temp + " rub";
                customDutiesDol.Text = Convert.ToDouble(temp) / dollar + " $";
                customsPayment = customsPayment.Remove(0, customsPayment.IndexOf("!") + 1);

                temp = customsPayment.Substring(0, customsPayment.Length);
                RusResultRub.Text = Convert.ToDouble(temp)+(1000+Convert.ToDouble(auctioneerPayment)+carCost)*dollar + " rub";
                RusResultol.Text = Convert.ToDouble(temp) / dollar + carCost + 1000 + Convert.ToDouble(auctioneerPayment) + " $";////||||||\\\\
            }
            {///Belorussian Customs Output
                double pfl = 500;//pensioner
                double sbktsRf = 871;//??????????????????????????????????????????????
                double roma = 1400;
                double registrationCost = 50;
                customsPayment = customsPaymentSave;

                deliverCostRub.Text = (deliver * dollar).ToString() + " rub"; 
                deliverCostDol.Text = deliver.ToString() + " $";

                registrationCostBelDol.Text = registrationCost.ToString() + " $";
                registrationCostBelRub.Text = (registrationCost * dollar).ToString() + " rub";

                recyclingFeeBelRub.Text = (recyclingFee * dollar).ToString() + " rub";
                recyclingFeeBelDol.Text = recyclingFee.ToString() + " $";

                pflBelDol.Text = pfl.ToString() + " $";
                pflBelRub.Text = (pfl * dollar).ToString() + " rub";

                sbktsRfBelDol.Text = sbktsRf.ToString() + " $";
                sbktsRfBelRub.Text = (sbktsRf * dollar).ToString() + " rub";

                romaBelDol.Text = roma.ToString() + " $";
                romaBelRub.Text = (roma * dollar).ToString() + " rub";

                customsPayment = customsPayment.Remove(0, customsPayment.IndexOf("`") + 1);
                customsPayment = customsPayment.Substring(0, customsPayment.IndexOf("!"));
                customsPayment = (Convert.ToDouble(customsPayment)/2).ToString();
                customsPaymentBelRub.Text = customsPayment + " rub";
                customsPaymentBelDol.Text = (Convert.ToDouble(customsPayment) / dollar).ToString() + "  $";

                ResultBelRub.Text = ((Convert.ToDouble(customsPayment)/dollar + pfl + sbktsRf + deliver + recyclingFee  + roma + registrationCost+Convert.ToDouble(auctioneerPayment)+carCost)*dollar).ToString()+" rub";
                ResultBelDol.Text = (Convert.ToDouble(customsPayment)/dollar + pfl + sbktsRf+ deliver + recyclingFee + roma + registrationCost + Convert.ToDouble(auctioneerPayment)+carCost).ToString()+" $";
            }

        }
        private void CarTravel_Load(object sender, EventArgs e) { }
        private void Result_Click(object sender, EventArgs e)
        {
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            if (domainUpDown1.SelectedIndex==0)
            {
                label15.Text = 1000.ToString() + " $";
                deliver = 1000;//??????????
            }
            else if (domainUpDown1.SelectedIndex==1)
            {
                label15.Text = 1175.ToString()+" $";
                deliver = 1175+300+40+50+50;//deliver to clayped + deliver from cayped + port + lafet + declarant payment
            }
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            euro = Convert.ToDouble(textBox4.Text);
        }
        private void textBox5_Enter(object sender, EventArgs e)
        {
            dollar = Convert.ToDouble(textBox5.Text);
        }
    }
}
