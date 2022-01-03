using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Тренажер.Presenter;
using Тренажер.Veiw;

namespace Тренажер
{
    public partial class sessionViewForm : Form, IRandValeInChart
    {
        public Dto Dto;
        public DtoPatient DtoPatient;

        int TempValue;
        int PresureValue;
        int CondactValue;
        int HumdValue;
        int FreqValue;


        private int _countSeconds = 0;
        int limitPresure = 200;
        public sessionViewForm()
        {
            InitializeComponent();
        }
      
        int IRandValeInChart.Temp { get { return TempValue; } set { TempValue = value; } }
        int IRandValeInChart.Presure { get { return PresureValue; } set { PresureValue = value; } }
        int IRandValeInChart.Condatct { get { return CondactValue; } set { CondactValue = value; } }
        int IRandValeInChart.Humd { get { return HumdValue; } set { HumdValue = value; } }
        int IRandValeInChart.Freq { get { return FreqValue; } set { FreqValue = value; } }
        int IRandValeInChart.typeOfPhis { get { return typeOfPhisNumber(); }  }

        int typeOfPhisNumber()
        {
          
            if (Dto.cheked=="бег")
            {
                return 1;
            }
            if (Dto.cheked == "ходьба")
            {
                return 2;
            }
            if (Dto.cheked == "вело")
            {
                return 3;
            }
            if (Dto.cheked == "силовые упражнения")
            {
                return 4;
            }
             return 1;
        }
        private void endExaminition_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm MainForm = new MainForm();
            MainForm.Show();
        }

        private void sessionViewForm_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            
            chartPresure.ChartAreas[0].AxisY.Minimum = 100;
            chartPresure.ChartAreas[0].AxisY.Maximum = 190;
            chartPresure.ChartAreas[0].AxisX.LabelStyle.Format = "mm.ss";
            chartPresure.Series[0].XValueType = ChartValueType.DateTime;
            chartPresure.ChartAreas[0].AxisX.Minimum = DateTime.Now.ToOADate();
            chartPresure.ChartAreas[0].AxisX.Maximum = DateTime.Now.AddMinutes(1).ToOADate();
            chartPresure.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
            chartPresure.ChartAreas[0].AxisX.Interval = 10;

            chartFreq.ChartAreas[0].AxisY.Minimum = 60;
            chartFreq.ChartAreas[0].AxisY.Maximum = 180;
            chartFreq.ChartAreas[0].AxisX.LabelStyle.Format = "mm.ss";
            chartFreq.Series[0].XValueType = ChartValueType.DateTime;
            chartFreq.ChartAreas[0].AxisX.Minimum = DateTime.Now.ToOADate();
            chartFreq.ChartAreas[0].AxisX.Maximum = DateTime.Now.AddMinutes(1).ToOADate();
            chartFreq.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
            chartFreq.ChartAreas[0].AxisX.Interval = 10;

            chartTemp.ChartAreas[0].AxisY.Minimum = 36.0;
            chartTemp.ChartAreas[0].AxisY.Maximum = 37.5;
            chartTemp.ChartAreas[0].AxisX.LabelStyle.Format = "mm.ss";
            chartTemp.Series[0].XValueType = ChartValueType.DateTime;
            chartTemp.ChartAreas[0].AxisX.Minimum = DateTime.Now.ToOADate();
            chartTemp.ChartAreas[0].AxisX.Maximum = DateTime.Now.AddMinutes(1).ToOADate();
            chartTemp.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
            chartTemp.ChartAreas[0].AxisX.Interval = 10;

            chartHumd.ChartAreas[0].AxisY.Minimum = 0;
            chartHumd.ChartAreas[0].AxisY.Maximum = 100;
            chartHumd.ChartAreas[0].AxisX.LabelStyle.Format = "mm.ss";
            chartHumd.Series[0].XValueType = ChartValueType.DateTime;
            chartHumd.ChartAreas[0].AxisX.Minimum = DateTime.Now.ToOADate();
            chartHumd.ChartAreas[0].AxisX.Maximum = DateTime.Now.AddMinutes(1).ToOADate();
            chartHumd.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
            chartHumd.ChartAreas[0].AxisX.Interval = 10;

            chartCondact.ChartAreas[0].AxisY.Minimum = 0;
            chartCondact.ChartAreas[0].AxisY.Maximum = 30;
            chartCondact.ChartAreas[0].AxisX.LabelStyle.Format = "mm.ss";
            chartCondact.Series[0].XValueType = ChartValueType.DateTime;
            chartCondact.ChartAreas[0].AxisX.Minimum = DateTime.Now.ToOADate();
            chartCondact.ChartAreas[0].AxisX.Maximum = DateTime.Now.AddMinutes(1).ToOADate();
            chartCondact.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
            chartCondact.ChartAreas[0].AxisX.Interval = 10;



            if (this.Dto != null)
            {

                dataBoxInSeesion.Text = Dto.dateTime;
                typeBoxInSeesion.Text = Dto.cheked;
                patientBoxInSeesion.Text = DtoPatient.surname +" "+ DtoPatient.name + " " + DtoPatient.dadname;
                ageBoxInSeesion.Text = DtoPatient.age;
                sexBoxInSeesion.Text = DtoPatient.sex;

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime timeNow = DateTime.Now;


            RandValeInChartpresenter presenter = new RandValeInChartpresenter(this);
            if (Dto.IndexItems[0] == true)
            {
                presenter.PresureRand();
                chartPresure.Series[0].Points.AddXY(timeNow, PresureValue);

            }
            if (Dto.IndexItems[1] == true)
            {
                presenter.TempRand();
                chartTemp.Series[0].Points.AddXY(timeNow, TempValue);

            }
            if (Dto.IndexItems[2] == true)
            {
                presenter.HumdRand();
                chartHumd.Series[0].Points.AddXY(timeNow, HumdValue);

            }
            if (Dto.IndexItems[3] == true)
            {
                presenter.CondactRand();
                chartCondact.Series[0].Points.AddXY(timeNow, CondactValue);


            }
            if (Dto.IndexItems[4] == true)
            {
                presenter.FreqRand();
                chartFreq.Series[0].Points.AddXY(timeNow, FreqValue);


            }
            

           

           
            


            _countSeconds++;
            if (_countSeconds == 30)
            {
                _countSeconds = 0;
                chartPresure.ChartAreas[0].AxisY.Minimum = 100;
                chartPresure.ChartAreas[0].AxisY.Maximum = 190;
                chartPresure.ChartAreas[0].AxisX.LabelStyle.Format = "mm.ss";
                chartPresure.Series[0].XValueType = ChartValueType.DateTime;
                chartPresure.ChartAreas[0].AxisX.Minimum = DateTime.Now.ToOADate();
                chartPresure.ChartAreas[0].AxisX.Maximum = DateTime.Now.AddMinutes(1).ToOADate();
                chartPresure.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
                chartPresure.ChartAreas[0].AxisX.Interval = 10;

                chartFreq.ChartAreas[0].AxisY.Minimum = 60;
                chartFreq.ChartAreas[0].AxisY.Maximum = 180;
                chartFreq.ChartAreas[0].AxisX.LabelStyle.Format = "mm.ss";
                chartFreq.Series[0].XValueType = ChartValueType.DateTime;
                chartFreq.ChartAreas[0].AxisX.Minimum = DateTime.Now.ToOADate();
                chartFreq.ChartAreas[0].AxisX.Maximum = DateTime.Now.AddMinutes(1).ToOADate();
                chartFreq.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
                chartFreq.ChartAreas[0].AxisX.Interval = 10;

                chartTemp.ChartAreas[0].AxisY.Minimum = 36.0;
                chartTemp.ChartAreas[0].AxisY.Maximum = 37.5;
                chartTemp.ChartAreas[0].AxisX.LabelStyle.Format = "mm.ss";
                chartTemp.Series[0].XValueType = ChartValueType.DateTime;
                chartTemp.ChartAreas[0].AxisX.Minimum = DateTime.Now.ToOADate();
                chartTemp.ChartAreas[0].AxisX.Maximum = DateTime.Now.AddMinutes(1).ToOADate();
                chartTemp.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
                chartTemp.ChartAreas[0].AxisX.Interval = 10;

                chartHumd.ChartAreas[0].AxisY.Minimum = 0;
                chartHumd.ChartAreas[0].AxisY.Maximum = 100;
                chartHumd.ChartAreas[0].AxisX.LabelStyle.Format = "mm.ss";
                chartHumd.Series[0].XValueType = ChartValueType.DateTime;
                chartHumd.ChartAreas[0].AxisX.Minimum = DateTime.Now.ToOADate();
                chartHumd.ChartAreas[0].AxisX.Maximum = DateTime.Now.AddMinutes(1).ToOADate();
                chartHumd.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
                chartHumd.ChartAreas[0].AxisX.Interval = 10;

                chartCondact.ChartAreas[0].AxisY.Minimum = 0;
                chartCondact.ChartAreas[0].AxisY.Maximum = 30;
                chartCondact.ChartAreas[0].AxisX.LabelStyle.Format = "mm.ss";
                chartCondact.Series[0].XValueType = ChartValueType.DateTime;
                chartCondact.ChartAreas[0].AxisX.Minimum = DateTime.Now.ToOADate();
                chartCondact.ChartAreas[0].AxisX.Maximum = DateTime.Now.AddMinutes(1).ToOADate();
                chartCondact.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
                chartCondact.ChartAreas[0].AxisX.Interval = 10;

            }
        }

        private void endExaminition_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Application.Exit();
        }
    }

}
