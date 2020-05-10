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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private DataTable dt;
        private State endState = State.s5;
        private int EPS = 15;
        private int Lenght;
        /// <summary>
        /// Инициализация Матрицы состояния по умолчанию
        /// </summary>
        private void MatrixOfStateInitDefault()
        {
            Lenght = 6;
            dt = new DataTable();

            dt.Columns.Add(State.s1.ToString());
            dt.Columns.Add(State.s2.ToString());
            dt.Columns.Add(State.s3.ToString());
            dt.Columns.Add(State.s4.ToString());
            dt.Columns.Add(State.s5.ToString());
            dt.Columns.Add(State.s6.ToString());

            object[] r1 = { 0, 0.65, 0, 0, 0, 0.25 };
            dt.Rows.Add(r1);

            object[] r2 = { 0, 0, 0.4, 0.2, 0, 0 };
            dt.Rows.Add(r2);

            object[] r3 = { 0, 0, 0, 0, 0, 0.95 };
            dt.Rows.Add(r3);

            object[] r4 = { 0.6, 0, 0, 0, 0.4, 0 };
            dt.Rows.Add(r4);

            object[] r5 = { 0, 0, 0, 0, 0, 0 };
            dt.Rows.Add(r5);

            object[] r6 = { 0, 0, 0, 0.6, 0, 0 };
            dt.Rows.Add(r6);

            MatrixOfState.DataSource = dt;

            for (int i = 0; i < Lenght; i++)
            {
                for (var j = 0; j < Lenght; j++)
                {
                    MatrixOfState.Rows[i].Cells[j].ValueType = typeof(double);
                    var cell = MatrixOfState.Rows[i].Cells[j].Value.ToString();
                    double c = Convert.ToDouble(cell);

                    if (c == 0)
                    {
                        if (i == j)
                        {
                            MatrixOfState.Rows[i].Cells[j].Style.BackColor = Color.GreenYellow;
                        }
                        else
                        {
                            MatrixOfState.Rows[i].Cells[j].Style.BackColor = Color.LightGray;
                        }
                        MatrixOfState.Rows[i].Cells[j].ReadOnly = true;
                    }
                }
            }

            MatrixOfState.Columns[State.s1.ToString()].HeaderText = "Состояние 1";
            MatrixOfState.Columns[State.s2.ToString()].HeaderText = "Состояние 2";
            MatrixOfState.Columns[State.s3.ToString()].HeaderText = "Состояние 3";
            MatrixOfState.Columns[State.s4.ToString()].HeaderText = "Состояние 4";
            MatrixOfState.Columns[State.s5.ToString()].HeaderText = "Состояние 5";
            MatrixOfState.Columns[State.s6.ToString()].HeaderText = "Состояние 6";

            MatrixOfState.Columns[State.s1.ToString()].SortMode = DataGridViewColumnSortMode.NotSortable;
            MatrixOfState.Columns[State.s2.ToString()].SortMode = DataGridViewColumnSortMode.NotSortable;
            MatrixOfState.Columns[State.s3.ToString()].SortMode = DataGridViewColumnSortMode.NotSortable;
            MatrixOfState.Columns[State.s4.ToString()].SortMode = DataGridViewColumnSortMode.NotSortable;
            MatrixOfState.Columns[State.s5.ToString()].SortMode = DataGridViewColumnSortMode.NotSortable;
            MatrixOfState.Columns[State.s6.ToString()].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            MatrixOfStateInitDefault();
            //dt.Rows[0][0] = 15;
        }

        private void Start_Click(object sender, EventArgs e)
        {
            try
            {
                var rows = dt.Select();
                for (int i = 0; i < rows.Count<DataRow>(); i++)
                {
                    double sum = 0;
                    for (int j = 0; j < dt.Rows[i].ItemArray.Length; j++)
                    {
                        sum += Convert.ToDouble(rows[i][j]);
                    }
                    
                    if (sum > 1 || sum < 0)
                    {
                        throw new SMSException($"Строка {i} имеет неверный формат. Сумма значений строки должна быть больше или равно 0, и меньше или равно 1.");
                    }
                    dt.Rows[i][i] = 1 - sum;
                }

                int Count = Convert.ToInt32(CountStep.Text);// Количество шагов
                if (Count < 0)
                {
                    throw new SMSException("Количество шагов указано неверно");
                }

                int CountX2 = Count * 2;
                double[][] array = new double[CountX2][];
                array[0] = new double[dt.Rows[0].ItemArray.Length];
                // Заполняем начальными значениями
                for (int j = 0; j < dt.Rows[0].ItemArray.Length; j++)
                {
                    array[0][j] = Convert.ToDouble(rows[0][j]);
                }

                for (int i = 1; i < CountX2; i++)
                {
                    array[i] = CalcAdvanced(array[i - 1]);
                }

                DataTable[] dt_res = new DataTable[2];

                for (int i = 0; i < 2; i++)
                {
                    dt_res[i] = new DataTable();
                    dt_res[i].Columns.Add("0");
                    dt_res[i].Columns.Add(State.s1.ToString());
                    dt_res[i].Columns.Add(State.s2.ToString());
                    dt_res[i].Columns.Add(State.s3.ToString());
                    dt_res[i].Columns.Add(State.s4.ToString());
                    dt_res[i].Columns.Add(State.s5.ToString());
                    dt_res[i].Columns.Add(State.s6.ToString());
                }
                    

                for (int i = 0; i < CountX2; i++)
                {
                    object[] arr = new object[dt.Rows[0].ItemArray.Length + 1];
                    arr[0] = i + 1;
                    for (int j = 0; j < dt.Rows[0].ItemArray.Length; j++)
                    {
                        arr[j + 1] = array[i][j];
                    }
                    if(i >= Count)
                    {
                        dt_res[1].Rows.Add(arr);
                    }
                    else
                    {
                        dt_res[0].Rows.Add(arr);
                        dt_res[1].Rows.Add(arr);
                    }
                    
                }

                ResultForm rf = new ResultForm(dt_res);
                rf.ShowDialog();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(SMSException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private double[] CalcAdvanced(double[] inputValues)
        {
            double[] outputValues = new double[inputValues.Length];
            for (int j = 0; j < inputValues.Length; j++)
            {
                double sum = 0;
                for (int k = 0; k < dt.Rows.Count; k++)
                {
                    sum += Math.Round(inputValues[k] * Convert.ToDouble(dt.Rows[k].ItemArray.ElementAt(j)), EPS, MidpointRounding.AwayFromZero);
                }
                outputValues[j] = sum;
            }

            return outputValues;
        }

        public Dictionary<int, double> GetSortedDictionary(double[] Source)
        {
            Dictionary<int, double> outputDictionary = new Dictionary<int, double>();
            for (int i = 0; i < Source.Length; i++)
            {
                outputDictionary.Add(i, Source[i]);
            }

            return outputDictionary.OrderBy(val => val.Value).ToDictionary(x => x.Key, x => x.Value);
        }
        private void Run_Click(object sender, EventArgs e)
        {
            try
            {
                int Count = Convert.ToInt32(NumberOfExperiments.Text);// Количество экспериментов
                if (Count < 0)
                {
                    throw new SMSException("Количество экспериментов указано в неверном формате");
                }
                var rows = dt.Select();
                for (int i = 0; i < rows.Count<DataRow>(); i++)
                {
                    double sum = 0;
                    for (int j = 0; j < dt.Rows[i].ItemArray.Length; j++)
                    {
                        sum += Convert.ToDouble(rows[i][j]);
                    }

                    if (sum > 1 || sum < 0)
                    {
                        throw new SMSException($"Строка {i} имеет неверный формат. Сумма значений строки должна быть больше или равно 0, и меньше или равно 1.");
                    }
                    dt.Rows[i][i] = 1 - sum;
                }
                List<double[]> array = new List<double[]>();
                // Заполняем начальными значениями
                for (int i = 0; i < Lenght; i++)
                {
                    array.Add(new double[Lenght]);
                    for (int j = 0; j < Lenght; j++)
                    {
                        array[i][j] = Convert.ToDouble(rows[i][j]);
                    }
                }

                List<Dictionary<int, double>> Dict = new List<Dictionary<int, double>>();

                foreach (var item in array)
                {
                    Dict.Add(GetSortedDictionary(item));
                }

                int[] stat = new int[Count];

                List<State> statState = new List<State>();

                Dictionary<KeyValuePair<State, State>, int> pereh = new Dictionary<KeyValuePair<State, State>, int>();
                Random rnd = new Random();
                for (int i = 0; i < Count; i++)
                {
                    State thisState = State.s1;
                    statState.Add(thisState);
                    int currentStep = 0;// текущий вычисленный шаг

                    while (thisState != endState)
                    {
                        double c = rnd.NextDouble();

                        int ch = 1;// Счётчик
                        foreach (var item in Dict[(int)(thisState) - 1])
                        {
                            if (c < item.Value || ch == Lenght)
                            {
                                KeyValuePair<State, State> tmp = new KeyValuePair<State, State>(thisState, (State)(item.Key + 1));
                                if (pereh.ContainsKey(tmp))
                                {
                                    pereh[tmp]++;
                                }
                                else
                                {
                                    pereh.Add(tmp, 1);
                                }
                                thisState = tmp.Value;
                                statState.Add(thisState);
                                break;
                            }
                            ch++;
                        }

                        currentStep++;
                    }

                    stat[i] = currentStep + 1;
                }
                int max = stat.Max();
                int min = stat.Min();
                double avg = stat.Average();
                int CountMin = stat.Where(x => x == min).Count();
                
                var frequency = statState.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());
                

                int sumFrequency = frequency.Sum(x => x.Value);
                Dictionary<State, double> relativeFrequency = new Dictionary<State, double>();
                foreach (var item in frequency)
                {
                    relativeFrequency.Add(item.Key, ((double)item.Value / sumFrequency) * 100);
                }

                ModelingResultForm mrf = new ModelingResultForm(Count, max, min, avg, CountMin, frequency, relativeFrequency, pereh);
                mrf.ShowDialog();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (SMSException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Сергей Жимерин 4В 120861 (с) 2020", "Об авторе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("5 вариант\nПусть процесс стационарного лечения больного описывается размеченным графом состояний и переходов, ГСП (рис.1-7), в котором вершины – возможные состояния пациента, а ребра – изменения этих состояний в результате лечебных процедур. Состояниям соответствуют вершины графа, переходам – ребра графа, «вес» ребра соответствует вероятности перехода из одного состояния в другое. Для всех вариантов исходным является состояние 1. ", "Помощь", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    public enum State
    {
        s1 = 1,
        s2 = 2,
        s3 = 3,
        s4 = 4,
        s5 = 5,//конечное
        s6 = 6,
    }

    public class SMSException : Exception
    {
        public SMSException(string message)
            : base(message)
        { }
    }
}
