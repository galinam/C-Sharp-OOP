using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart1
{
    class GSMCallHistoryTest
    {
        public static void TestGSMClasses()
        {
            GSM[] gsms = new GSM[1];
            for (uint i = 0; i < gsms.Length; i++)
            {
                gsms[i] = new GSM($"Model-{i + 1}", $"Proizvoditel-{i + 1}", (30 + (i + 1) * 10), $"MyOwner{i + 1}",
                    new Battery("mod", 24, 8, Battery.BatteryType.LiIon), new Display(5, 225));

                Console.WriteLine(gsms[i]);
                Console.WriteLine();

                for (uint j = 0; j < 5; j++)
                {
                    gsms[i].AddCall(new Call("2017/11/25", "23:55:25", "0888 333 066", 35 + j));

                    Console.WriteLine(gsms[i].CallHistory[(int)j]);
                    Console.WriteLine();
                }
                Console.WriteLine(new String('-', 80));

                //gsms[i].ClearCallHistory();
                //Console.WriteLine("Number of calls: " + gsms[i].CallHistory.Count);

                //for (int k = 1; k < 5; k+=2)
                //{
                //    gsms[i].DeleteCall(gsms[i].CallHistory[k]);
                //}

                //Console.WriteLine(new String('-', 80));
                //Console.WriteLine(new String('-', 80));
                //foreach (var call in gsms[i].CallHistory)
                //{
                //    Console.WriteLine(call);
                //}

                Console.WriteLine(gsms[i].TotalPriceOfCalls());
                Console.WriteLine(gsms[i].TPofCallsWithoutLongestCall());
            }

            Console.WriteLine();
            Console.WriteLine(GSM.IPhone4S);
        }
    }
}
