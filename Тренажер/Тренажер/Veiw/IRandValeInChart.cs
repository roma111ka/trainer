using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тренажер.Veiw
{
    public interface IRandValeInChart
    {
        int typeOfPhis { get; }
        int Temp { get; set; }
        int Humd { get; set; }
        int Presure { get; set; }
        int Freq { get; set; }
        int Condatct { get; set; }
    }
}
