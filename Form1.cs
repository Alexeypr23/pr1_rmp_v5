using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pract11_Соколов_ПР_23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "Ваше имя";
            label2.Text = "Ваш рост";
            label3.Text = "Ваш вес";
            label4.Text = "Кол-во еды";
            button1.Text = "Расчет веса";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Student stud = new Student();
            stud.name = textBox1.Text;
            stud.rost = Convert.ToInt32(numericUpDown1.Value);
            stud.ves = Convert.ToInt32(numericUpDown2.Value);
            stud.SetEat(Convert.ToDouble(numericUpDown3.Value));
            label5.Text = string.Format($"Студент: {textBox1.Text}, Рост: {stud.rost} см, Вес: {stud.ves} кг", stud.name, stud.rost, stud.GetEat(0));
        }
    }
}
