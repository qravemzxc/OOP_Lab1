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
            bool var1 = true;
            byte var2 = 1;
            sbyte var3 = 2;
            char var4 = 'a';
            decimal var5 = 10.9M;
            double var6 = 1.2d;
            float var7 = 1.3f;
            int var8 = 10;
            uint var9 = uint.MaxValue;
            long var10 = 100000;
            ulong var11 = 1000000;
            short var12 = 10;
            ushort var13 = 100;
            Console.WriteLine(var1);
            Console.WriteLine(var2);
            Console.WriteLine(var3);
            Console.WriteLine(var4);
            Console.WriteLine(var5);
            Console.WriteLine(var6);
            Console.WriteLine(var7);
            Console.WriteLine(var8);
            Console.WriteLine(var9);
            Console.WriteLine(var10);
            Console.WriteLine(var11);
            Console.WriteLine(var12);
            Console.WriteLine(var13);


            ushort var14 = var2;
            ushort var15 = var2;
            short var16 = var3;
            short var17 = var3;
            int var18 = var2;
            int var19 =100;
            byte var20 = (byte)(var19 + var8);
            byte var21 = (byte)(var14 + var15);
            sbyte var22 = (sbyte)(var16 + var12);
            int var23 = (int)(var19 + var10);
            byte var24 = (byte)(var17 + var12);
            int var25 = Convert.ToInt32(var6);


            object obj = var8;
            int var26 = (int)obj;


            var str = "Hello World";
            Console.WriteLine(str.GetType());

            int? num = null;
            Console.WriteLine(num);
            num = 5;
            Console.WriteLine(num);

            /* var chek = false;
            chek = 400;*/


            string message1 = "hello";
            string message2 = "bonjour";
            string message3 = "How are you?";
            Console.WriteLine($"{message1 == message2}");
            
            Console.WriteLine($"{string.Concat(message1,message2,message3)}-сцепление");
            Console.WriteLine($"{string.Copy(message3)}-копирование");
            Console.WriteLine($"{message3.Substring(0, 7)}-выделение подстроки");
            string[] words=message3.Split(' ');
            foreach (var word in words)
            {
                Console.Write(words);
            }
            Console.WriteLine($"\n{message1.Insert(0,"everybody")}-вставка");
            Console.WriteLine($"{message3.Remove(0, 3)}-удаление");
      

            string str1 = null;
            string str2 = string.Empty;
            Console.WriteLine(string.IsNullOrEmpty(str1));
            Console.WriteLine(string.IsNullOrEmpty(str2));


            StringBuilder sb = new StringBuilder("How are you");
            Console.WriteLine(sb);
            sb.Insert(0, "!");
            sb.AppendFormat("?");
            sb.Remove(1, 3);
            sb.Remove(2, 4);    
            Console.WriteLine(sb);


            int[,] numbers = { { 1, 2, 3 }, { 4, 5, 6 } };
            int rows = numbers.GetUpperBound(0) + 1;
            int columns = numbers.GetUpperBound(1)+1;
            for(int i=0; i < rows; i++)
            {
                for(int j=0; j < columns; j++)
                {
                    Console.Write($"{numbers[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            string[] mas = { "Sunday", "Monday", "Tuersday","Wednesday", "Thirsday", "Friday", "Saturday" };
            for(int i=0; i < mas.Length; i++)
            {
                Console.Write($"{mas[i]}\t");
            }
            Console.WriteLine();
            Console.WriteLine($"Длина массива:{mas.Length}\n");
            Console.Write("Введите позицию:");
            int userPos =int.Parse(Console.ReadLine());
            Console.Write("Введите значение элемента:");
            int userInt = int.Parse(Console.ReadLine());
            string tmp = mas[userPos];
            mas[userPos] = mas[userInt];
            mas[userInt] = tmp;
            for (int i=0; i < mas.Length; i++)
            {
                Console.Write($"{mas[i]}\t");
            }
            Console.WriteLine();
            Console.WriteLine();


            float[][] jaggArr=new float[3][];
            jaggArr[0] = new float[2];
            jaggArr[1] = new float[3];
            jaggArr[2] = new float[4];
            for (int i = 0; i < 2; i++)
            {
                jaggArr[0][i]= i;
                Console.Write($"{jaggArr[0][i]}\t");
            }
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                jaggArr[1][i] = i;
                Console.Write($"{jaggArr[1][i]}\t");
            }
            Console.WriteLine();
            for (int i = 0; i < 4; i++)
            {
                jaggArr[2][i] = i;
                Console.Write($"{jaggArr[2][i]}\t");
            }
            Console.WriteLine();
            Console.WriteLine();


            var Arr=new object[0];
            var Str = " ";


            (int , string , char , string , ulong ) tuple = (1, "hello", 'a', "world", 10000);
            Console.WriteLine(tuple);
            Console.WriteLine(tuple.Item1);
            Console.WriteLine(tuple.Item3);
            Console.WriteLine(tuple.Item4);


            Console.WriteLine("\n" + "Распаковка кортежа");
            var (a_1, b_1, c_1, d_1, e_1) = tuple;
            Console.WriteLine(a_1);
            Console.WriteLine(b_1);
            Console.WriteLine(c_1);
            Console.WriteLine(d_1);
            Console.WriteLine(e_1);
            Console.WriteLine("\n" + "Использование переменной(_)");
            var (f_1, _, _, j_1, _) = tuple;
            Console.WriteLine(f_1);
            Console.WriteLine(j_1);


            var firstTuple=Tuple.Create(3,9);
            var secondTuple = Tuple.Create(9, 3);
            Console.WriteLine(firstTuple==secondTuple);

            string strVar = "qweqwe";
            int[] arrVar = { 1, 2, 3 };
            (int,int,int,char) func(int[]arVar,string stVar)
            {
                int maxArrElement = arVar.Max();
                int minArrElement = arVar.Min();
                int sumArrElement = arVar.Sum();
                char firstLetter = stVar[0];
                return (maxArrElement, minArrElement, sumArrElement,firstLetter);
            }
            func(arrVar, strVar);


            void CheckedFunc()
            {
                checked
                {
                    int Max = int.MaxValue;
                    Console.WriteLine(Max);
                }
            }


            void Unchecked()
            {
                unchecked
                {
                    int Max = int.MaxValue;
                    Console.WriteLine(Max);
                }
            }
            CheckedFunc();
            Unchecked();
            Console.ReadKey();


        }
    }
}
