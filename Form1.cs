using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pract12_v3_Соколов_ПР_23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Sportsman
        {
            public string FirstName { get; set; }
            public string Patronomyc { get; set; }
            public string LastName { get; set; }
            public string Gender { get; set; }
            public int Age { get; set; }
            public double Height { get; set; }
            public double Weight { get; set; }
            public string SportType { get; set; }

            public string GetInfo()
            {
                return $"ФИО: {LastName} {FirstName} {Patronomyc}\nПол: {Gender}\nВозраст: {Age}\nВид спорта: {SportType}" ;
            }

            public double IdealWeightBroca()
            {
                if (Age <= 40)
                {
                    return Height - 110;
                }
                else
                {
                    return Height - 100;
                }
            }

            public double IdealWeightCooper()
            {
                if (Gender == "Женский")
                {
                    return (Height * 3.5 - 108) * 0.453;
                }
                else
                {
                    if (Gender == "Мужской")
                    {
                        return (Height * 4.0 - 128) * 0.453;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }

            public double CalculateBMI()
            {
                double heightMeters = Height / 100.0;
                return Weight / (heightMeters * heightMeters);
            }
        }        
        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var sportsman = new Sportsman
                {
                    FirstName = textBox1.Text,
                    Patronomyc = textBox2.Text,
                    LastName = textBox3.Text,
                    Age = Convert.ToInt32(textBox4.Text),
                    Gender = comboBox1.Text,
                    Height = Convert.ToDouble(textBox5.Text),
                    Weight = Convert.ToDouble(textBox6.Text),
                    SportType = textBox7.Text
                };
                string info = sportsman.GetInfo();
                info += $"\n\nИдеаьный вес (формуа Брока):{sportsman.IdealWeightBroca()} кг";
                info += $"\nИдеаьный вес (формуа Купера):{sportsman.IdealWeightCooper()} кг";
                info += $"\nИМТ:{sportsman.CalculateBMI()}";
                MessageBox.Show(info, "Информация о спортсмене");
            }           
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка ввода данных" + ex.Message);
            }
        }
    }
}
