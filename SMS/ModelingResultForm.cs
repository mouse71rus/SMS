using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SMS
{
    public partial class ModelingResultForm : Form
    {
        public ModelingResultForm(int count, int max, int min, double avg, int CountMin, Dictionary<State, int> frequency, Dictionary<State, double> relativeFrequency, Dictionary<KeyValuePair<State, State>, int> changeover)
        {
            InitializeComponent();

            countLabel.Text += count;
            maxLabel.Text += max;
            minLabel.Text += min;
            avgLabel.Text += String.Format("{0:F2}", avg);
            countMinLabel.Text += CountMin;

            string name = "frequency";
            frequencyChart.Series.Clear();
            //добавляем элемент в коллекцию
            frequencyChart.Series.Add(name);

            var resOrder = frequency.OrderBy(x => (int)x.Key);
            foreach (var item in resOrder)
            {
                frequencyChart.Series[name].Points.AddXY("State " + (int)item.Key, item.Value);
                frequencyChart.Series[name].Points[frequencyChart.Series[name].Points.Count - 1].ToolTip = item.Value.ToString();
            }
            frequencyChart.Series[name].LegendText = "Частота";

            relativeFrequencyChart.Series.Clear();
            string name2 = "relativeFrequency";
            relativeFrequencyChart.Series.Add(name2);
            relativeFrequencyChart.Series[name2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            var resOrder2 = relativeFrequency.OrderBy(x => (int)x.Key);
            foreach (var item in resOrder2)
            {
                relativeFrequencyChart.Series[name2].Points.AddXY("State " + (int)item.Key, item.Value);
                relativeFrequencyChart.Series[name2].Points[relativeFrequencyChart.Series[name2].Points.Count - 1].ToolTip = String.Format("{0:F2}", item.Value);
            }

            string name3 = "changeover";
            changeoverChart.Series.Clear();
            changeoverChart.Series.Add(name3);
            var resOrder3 = changeover.OrderBy(x => x.Key.Key);
            foreach (var item in resOrder3)
            {
                changeoverChart.Series[name3].Points.AddXY("State " + (int)item.Key.Key + " --> " + "State " + (int)item.Key.Value, item.Value);
                //changeoverChart.Series[name3].Points.AddXY("1", item.Value);
                changeoverChart.Series[name3].Points[changeoverChart.Series[name3].Points.Count - 1].ToolTip = "State " + (int)item.Key.Key + " --> " + "State " + (int)item.Key.Value;//item.Value.ToString();
            }
            changeoverChart.Series[name3].LegendText = "Загруженность переходов";
        }
    }
}
