﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadData
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string sonuc = "";
            int toplam = 0, a = 0, b = 0;

            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }

            if (args.Length > 0)
            {
                for (int i = 0; i < args.Length; i++)
                {
                    if (i == 0)
                    {
                        a = Convert.ToInt32(args[i]);
                    }
                    else if (i == 2)
                    {
                        b = int.Parse(args[i]);
                    }
                    if (args[1] == "+")                 
                        toplam = (a+b);
                    else if (args[1] == "-")
                        toplam = (a-b);
                    else if(args[1] == "*")
                        toplam = (a*b);
                    else if(args[1] == "/")
                        toplam = (a/b);  
                    else
                        Console.WriteLine("Yanlış Operatör");
                    
                    
                }

                Console.WriteLine("Sonuç: " + toplam);
                Console.ReadLine();
            }
        }
    }
}
