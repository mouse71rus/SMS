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
    public partial class ResultForm : Form
    {
        private DataTable[] dt;
        public ResultForm(DataTable[] dt)
        {
            InitializeComponent();
            this.dt = dt;

            MatrixOfState.DataSource = this.dt[0];

            MatrixOfState.Columns[0].HeaderText = "Шаг";
            MatrixOfState.Columns[State.s1.ToString()].HeaderText = "Состояние 1";
            MatrixOfState.Columns[State.s2.ToString()].HeaderText = "Состояние 2";
            MatrixOfState.Columns[State.s3.ToString()].HeaderText = "Состояние 3";
            MatrixOfState.Columns[State.s4.ToString()].HeaderText = "Состояние 4";
            MatrixOfState.Columns[State.s5.ToString()].HeaderText = "Состояние 5";
            MatrixOfState.Columns[State.s6.ToString()].HeaderText = "Состояние 6";

            MatrixOfState.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            MatrixOfState.Columns[State.s1.ToString()].SortMode = DataGridViewColumnSortMode.NotSortable;
            MatrixOfState.Columns[State.s2.ToString()].SortMode = DataGridViewColumnSortMode.NotSortable;
            MatrixOfState.Columns[State.s3.ToString()].SortMode = DataGridViewColumnSortMode.NotSortable;
            MatrixOfState.Columns[State.s4.ToString()].SortMode = DataGridViewColumnSortMode.NotSortable;
            MatrixOfState.Columns[State.s5.ToString()].SortMode = DataGridViewColumnSortMode.NotSortable;
            MatrixOfState.Columns[State.s6.ToString()].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void Count_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton btn = (RadioButton)sender;
            if(btn.Checked == true)
            {
                MatrixOfState.DataSource = this.dt[Convert.ToInt32(btn.Tag)];
            }
        }
    }
}
