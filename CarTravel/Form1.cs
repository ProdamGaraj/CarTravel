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
        public String CustomsPayment(Car car)
        {
            double euro = 90;
            double dollar = 75;
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
                    registrationCost = 12000/euro;
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
            return registrationCost.ToString()+ "|" + recyclingFee.ToString() + "`" + customDuties.ToString() + "!" + (registrationCost + recyclingFee + customDuties).ToString();
        }


        public CarTravel()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            //ВСЁ В ЕВРО!
            double releaseYear = Convert.ToDouble(textBox1.Text);
            double engineCapacity = Convert.ToDouble(textBox2.Text);
            double carCost = Convert.ToDouble(textBox3.Text) ;
            int age = Convert.ToInt32(DateTime.Now.Year-releaseYear);
            Car car = new Car(age, carCost, engineCapacity);
            string output = CustomsPayment(car);
            Result.Text = output.Substring(0,output.IndexOf("|"));
            output=output.Remove(0, output.IndexOf("|")+1);
            label5.Text = output.Substring(0,output.IndexOf("`"));
            output=output.Remove(0, output.IndexOf("`")+1);
            label6.Text = output.Substring(0,output.IndexOf("!"));
            output=output.Remove(0, output.IndexOf("!")+1);
            label7.Text = output.Substring(0,output.Length);

        }
        private void CarTravel_Load(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Result_Click(object sender, EventArgs e)
        {
        }
    }
}
