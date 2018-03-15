using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI計算機
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("請輸入身高(公尺):");
            string tall = Console.ReadLine();
            Console.Write("請輸入體重(公斤):");
            string KG = Console.ReadLine();
            double BMI;

            BMI = double.Parse(KG) / (double.Parse(tall) * double.Parse(tall));
            Console.WriteLine("您的BMI值為:" + BMI);
            Console.Read();
           

        }
    }
}
