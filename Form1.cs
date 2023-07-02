﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace practice
{
    public partial class Form1 : Form
    {
        private string selectedFunction;
        private double angle;
        private bool isDegrees;


        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("sin");
            comboBox1.Items.Add("cos");
            comboBox1.Items.Add("tg");
            comboBox1.Items.Add("ctg");

            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = comboBox1.SelectedItem.ToString();

            // Обработка выбора элемента ComboBox
            if (selectedItem == "sin")
            {
                textBox1.Clear();
                textBox1.Text = "Синус (от латинского слова \"sinus\", означающего \"изгиб\" или \"полость\") - это математическая функция, которая описывает гармонические колебания или изменения величины со временем. " +
                    "Синус является одной из тригонометрических функций и широко применяется в различных областях науки, техники и физики.\r\n\r\n" +
                    "Основные характеристики синуса:" +
                    "\r\n\r\nДиапазон значений: синус принимает значения в интервале от -1 до 1. Это значит, что амплитуда (максимальное значение) синусоиды равна 1, а функция колеблется между этими значениями." +
                    "\r\nПериодичность: синусоида повторяет себя через определенные промежутки времени или угловые единицы. Синус имеет период 2π радиан или 360 градусов. " +
                    "Это означает, что значение синуса повторяется каждые 2π радиан или 360 градусов." +
                    "\r\nФазовый сдвиг: синус может быть сдвинут во времени или по фазе. Фазовый сдвиг определяет смещение графика синусоиды по оси времени или углу." +
                    "\r\r\n\nНекоторые основные свойства синуса:\r\n\r\nСимметрия: синус является нечетной функцией, то есть sin(-x) = -sin(x). Это означает, что график синусоиды симметричен относительно начала координат." +
                    "\r\nОрдината: синус принимает значение 0 при аргументе 0, т.е. sin(0) = 0.\r\n" +
                    "Периодичность: синус является периодической функцией, и его график повторяется через каждый период." +
                    "\r\n\nПрименение синуса:" +
                    "\r\nСинусоиды имеют широкое применение в науке и инженерии. Они используются для описания колебаний и волн, таких как звук, электромагнитные волны и акустические сигналы. " +
                    "Синусы также используются в математическом моделировании и анализе данных, в физике, музыке, электротехнике, сигнальной обработке и многих других областях.";
            }
            else if (selectedItem == "cos")
            {
                textBox1.Clear();
                textBox1.Text = "Косинус (от латинского слова \"cosinus\") - это математическая функция, которая также относится к тригонометрическим функциям, подобно синусу. " +
                    "Как и синус, косинус широко используется в науке, инженерии и других областях для моделирования и анализа гармонических колебаний и волн.\r\n\r\nОсновные характеристики косинуса:\r\n\r\n" +
                    "Диапазон значений: косинус также принимает значения в интервале от -1 до 1. " +
                    "Он колеблется между этими значениями и имеет амплитуду " +
                    "1.\r\nПериодичность: косинус имеет такой же период, как и синус, равный 2π радиан или 360 градусов. Это означает, что значение косинуса повторяется каждые 2π радиан или 360 градусов.\r\nФазовый сдвиг: косинус может быть сдвинут по фазе относительно синуса. " +
                    "Фазовый сдвиг определяет смещение графика косинусоиды по оси времени или углу.\r\nНекоторые основные свойства косинуса:\r\n\r\nСимметрия: косинус является четной функцией, то есть cos(-x) = cos(x). Это означает, что график косинусоиды симметричен относительно оси ординат." +
                    "\r\nОрдината: косинус принимает значение 1 при аргументе 0, т.е. cos(0) = 1.\r\nФазовый сдвиг: косинус имеет фазовый сдвиг на π/2 радиан или 90 градусов относительно синуса. Это означает, что графики синуса и косинуса сдвинуты друг относительно друга по фазе." +
                    "\r\nПрименение косинуса:\r\nКосинус также широко применяется в науке, инженерии и других областях. Он используется для моделирования гармонических колебаний, волн, осцилляций и других процессов, аналогично синусу. Косинус также находит применение в математическом моделировании, физике, электротехнике, музыке, телекоммуникациях, обработке сигналов и других дисциплинах.";
            }
            else if (selectedItem == "tg")
            {
                textBox1.Clear();
                textBox1.Text = "Тангенс (от латинского слова \"tangens\") - это математическая функция, которая также относится к тригонометрическим функциям, вместе с синусом и косинусом. " +
                    "Тангенс широко применяется в математике, физике, инженерии и других областях для решения задач, связанных с углами и прямоугольными треугольниками." +
                    "\r\n\r\nОпределение тангенса:\r\nТангенс угла в прямоугольном треугольнике определяется как отношение длины противолежащего катета к длине прилежащего катета. " +
                    "Математически, тангенс угла θ выражается как отношение sin(θ) к cos(θ):\r\n\r\ntan(θ) = sin(θ) / cos(θ)\r\n\r\nОсновные свойства тангенса:\r\n\r\n" +
                    "Диапазон значений: тангенс может принимать любые вещественные значения, и его диапазон значений является всем множеством вещественных чисел." +
                    "\r\nПериодичность: тангенс имеет период π радиан или 180 градусов. Это означает, что значение тангенса повторяется каждые π радиан или 180 градусов." +
                    "\r\nАсимптоты: тангенс имеет вертикальные асимптоты при значениях аргумента, равных (2n + 1)π/2 радиан или (2n + 1) * 90 градусов, где n - целое число." +
                    "\r\nПрименение тангенса:\r\nТангенс находит широкое применение в решении задач, связанных с углами и треугольниками. Некоторые из применений тангенса включают:" +
                    "\r\n\r\nРешение треугольников: тангенс используется для вычисления неизвестных сторон или углов в прямоугольных и общих треугольниках." +
                    "\r\nКомплексные числа: тангенс может быть выражен через комплексные числа и использоваться для выполнения операций с комплексными числами." +
                    "\r\nФизика: тангенс применяется в физике для анализа движения, электрических цепей, осцилляций и других явлений.";
            }
            else if (selectedItem == "ctg")
            {
                textBox1.Clear();
                textBox1.Text = "Котангенс (от латинского слова \"cotangens\" или \"cotangent\") - это тригонометрическая функция, обратная к тангенсу. " +
                    "Она широко применяется в математике, физике, инженерии и других областях для анализа углов и прямоугольных треугольников.\r\n\r\n" +
                    "Определение котангенса:\r\nКотангенс угла в прямоугольном треугольнике определяется как отношение длины прилежащего катета к длине противолежащего катета. " +
                    "Математически, котангенс угла θ выражается как обратное отношение тангенса:\r\n\r\ncot(θ) = 1 / tan(θ) = cos(θ) / sin(θ)\r\n\r\nОсновные свойства котангенса:\r\n\r\n" +
                    "Диапазон значений: котангенс может принимать любые вещественные значения, и его диапазон значений является всем множеством вещественных чисел, за исключением значений, где синус равен нулю." +
                    "\r\nПериодичность: котангенс имеет период π радиан или 180 градусов. Это означает, что значение котангенса повторяется каждые π радиан или 180 градусов.\r\n" +
                    "Асимптоты: котангенс также имеет вертикальные асимптоты при значениях аргумента, равных nπ радиан или n * 180 градусов, где n - целое число.\r\nПрименение котангенса:\r\n" +
                    "Котангенс используется в различных областях для анализа углов, треугольников и других математических задач. Некоторые из применений котангенса включают:\r\n\r\n" +
                    "Решение треугольников: котангенс используется для вычисления неизвестных сторон или углов в прямоугольных и общих треугольниках.\r\n" +
                    "Математическое моделирование: котангенс может использоваться в математическом моделировании для описания колебаний, осцилляций и других процессов.\r\n" +
                    "Электротехника и физика: котангенс применяется в электротехнике и физике для анализа электрических цепей, колебаний, сигналов и других физических явлений.";
            }
        }

        private void FunctionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.CheckBox checkBox = (System.Windows.Forms.CheckBox)sender;

            if (checkBox.Checked)
            {
                if (checkBox.Name == "SinCheckBox" || checkBox.Name == "CosCheckBox" ||
                    checkBox.Name == "TgCheckBox" || checkBox.Name == "CtgCheckBox")
                {
                    selectedFunction = checkBox.Text;
                }
            }
        }

        private void UnitsRadioButton_CheckedChanged(object sender, EventArgs e)
        {

            System.Windows.Forms.RadioButton radioButton = (System.Windows.Forms.RadioButton)sender;
            if (radioButton.Checked)
            {
                if (radioButton.Name == "DegreesRadioButton")
                {
                    isDegrees = true;
                }
                else if (radioButton.Name == "RadiansRadioButton")
                {
                    isDegrees = false;
                }
            }
            SinCheckBox.CheckedChanged += FunctionCheckBox_CheckedChanged;
            CosCheckBox.CheckedChanged += FunctionCheckBox_CheckedChanged;
            TgCheckBox.CheckedChanged += FunctionCheckBox_CheckedChanged;
            CtgCheckBox.CheckedChanged += FunctionCheckBox_CheckedChanged;
            DegreesRadioButton.CheckedChanged += UnitsRadioButton_CheckedChanged;
            RadiansRadioButton.CheckedChanged += UnitsRadioButton_CheckedChanged;
            CalculateButton.Click += CalculateButton_Click;

        }

        private double CalculateFunction(string functionName, double angle)
        {
            switch (functionName)
            {
                case "sin":
                    return Math.Sin(angle);
                case "cos":
                    return Math.Cos(angle);
                case "tg":
                    return Math.Tan(angle);
                case "ctg":
                    return 1 / Math.Tan(angle);
                default:
                    throw new ArgumentException("Invalid function name.");
            }
        }

        private double ConvertToRadians(double degrees)
        {
            return degrees * Math.PI / 180;
        }
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if (double.TryParse(AngleTextBox.Text, out double angle))
            {
                double angleInRadians = isDegrees ? ConvertToRadians(angle) : angle;
                double result = CalculateFunction(selectedFunction, angleInRadians);


                Chart1.Series.Clear();
                Chart1.ChartAreas.Clear();

                ChartArea chartArea = new ChartArea();
                Chart1.ChartAreas.Add(chartArea);

                Series series = new Series(selectedFunction);
                series.ChartType = SeriesChartType.Line;
                Chart1.Series.Add(series);

                for (double x = 0; x <= 360; x += 1)
                {
                    double y = CalculateFunction(selectedFunction, ConvertToRadians(x));
                    series.Points.AddXY(x, y);
                }

                Chart1.Update();
            }
        
            else
            {
                MessageBox.Show("Invalid angle value. Please enter a valid numeric value.");
            }
        }
    }
}