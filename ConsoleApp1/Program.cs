using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = -1;
            int guess = 55;

            //產生亂數
            guess = new Random().Next(100);
            Console.WriteLine("請輸入一個數字(0-100):");

            while (true)  //game loop 
            {
                //決定輸入內容
                string input_str = Console.ReadLine();  //input  string 
                input = int.Parse(input_str);

                //離開條件 
                if (input == guess)
                {
                    Console.WriteLine("恭喜你答對了!");
                    break;
                }
                //提示
                Console.WriteLine("猜錯了，再來一次！");
            }

            Console.WriteLine("PAUSE");
            Console.ReadKey();
        }

        /*      static void Main(string[] args)
              {
                  Random random = new Random(DateTime.Now.Millisecond);
                  for (int i = 0; i < 20; i++)
                  {                
                      int randomNum = random.Next(99)+99;  
                      Console.WriteLine($"第{i}次結果={randomNum}");
                  }




                // for times = 3
                /*for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine(i);
                }

                // while timer = 3
                int count = 0;
                while (true)
                { 
                    if (count >= 3)
                    {
                        break;
                    }
                    Console.WriteLine(count);
                    count++;
                }*/



        /*            Console.WriteLine("開始");
                    for (int i = 0; i < 10; i++)
                    {
                        if (i == 6)
                        {
                            continue;//break;
                        }
                        Console.WriteLine(i);
                    }
        Console.WriteLine("結束");
                    Console.ReadKey();
    }*/
    }
}
