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
            int var19 = 100;
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


        }
    }
}
