using Microsoft.SqlServer.Management.Sdk.Sfc;
using System;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;

using System.Xml;

namespace CarTravel
{
    public partial class CarTravel : Form
    {
        DateTime releaseDate;
        string auctionName = "copart";
        double fixPrice = 0;
        double carCost = 0;
        double euroValue = 90;
        double usdValue = 75;
        double deliver = 0;
        double recyclingFee = 400;
        double pfl = 500;//pensioner
        double sbktsRF = 871;//глонас
        double roma = 1400;
        double registrationCost = 50;
        double engineCapacity = 0;
        double priceCorrection=0;

        public class Car
        {
            public double Age { get; set; }
            public double EngineCapacity { get; set; }
            public double CarCost { get; set; }
            public Car(double age, double engineCapacity, double carCost)
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
                else if (car.CarCost >= 5000)
                {
                    registrationCost = 3100 / euro;//3100
                }
                else if (car.CarCost >= 2222)
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

            return Math.Round(registrationCost).ToString() + "|" + Math.Round(recyclingFee).ToString() + "`" + Math.Round(customDuties).ToString() + "!" + Math.Round(registrationCost + recyclingFee + customDuties).ToString();
        }
        public String AuctionerPayment(Car car, string auctionName)
        {
            double cost = car.CarCost;
            double auc = 0, auc1 = 0, auc2 = 0;

            if (auctionName.ToLower().Equals("copart"))
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
            else if (auctionName.ToLower().Equals("iaai"))// If Iaai.Checked
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


            return Math.Round(auc, 2).ToString();
        }

        public String AddPointerSpace(string inpt)
        {
            string reversedResult = "";
            int dotId = inpt.IndexOf(",");
            if (dotId == -1) { dotId = inpt.IndexOf("."); }
            if (dotId == -1)
            {
                inpt = new string(inpt.ToCharArray().Reverse().ToArray());
                for (int i = inpt.Length - 1; i >= 0; i--)
                {
                    reversedResult += inpt[i];
                    if (i % 3 == 0)
                    {
                        reversedResult += " ";
                    }
                }
                return reversedResult;
            }
            else
            {
                string tail = "";
                for (int i = inpt.Length - 1; i >= dotId; i--)
                {
                    tail += inpt[i];
                }
                inpt = inpt.Substring(0, dotId);
                inpt = new string(inpt.ToCharArray().Reverse().ToArray());
                for (int i = inpt.Length - 1; i >= 0; i--)
                {
                    reversedResult += inpt[i];
                    if (i % 3 == 0 && i != 0)
                    {
                        reversedResult += " ";
                    }
                }
                reversedResult += new string(tail.ToCharArray().Reverse().ToArray());
                return reversedResult;
            }
        }
            public CarTravel()
        {
            InitializeComponent();
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            //Инициализируем объекта типа XmlTextReader и
            //загружаем XML документ с сайта центрального банка
            XmlTextReader reader = new XmlTextReader("http://www.cbr.ru/scripts/XML_daily.asp");
            //В эти переменные будем сохранять куски XML
            //с определенными валютами (Euro, USD)
            string USDXml = "";
            string EuroXML = "";
            //Перебираем все узлы в загруженном документе
            IPStatus status = IPStatus.Unknown;
            try
            {
                status = new Ping().Send("8.8.8.8").Status;
            }
            catch { }
       
            if (status == IPStatus.Success)
            {
                MessageBox.Show("Соединение с сервером установлено.");

                while (reader.Read())
                {
                    //Проверяем тип текущего узла
                    switch (reader.NodeType)
                    {
                        //Если этого элемент Valute, то начинаем анализировать атрибуты
                        case XmlNodeType.Element:

                            if (reader.Name == "Valute")
                            {
                                if (reader.HasAttributes)
                                {
                                    //Метод передвигает указатель к следующему атрибуту
                                    while (reader.MoveToNextAttribute())
                                    {
                                        if (reader.Name == "ID")
                                        {
                                            //Если значение атрибута равно R01235, то перед нами информация о курсе доллара
                                            if (reader.Value == "R01235")
                                            {
                                                //Возвращаемся к элементу, содержащий текущий узел атрибута
                                                reader.MoveToElement();
                                                //Считываем содержимое дочерних узлом
                                                USDXml = reader.ReadOuterXml();
                                            }
                                        }

                                        //Аналогичную процедуру делаем для ЕВРО
                                        if (reader.Name == "ID")
                                        {
                                            if (reader.Value == "R01239")
                                            {
                                                reader.MoveToElement();
                                                EuroXML = reader.ReadOuterXml();
                                            }
                                        }
                                    }
                                }
                            }

                            break;
                    }
                }

                //Из выдернутых кусков XML кода создаем новые XML документы
                XmlDocument usdXmlDocument = new XmlDocument();
                usdXmlDocument.LoadXml(USDXml);
                XmlDocument euroXmlDocument = new XmlDocument();
                euroXmlDocument.LoadXml(EuroXML);
                //Метод возвращает узел, соответствующий выражению XPath
                XmlNode xmlNode = usdXmlDocument.SelectSingleNode("Valute/Value");

                //Считываем значение и конвертируем в decimal. Курс валют получен
                usdValue = Convert.ToDouble(xmlNode.InnerText);
                xmlNode = euroXmlDocument.SelectSingleNode("Valute/Value");
                euroValue = Convert.ToDouble(xmlNode.InnerText);
            }
            else
            {
                MessageBox.Show("Ошибка соединения!");
            }


            
            EuroBox.Text = euroValue.ToString();
            UsdBox.Text = usdValue.ToString();
        }



        private void button1_Click(object sender, EventArgs e)
        {

            bool flag = false;

            if (FixPrice.Text=="" || EuroBox.Text == "" || CarPriceDollar.Text == "" || textBox3.Text == "" || UsdBox.Text == "")
            {
                MessageBox.Show("Данные то введи.");
            }
            try
                {
                    euroValue = Convert.ToDouble(EuroBox.Text);
                }
                catch (Exception)
                {
                    euroValue = 90;
                    EuroBox.Text = "90";
                    flag = true;
                }
            try
                {
                    usdValue = Convert.ToDouble(UsdBox.Text);
                }
                catch (Exception)
                {
                    usdValue = 75;
                    UsdBox.Text = "75";
                    flag = true;
                }
            try
                {
                    engineCapacity = Convert.ToDouble(textBox3.Text);
                }
                catch (Exception)
                {
                    if (textBox3.Text.ToUpper() == "V8" || textBox3.Text.ToUpper() == "ВЭ УОСЕМЬ")
                    {
                        engineCapacity = 5000;
                        textBox3.Text = "5000";
                        MessageBox.Show("Чо бы я тут ни насчитал для тебя - бесплатно!");
                    }
                    else
                    {
                        engineCapacity = 0;
                        textBox3.Text = "0";
                        flag = true;
                    }
                }
            try
                {
                    carCost = Convert.ToDouble(CarPriceDollar.Text);
                }
                catch (Exception)
                {
                    carCost = 0;
                    CarPriceDollar.Text = "0";
                    flag = true;
                }
            try
            {
                fixPrice = Convert.ToDouble( FixPrice.Text);
            }
            catch (Exception)
            {
                fixPrice = 0;
                FixPrice.Text = "0";
                flag = true;
            }
            try
            {
                priceCorrection=Convert.ToDouble(PriceCorrection.Text);
            }
            catch (Exception)
            {
                priceCorrection = 0;
                PriceCorrection.Text = "0";
            }
            if (flag)
            {
                    MessageBox.Show("Выведи и введи нормально.");
            }

            // memes
            if (carCost > 100000)
            {
                MessageBox.Show("Не нужна тебе такая машина, брат....\nПоверь мне на слово. Да и стоила бы вот столько....");
            }
            if (carCost > 10000000)
            {
                MessageBox.Show("Братан, у тебя клава залипла.");
            }
            // end memes

            double age = (DateTime.Now.Date - releaseDate.Date).Days / 365;
            Car car = new Car(age, engineCapacity, (carCost+deliver));

            string auctioneerPayment = AuctionerPayment(car, auctionName);
            string customsPayment = CustomsPayment(car, euroValue, usdValue);
            string customsPaymentSave = customsPayment;

            carCostRub.Text = AddPointerSpace(Math.Round(car.CarCost * usdValue).ToString()) + " rub";
            carCostDol.Text = AddPointerSpace(car.CarCost.ToString()) + " $";

            auctioneerPaymentDol.Text = AddPointerSpace(auctioneerPayment) + " $";
            auctioneerPaymentRub.Text = AddPointerSpace(Math.Round(Convert.ToDouble(auctioneerPayment) * usdValue, 2).ToString()) + " rub";

            double pfl = 500;//pensioner

            double roma = 0;
            string temp = "";
            string tmp1 = "";
            string tmp2 = "";
            double sbktsRf = 1234;//глонас

            romaBelDol.Text = roma.ToString() + " $";
            romaBelRub.Text = (roma * usdValue).ToString() + " rub";
            sbktsRfBelDol.Text = sbktsRf.ToString() + " $";
            sbktsRfBelRub.Text = Math.Round(sbktsRf * usdValue, 2).ToString() + " rub";
            deliverCostRub.Text = AddPointerSpace( (deliver * usdValue).ToString()) + " rub";
            deliverCostDol.Text = AddPointerSpace(deliver.ToString()) + " $";
            {///Russian Customs Output
                roma = 800;

                temp = customsPayment.Substring(0, customsPayment.IndexOf("|"));
                registrationCostRub.Text = temp + " rub";
                registrationcostDol.Text = Math.Round(Convert.ToDouble(temp) / usdValue, 2) + " $";
                customsPayment = customsPayment.Remove(0, customsPayment.IndexOf("|") + 1);

                temp = customsPayment.Substring(0, customsPayment.IndexOf("`"));
                recyclingFeeRub.Text = temp + " rub";
                recyclingFeeDol.Text = Math.Round(Convert.ToDouble(temp) / usdValue, 2) + " $";
                customsPayment = customsPayment.Remove(0, customsPayment.IndexOf("`") + 1);

                temp = customsPayment.Substring(0, customsPayment.IndexOf("!"));
                customDutiesRub.Text = AddPointerSpace(temp) + " rub";
                customDutiesDol.Text = AddPointerSpace(Math.Round(Convert.ToDouble(temp) / usdValue, 2).ToString()) + " $";
                customsPayment = customsPayment.Remove(0, customsPayment.IndexOf("!") + 1);
                temp = customsPayment.Substring(0, customsPayment.Length);

                label20.Text = Math.Round(sbktsRf * usdValue, 2).ToString()+" rub";
                label19.Text = sbktsRf.ToString()+" $";

                label13.Text = Math.Round(roma * usdValue, 2).ToString() + " rub";
                label12.Text = roma.ToString() + " $";

                tmp1 = Math.Round(Convert.ToDouble(temp) + ( roma + sbktsRf + Convert.ToDouble(auctioneerPayment) + carCost + priceCorrection) * usdValue,2).ToString();
                tmp2 = Math.Round(Convert.ToDouble(temp) / usdValue + carCost +   roma + sbktsRf +priceCorrection+ Convert.ToDouble(auctioneerPayment), 2).ToString();
                RusResultRub.Text = AddPointerSpace(tmp1) + " rub";
                RusResultol.Text = AddPointerSpace(tmp2) + " $";////||||||\\\\

                FixedCarPriceRusRub.Text = AddPointerSpace((Convert.ToDouble(tmp1) + fixPrice * usdValue).ToString()) + " rub";
                FixedCarPriceRusDol.Text = AddPointerSpace((Convert.ToDouble(tmp2) + fixPrice).ToString()) + " $";

            }
            {///Belorussian Customs Output

                double registrationCost = 50;
                customsPayment = customsPaymentSave;
                roma = 1400;
                pfl = 500;//pensioner

                fixPrice = Math.Round(fixPrice, 2);
                registrationCostBelDol.Text = registrationCost.ToString() + " $";
                registrationCostBelRub.Text = (registrationCost * usdValue).ToString() + " rub";

                recyclingFeeBelRub.Text = (recyclingFee * usdValue).ToString() + " rub";
                recyclingFeeBelDol.Text = recyclingFee.ToString() + " $";

                pflBelDol.Text = pfl.ToString() + " $";
                pflBelRub.Text = (pfl * usdValue).ToString() + " rub";



                customsPayment = customsPayment.Remove(0, customsPayment.IndexOf("`") + 1);
                customsPayment = customsPayment.Substring(0, customsPayment.IndexOf("!"));
                customsPayment = (Convert.ToDouble(customsPayment) / 2).ToString();
                customsPaymentBelRub.Text = AddPointerSpace(customsPayment) + " rub";
                customsPaymentBelDol.Text = AddPointerSpace(Math.Round(Convert.ToDouble(customsPayment) / usdValue).ToString()) + "  $";
                romaBelRub.Text = (roma*usdValue).ToString()+" rub";
                romaBelDol.Text = roma.ToString()+" $";

                tmp1 = ((Convert.ToDouble(customsPayment) / usdValue + pfl +priceCorrection+ + sbktsRf +  recyclingFee + roma + registrationCost + Convert.ToDouble(auctioneerPayment) + carCost) * usdValue).ToString();
                tmp2 = Math.Round(Convert.ToDouble(customsPayment) / usdValue + pfl + sbktsRf +priceCorrection + recyclingFee + roma + registrationCost + Convert.ToDouble(auctioneerPayment) + carCost, 2).ToString();
                ResultBelRub.Text = AddPointerSpace(tmp1);
                ResultBelDol.Text = AddPointerSpace(tmp2);

                FixedCarPriceBelRub.Text = AddPointerSpace((Convert.ToDouble(tmp1)+fixPrice*usdValue).ToString()) + " rub" ;
                FixedCarPriceBelDol.Text = AddPointerSpace((Convert.ToDouble(tmp2) + fixPrice).ToString()) + " $"; 

                ResultBelRub.Text+= " rub";
                ResultBelDol.Text += " $";
            }

        }
        private void CarTravel_Load(object sender, EventArgs e)
        {
            releaseDatePicker.Value = DateTime.Now.AddYears(-4);
            releaseDate = releaseDatePicker.Value;
        }
        private void Result_Click(object sender, EventArgs e)
        {
        }
        private void textBox4_Enter(object sender, EventArgs e)
        {
            euroValue = Convert.ToDouble(EuroBox.Text);
        }
        private void textBox5_Enter(object sender, EventArgs e)
        {
            usdValue = Convert.ToDouble(UsdBox.Text);
        }

        private void arrivalPortBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (arrivalPortBox.SelectedIndex == 0)
            {
                label15.Text = 2400.ToString() + " $";
                deliver = 2400;//??????????
            }
            else if (arrivalPortBox.SelectedIndex == 1)
            {
                deliver = 1175 + 300 + 40 + 50 + 50;//deliver to clayped + deliver from cayped + port + lafet + declarant payment
                label15.Text = deliver.ToString() + " $";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            auctionName = "copart";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            auctionName = "iaai";
        }

        private void releaseDatePicker_ValueChanged(object sender, EventArgs e)
        {
            releaseDate = releaseDatePicker.Value;
        }

        private void textBox4_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                UsdBox.Focus();
            }
        }

        private void textBox5_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                releaseDatePicker.Focus();
            }
        }

        private void releaseDatePicker_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox3.Focus();
            }
        }
        private void textBox3_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                arrivalPortBox.Focus();
            }
        }

        private void arrivalPortBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                radioButton1.Focus();

            }
        }

        private void radioButton1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CarPriceDollar.Focus();
            }
        }

        private void radioButton2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CarPriceDollar.Focus();
            }
        }



        private void FixPrice_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PriceCorrection.Focus();
            }
        }

        private void CarPriceDollar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FixPrice.Focus();
            }
        }

        private void PriceCorrection_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.Focus();
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = e.KeyChar == (char)Keys.Enter;
            }

        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = e.KeyChar == (char)Keys.Enter;
            }
        }

        private void releaseDatePicker_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = e.KeyChar == (char)Keys.Enter;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = e.KeyChar == (char)Keys.Enter;
            }
        }

        private void arrivalPortBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = e.KeyChar == (char)Keys.Enter;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = e.KeyChar == (char)Keys.Enter;
            }
        }

        private void CarPriceDollar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = e.KeyChar == (char)Keys.Enter;
            }
        }



        private void FixPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = e.KeyChar == (char)Keys.Enter;
            }
        }

       

        private void textBox4_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Валидация "внутри" нажатия на OK

        }

        private void textBox4_Validated(object sender, EventArgs e)
        {
        }

        


        private void PriceCorrection_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = e.KeyChar == (char)Keys.Enter;
            }
        }

        
    }
}