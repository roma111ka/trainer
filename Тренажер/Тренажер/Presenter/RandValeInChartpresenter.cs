using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Тренажер.Model;
using Тренажер.Veiw;

namespace Тренажер.Presenter
{
    public class RandValeInChartpresenter
    {
        IRandValeInChart randValueInChart;
        public RandValeInChartpresenter(IRandValeInChart servise)
        {
            randValueInChart = servise;
        }
        public void TempRand()
        {
            RandModel value = new RandModel();
            value.TempValue =randValueInChart.Temp;
            value.typeOfphis = randValueInChart.typeOfPhis;
            randValueInChart.Temp = value.TempRand();
        }
        public void FreqRand()
        {
            RandModel value = new RandModel();
            value.FreqValue = randValueInChart.Freq;
            value.typeOfphis = randValueInChart.typeOfPhis;
            randValueInChart.Freq = value.FreqRand();
        }
        public void CondactRand()
        {
            RandModel value = new RandModel();
            value.CondactValue = randValueInChart.Condatct;
            value.typeOfphis = randValueInChart.typeOfPhis;
            randValueInChart.Condatct = value.CondactRand();
        }
        public void HumdRand()
        {
            RandModel value = new RandModel();
            value.HumdValue = randValueInChart.Humd;
            value.typeOfphis = randValueInChart.typeOfPhis;
            randValueInChart.Humd = value.HumdRand();
        }
        public void PresureRand()
        {
            RandModel value = new RandModel();
            value.PresureValue = randValueInChart.Presure;
            value.typeOfphis = randValueInChart.typeOfPhis;
            randValueInChart.Presure = value.PresureRand();
        }
    }
}
