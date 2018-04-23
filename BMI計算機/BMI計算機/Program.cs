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

            //更改背景為藍色和字體為黃色
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Yellow;

            //讓使用者輸入身高
            Console.Write("請輸入身高(公尺):");
            string tall = Console.ReadLine();

            //讓使用者輸入體重
            Console.Write("請輸入體重(公斤):");
            string KG = Console.ReadLine();

            //宣告一個變數
            double BMI;

            //計算BMI質並顯示
            BMI = double.Parse(KG) / (double.Parse(tall) * double.Parse(tall));
            Console.WriteLine("您的BMI值為:" + BMI);

            //判斷BMI質是否過重、過輕或正常
            if (BMI < 16)
            {
                Console.WriteLine("您的體重過輕!!!");
            }

            else if (BMI > 25)
            {
                Console.WriteLine("您的體重過重!!!");
            }

            else
            {
                Console.WriteLine("您的體重為標準值!!!");
            }

            //判斷BMI質是否需要服兵役
            if (BMI < 16.5 || BMI > 31.5)
            {
                Console.WriteLine("您不需要服兵役!!");
            }
            else
            {
                Console.WriteLine("您需要服兵役!!");
            }
            Console.Read();


        }
    }
}
