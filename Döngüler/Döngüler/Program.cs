using System.ComponentModel.Design;

namespace Döngüler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FOR DÖNGÜSÜ");

            //[Başlangıç değeri] ; [Karşılaştırma Değeri];[Arttırma - Azaltma Değeri]
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine((i+1) + " Azra");

            }

            for (double i = 0; i < 1; i+=0.1)
            {
                //Console.WriteLine(Math.Round(i,2));

                i = Math.Round(i,2);
                Console.WriteLine(i);
            }

            double sayi = 1.123623;
            sayi = Math.Round(sayi,3);
            Console.WriteLine(sayi);

            //5 tane * yazdırmak için

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("*");
            }

            //1xfor tek forla çalıştırdığımız yapı
            for(int i = 0;i < 5; i++)
            {
                Console.Write("*\n");
            }

            //2xfor iki forla çalıştırdığımız yapı amacımız bunu yazdırmak:
            //*****
            //*****
            //*****
            //*****
            //satır ve sütun yazdırmak istiyorsak:

            //iç içe döngüler varsa içerdeki döngü bitmeden üstteki döngüye çıkılmaz.
            for(int i = 0; i < 5; i++) //satır
            {
                for (int j = 0; j < 5; j++) //sütun
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }

            //*
            //**
            //***
            //****
            //*****
            for (int i = 0; i < 5; i++) //satır
            {
                for (int j = 0; j < 1+i; j++) //sütun j <= i şeklinde de yazılabilir
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }

            Console.WriteLine("\n ----------------");
            //*****
            //****
            //***
            //**
            //*

            for (int i = 4; i >= 0; i--)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n ----------------");

            //3xfor or 2xfor
            //*****
            //-****
            //--***
            //---**
            //----*
            for (int i = 0; i < 5; i++)
            {
                for(int k = 0;k < i; k++)
                { 
                    Console.Write("-");
                }

                for (int j = 0; j < 5 - i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }

            Console.WriteLine("\n ----------------");

            //----*
            //---**
            //--***
            //-****
            //*****
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(j<i ? " ": "*");
                }
                Console.WriteLine();

            }

            //yukardakini iki for döngüsü içine yazdırmak için:
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(j < 4 - i ? "-" : "*"); //ya da i + 1 < j ? "-" : "*"
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n ----------------");

            //3xfor or 2x for ile yaz
            //*********
            // *******
            //  *****
            //   ***
            //    *

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0;  j < 9 ; j++)
                {
                    Console.Write(j - 1 < i ? " " : "*"); 

                }
                Console.WriteLine();
            }


            for (int i = 0; i < 5; i++)
            {
                // Boşluk
                for (int k = 0; k < i; k++)
                {
                    Console.Write(" ");
                }

                // Yıldız
                for (int j = 0; j < 9 - (i*2); j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }


            for (int i = 0; i < 5; i++)
            {
                for (int k = 4 -i; k < 0; k++)
                {
                    Console.Write(" ");

                }

                for (int j = 0; j < 1 + i*2; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }







        }
    }
}