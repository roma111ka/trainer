using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Тренажер.Model
{
    public class RandModel
    {
        
        public int TempValue { get; set; }
        public int CondactValue { get; set; }
        public int FreqValue{ get; set; }
        public int PresureValue{ get; set; }
        public int HumdValue{ get; set; }

        public int typeOfphis { get; set; }
        

        public int TempRand()
        {
            Thread.Sleep(15);
            Random random = new Random();
            if (typeOfphis == 1)
            {

                if (DtoCountsForRand.countTemp >= 5)
                {
                    TempValue = random.Next(368 + DtoRecountForRand.recountTemp, 370 + DtoRecountForRand.recountTemp);
                    DtoRecountForRand.recountTemp -= 1;
                    if (DtoRecountForRand.recountTemp <= -5)
                    {
                        DtoCountsForRand.countTemp = 0;
                    }
                }
                if (DtoCountsForRand.countTemp < 5)
                {
                    TempValue = random.Next(364 + DtoCountsForRand.countTemp, 366 + DtoCountsForRand.countTemp);
                    DtoCountsForRand.countTemp += 1;
                    if (DtoCountsForRand.countTemp >= 5)
                    {
                        DtoRecountForRand.recountTemp = 0;
                    }
                }



                TempValue /= 10;
            }
            if (typeOfphis == 2)
            {
                
                   TempValue = random.Next(366 , 368);
                   TempValue /= 10;
            }
            if (typeOfphis == 3)
            {
                if (DtoCountsForRand.countTemp >= 6)
                {
                    TempValue = random.Next(370 + DtoRecountForRand.recountTemp, 372 + DtoRecountForRand.recountTemp);
                    DtoRecountForRand.recountTemp -= 1;
                    if (DtoRecountForRand.recountTemp <= -9)
                    {
                        DtoCountsForRand.countTemp = 0;
                    }
                }
                if (DtoCountsForRand.countTemp < 6)
                {
                    TempValue = random.Next(364 + DtoCountsForRand.countTemp, 366 + DtoCountsForRand.countTemp);
                    DtoCountsForRand.countTemp += 1;
                    if (DtoCountsForRand.countTemp >= 17)
                    {
                        DtoRecountForRand.recountTemp = 0;
                    }


                    
                }
                TempValue /= 10;
            }
            if (typeOfphis == 4)
            {
                if (DtoCountsForRand.countTemp >= 6)
                {
                    TempValue = random.Next(370 + DtoRecountForRand.recountTemp, 372 + DtoRecountForRand.recountTemp);
                    DtoRecountForRand.recountTemp -= 1;
                    if (DtoRecountForRand.recountTemp <= -6)
                    {
                        DtoCountsForRand.countTemp = 0;
                    }
                }
                if (DtoCountsForRand.countTemp <6)
                {
                    TempValue = random.Next(364 + DtoCountsForRand.countTemp, 366 + DtoCountsForRand.countTemp);
                    DtoCountsForRand.countTemp += 1;
                    if (DtoCountsForRand.countTemp >= 6)
                    {
                        DtoRecountForRand.recountTemp = 0;
                    }



                }
                TempValue /= 10;
            }
            return TempValue;
        }
        public int FreqRand()
        {
            Thread.Sleep(15);
            Random random = new Random();

            if (typeOfphis == 1)
            {

                if (DtoCountsForRand.countFreq >= 60)
                {
                    FreqValue = random.Next(140 + DtoRecountForRand.recountFreq, 145 + DtoRecountForRand.recountFreq);
                    DtoRecountForRand.recountFreq -= 2;
                    if (DtoRecountForRand.recountFreq <= -60)
                    {
                        DtoCountsForRand.countFreq = 0;
                    }
                }
                if (DtoCountsForRand.countFreq < 60)
                {
                    FreqValue = random.Next(80 + DtoCountsForRand.countFreq, 85 + DtoCountsForRand.countFreq);
                    DtoCountsForRand.countFreq += 5;
                    if (DtoCountsForRand.countFreq >= 60)
                    {
                        DtoRecountForRand.recountFreq = 0;
                    }
                }




            }
            if (typeOfphis == 2)
            {
                if (DtoCountsForRand.countFreq >= 40)
                {
                    FreqValue = random.Next(100 + DtoRecountForRand.recountFreq, 105 + DtoRecountForRand.recountFreq);
                    DtoRecountForRand.recountFreq -= 2;
                    if (DtoRecountForRand.recountFreq <= -40)
                    {
                        DtoCountsForRand.countFreq = 0;
                    }
                }
                if (DtoCountsForRand.countFreq < 40)
                {
                    FreqValue = random.Next(60 + DtoCountsForRand.countFreq, 65 + DtoCountsForRand.countFreq);
                    DtoCountsForRand.countFreq += 5;
                    if (DtoCountsForRand.countFreq >= 40)
                    {
                        DtoRecountForRand.recountFreq = 0;
                    }
                }
            }
            if (typeOfphis == 3)
            {
                if (DtoCountsForRand.countFreq >= 80)
                {
                    FreqValue = random.Next(180 + DtoRecountForRand.recountFreq, 185 + DtoRecountForRand.recountFreq);
                    DtoRecountForRand.recountFreq -= 2;
                    if (DtoRecountForRand.recountFreq <= -80)
                    {
                        DtoCountsForRand.countFreq = 0;
                    }
                }
                if (DtoCountsForRand.countPresure < 80)
                {
                    FreqValue = random.Next(100 + DtoCountsForRand.countFreq, 105 + DtoCountsForRand.countFreq);
                    DtoCountsForRand.countFreq += 5;
                    if (DtoCountsForRand.countFreq >= 80)
                    {
                        DtoRecountForRand.recountFreq = 0;
                    }
                }
            }
            if (typeOfphis == 4)
            {
                if (DtoCountsForRand.countFreq >= 80)
                {
                    FreqValue = random.Next(200 + DtoRecountForRand.recountFreq, 205 + DtoRecountForRand.recountFreq);
                    DtoRecountForRand.recountFreq -= 2;
                    if (DtoRecountForRand.recountFreq <= -80)
                    {
                        DtoCountsForRand.countFreq = 0;
                    }
                }
                if (DtoCountsForRand.countFreq < 80)
                {
                    FreqValue = random.Next(120 + DtoCountsForRand.countFreq, 125 + DtoCountsForRand.countFreq);
                    DtoCountsForRand.countFreq += 5;
                    if (DtoCountsForRand.countFreq >= 80)
                    {
                        DtoRecountForRand.recountFreq = 0;
                    }
                }
            }
            return FreqValue;
        }
        public int CondactRand()
        {
            Thread.Sleep(15);
            Random random = new Random();
            if (typeOfphis == 1)
            {

                if (DtoCountsForRand.countCondact >= 17)
                {
                    CondactValue = random.Next(22 + DtoRecountForRand.recountCondact, 25 + DtoRecountForRand.recountCondact);
                    DtoRecountForRand.recountCondact -= 2;
                    if (DtoRecountForRand.recountCondact <= -17)
                    {
                        DtoCountsForRand.countCondact = 0;
                    }
                }
                if (DtoCountsForRand.countCondact < 17)
                {
                    CondactValue = random.Next(5 + DtoCountsForRand.countCondact, 8 + DtoCountsForRand.countCondact);
                    DtoCountsForRand.countHumd += 4;
                    if (DtoCountsForRand.countCondact >= 17)
                    {
                        DtoRecountForRand.recountCondact = 0;
                    }
                }


            }
            if (typeOfphis == 2)
            {

                if (DtoCountsForRand.countCondact >= 10)
                {
                    CondactValue = random.Next(15 + DtoRecountForRand.recountCondact, 17 + DtoRecountForRand.recountCondact);
                    DtoRecountForRand.recountCondact -= 10;
                    if (DtoRecountForRand.recountCondact <= -9)
                    {
                        DtoCountsForRand.countCondact = 0;
                    }
                }
                if (DtoCountsForRand.countCondact < 10)
                {
                    CondactValue = random.Next(5 + DtoCountsForRand.countCondact, 8 + DtoCountsForRand.countCondact);
                    DtoCountsForRand.countHumd += 3;
                    if (DtoCountsForRand.countCondact >= 10)
                    {
                        DtoRecountForRand.recountCondact = 0;
                    }
                }
            }
            if (typeOfphis == 3)
            {

                if (DtoCountsForRand.countCondact >= 25)
                {
                    CondactValue = random.Next(30 + DtoRecountForRand.recountCondact, 35 + DtoRecountForRand.recountCondact);
                    DtoRecountForRand.recountCondact -= 2;
                    if (DtoRecountForRand.recountCondact <= -25)
                    {
                        DtoCountsForRand.countCondact = 0;
                    }
                }
                if (DtoCountsForRand.countCondact < 25)
                {
                    CondactValue = random.Next(5 + DtoCountsForRand.countCondact, 8 + DtoCountsForRand.countCondact);
                    DtoCountsForRand.countHumd += 4;
                    if (DtoCountsForRand.countCondact >= 25)
                    {
                        DtoRecountForRand.recountCondact = 0;
                    }
                }
            }
            if (typeOfphis == 4)
            {
                if (DtoCountsForRand.countCondact >= 34)
                {
                    CondactValue = random.Next(40 + DtoRecountForRand.recountCondact, 45 + DtoRecountForRand.recountCondact);
                    DtoRecountForRand.recountCondact -= 2;
                    if (DtoRecountForRand.recountCondact <= -34)
                    {
                        DtoCountsForRand.countCondact = 0;
                    }
                }
                if (DtoCountsForRand.countCondact < 34)
                {
                    CondactValue = random.Next(5 + DtoCountsForRand.countCondact, 8 + DtoCountsForRand.countCondact);
                    DtoCountsForRand.countHumd += 5;
                    if (DtoCountsForRand.countCondact >= 34)
                    {
                        DtoRecountForRand.recountCondact = 0;
                    }
                }
            }

            
            return CondactValue;
        }
        public int HumdRand()
        {
            Thread.Sleep(15);
            Random random = new Random();
            if (typeOfphis == 1)
            {

                if (DtoCountsForRand.countHumd >= 39)
                {
                    HumdValue = random.Next(40 + DtoRecountForRand.recountHumd, 44 + DtoRecountForRand.recountHumd);
                    DtoRecountForRand.recountHumd -= 2;
                    if (DtoRecountForRand.recountHumd <= -39)
                    {
                        DtoCountsForRand.countHumd = 0;
                    }
                }
                if (DtoCountsForRand.countHumd < 39)
                {
                    HumdValue = random.Next(12 + DtoCountsForRand.countHumd, 16 + DtoCountsForRand.countHumd);
                    DtoCountsForRand.countHumd += 3;
                    if (DtoCountsForRand.countHumd >= 39)
                    {
                        DtoRecountForRand.recountHumd = 0;
                    }
                }


            }
            if (typeOfphis == 2)
            {

                if (DtoCountsForRand.countHumd >= 9)
                {
                    HumdValue = random.Next(20 + DtoRecountForRand.recountHumd, 24 + DtoRecountForRand.recountHumd);
                    DtoRecountForRand.recountHumd -= 2;
                    if (DtoRecountForRand.recountHumd <= -9)
                    {
                        DtoCountsForRand.countHumd = 0;
                    }
                }
                if (DtoCountsForRand.countHumd <9 )
                {
                    HumdValue = random.Next(12 + DtoCountsForRand.countHumd, 16 + DtoCountsForRand.countHumd);
                    DtoCountsForRand.countHumd += 3;
                    if (DtoCountsForRand.countHumd >= 9)
                    {
                        DtoRecountForRand.recountHumd = 0;
                    }
                }
            }
            if (typeOfphis == 3)
            {

                if (DtoCountsForRand.countHumd >= 20)
                {
                    HumdValue = random.Next(50 + DtoRecountForRand.recountHumd, 54 + DtoRecountForRand.recountHumd);
                    DtoRecountForRand.recountHumd -= 2;
                    if (DtoRecountForRand.recountHumd <= -20)
                    {
                        DtoCountsForRand.countHumd = 0;
                    }
                }
                if (DtoCountsForRand.countHumd < 20)
                {
                    HumdValue = random.Next(20 + DtoCountsForRand.countHumd, 24 + DtoCountsForRand.countHumd);
                    DtoCountsForRand.countHumd += 3;
                    if (DtoCountsForRand.countHumd >= 20)
                    {
                        DtoRecountForRand.recountHumd = 0;
                    }
                }
            }
            if (typeOfphis == 4)
            {
                if (DtoCountsForRand.countHumd >= 20)
                {
                    HumdValue = random.Next(60 + DtoRecountForRand.recountHumd, 64 + DtoRecountForRand.recountHumd);
                    DtoRecountForRand.recountHumd -= 2;
                    if (DtoRecountForRand.recountHumd <= -20)
                    {
                        DtoCountsForRand.countHumd = 0;
                    }
                }
                if (DtoCountsForRand.countHumd < 20)
                {
                    HumdValue = random.Next(30 + DtoCountsForRand.countHumd, 34 + DtoCountsForRand.countHumd);
                    DtoCountsForRand.countHumd += 3;
                    if (DtoCountsForRand.countHumd >= 20)
                    {
                        DtoRecountForRand.recountHumd = 0;
                    }
                }
            }
           
            return HumdValue;
        }
        public int PresureRand()
        {
            Thread.Sleep(15);
            Random random = new Random();

            
            if (typeOfphis==1)
            {
                
                if (DtoCountsForRand.countPresure >= 19 )
                {
                    PresureValue = random.Next(140 + DtoRecountForRand.recountPresure, 145 + DtoRecountForRand.recountPresure);
                    DtoRecountForRand.recountPresure -= 4;
                    if (DtoRecountForRand.recountPresure <= -19)
                    {
                        DtoCountsForRand.countPresure = 0;
                    }
                }
                 if (DtoCountsForRand.countPresure < 19 )
                {
                    PresureValue = random.Next(120 + DtoCountsForRand.countPresure, 125 + DtoCountsForRand.countPresure);
                    DtoCountsForRand.countPresure += 5;
                    if (DtoCountsForRand.countPresure >= 19)
                    {
                        DtoRecountForRand.recountPresure = 0;
                    }
                }
               



            }
            if (typeOfphis == 2)
            {
             
               
                    PresureValue = random.Next(120 , 125);
                
            }
            if (typeOfphis == 3)
            {
                if (DtoCountsForRand.countPresure >= 29)
                {
                    PresureValue = random.Next(150 + DtoRecountForRand.recountPresure, 155 + DtoRecountForRand.recountPresure);
                    DtoRecountForRand.recountPresure -= 3;
                    if (DtoRecountForRand.recountPresure <= -29)
                    {
                        DtoCountsForRand.countPresure = 0;
                    }
                }
                if (DtoCountsForRand.countPresure < 29)
                {
                    PresureValue = random.Next(120 + DtoCountsForRand.countPresure, 125 + DtoCountsForRand.countPresure);
                    DtoCountsForRand.countPresure += 5;
                    if (DtoCountsForRand.countPresure >= 29)
                    {
                        DtoRecountForRand.recountPresure = 0;
                    }
                }
            }
            if (typeOfphis == 4)
            {
                if (DtoCountsForRand.countPresure >=40)
                {
                    PresureValue = random.Next(160 + DtoRecountForRand.recountPresure, 165 + DtoRecountForRand.recountPresure);
                    DtoRecountForRand.recountPresure -= 3;
                    if (DtoRecountForRand.recountPresure <= -40)
                    {
                        DtoCountsForRand.countPresure = 0;
                    }
                }
                if (DtoCountsForRand.countPresure < 40)
                {
                    PresureValue = random.Next(120 + DtoCountsForRand.countPresure, 125 + DtoCountsForRand.countPresure);
                    DtoCountsForRand.countPresure += 5;
                    if (DtoCountsForRand.countPresure >= 40)
                    {
                        DtoRecountForRand.recountPresure = 0;
                    }
                }
            }

            return PresureValue;
        }
    }
}
