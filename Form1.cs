using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeQuestions
{
    public partial class Form1 : Form
    { 
        static int sizeofArrayCars = 100;
        Car[] cars = new Car[sizeofArrayCars];
 
        string[] marks = new string[] {nameof(MercedesBenz),nameof(Opel), nameof(Lada)};
        
       
        public int index = 0;
        public Form1()
        {
            InitializeComponent();
            comboBoxMark.DataSource = marks;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (index < sizeofArrayCars)
            {
                var mark = comboBoxMark.SelectedItem.ToString();
                var model = textBoxModel.Text;
                var carNumber = textBoxCarNumber.Text;
                var fioDriver = textBoxDriverFio.Text;
                var status = textBoxStatus.Text;
                var color = comboBoxColor.SelectedItem.ToString();
                if (string.IsNullOrEmpty(mark))
                {
                    MessageBox.Show("Поля Марка не заполнен!");
                    return;
                }
                if (string.IsNullOrEmpty(model))
                {
                    MessageBox.Show("Поля Модел не заполнен!");
                    return;
                }
                if (string.IsNullOrEmpty(carNumber))
                {
                    MessageBox.Show("Поля гос.Номер не заполнен!");
                    return;
                }
                if (string.IsNullOrEmpty(fioDriver))
                {
                    MessageBox.Show("Поля ФИО шофьера не заполнен!");
                    return;
                }


                if (mark == nameof(MercedesBenz))
                {
                    var car = new MercedesBenz(mark, model, carNumber, fioDriver, color, status);

                    cars[index] = car;
                    index++;
                    var row = car.GetProps();
                    dataGridView1.Rows.Add(row);
                }
                else if (mark == nameof(Opel))
                {
                    var car = new Opel(mark, model, carNumber, fioDriver, color, status);

                    cars[index] = car;
                    index++;
                    var row = car.GetProps();
                    dataGridView1.Rows.Add(row);
                }
                else if (mark == nameof(Lada))
                {
                    var car  = new Lada(mark, model, carNumber, fioDriver, color, status);

                    cars[index] = car;
                    index++;
                    var row = car.GetProps();
                    dataGridView1.Rows.Add(row);
                }
            }
           
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
                listBox2.Items.Clear(); 
            foreach (var car in cars)
            {
                if (car != null)
                {                    
                        car.Go();
                    listBox2.Items.Add(car.String());
                }
            }
        }
    }
}
