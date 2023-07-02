using practice.DTOs;
using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace practice.Services
{
	class ChartManager
	{
        private bool isDegrees { get; set; }
        private string selectedFunction { get; set; }
        private CheckBoxCornersDTO _checkBoxCornersDTO { get; set; }

        public ChartManager(CheckBoxCornersDTO checkBoxCornersDTO)
		{
            _checkBoxCornersDTO = checkBoxCornersDTO;
        }
        private double ConvertToRadians(double degrees)
		{
            return degrees * Math.PI / 180;
        }
        private void FunctionCheckBox_CheckedChanged(CheckBoxCornersDTO checkBoxCornersDTO)
        {
            if (checkBoxCornersDTO.SinCheckBox.Checked) selectedFunction = checkBoxCornersDTO.SinCheckBox.Text;
            if (checkBoxCornersDTO.CosCheckBox.Checked) selectedFunction = checkBoxCornersDTO.CosCheckBox.Text;
            if (checkBoxCornersDTO.TgCheckBox.Checked) selectedFunction = checkBoxCornersDTO.TgCheckBox.Text;
            if (checkBoxCornersDTO.CtgCheckBox.Checked) selectedFunction = checkBoxCornersDTO.CtgCheckBox.Text;
        }

        private double CalculateFunction(string functionName, double angle)
		{
            if (functionName == "sin") return Math.Sin(angle);
            if (functionName == "cos") return Math.Cos(angle);
            if (functionName == "tg") return Math.Tan(angle);
            if (functionName == "ctg") return 1 / Math.Tan(angle);
            return double.NaN;
        }
        public void DrawChart(DrawChartDTO drawChartDTO)
		{
            FunctionCheckBox_CheckedChanged(_checkBoxCornersDTO);

            isDegrees = drawChartDTO.DegreesRadioButton.Checked;
            if (double.TryParse(drawChartDTO.AngleTextBox.Text, out double angle))
            {
                double angleInRadians = isDegrees ? ConvertToRadians(angle) : angle;
                double result = CalculateFunction(selectedFunction, angleInRadians);
                if (result == double.NaN)
                {
                    MessageBox.Show("Произошла ошибка");
                    return;
                }

                drawChartDTO.Chart1.Series.Clear();
                drawChartDTO.Chart1.ChartAreas.Clear();

                ChartArea chartArea = new ChartArea();
                drawChartDTO.Chart1.ChartAreas.Add(chartArea);

                Series series = new Series(selectedFunction);
                series.ChartType = SeriesChartType.Line;
                drawChartDTO.Chart1.Series.Add(series);

                for (double x = 0; x <= 360; x += 1)
                {
                    double y = CalculateFunction(selectedFunction, ConvertToRadians(x));
                    series.Points.AddXY(x, y);
                }

                drawChartDTO.Chart1.Update();
            }
            else
            {
                MessageBox.Show("Invalid angle value. Please enter a valid numeric value.");
            }
        }
	}
}
