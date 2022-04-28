using System;
using System.Collections.Generic;
using System.Text;

namespace P324_Static_Extensions
{
    static class Extensions
    {
        //public void Test() static bir classin icerisinde static olmayan member ola bilmez
        //{

        //}

        public static void Add(this int a, int b,int c)
        {
            Console.WriteLine(a + b+c);
        }

        public static string toCapitalized(this string str)
        {
            str = str.ToLower().Trim();
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append(char.ToUpper(str[0]));
            stringBuilder.Append(str.Substring(1));

            return stringBuilder.ToString();
        }

        public static void checkPoint(this Student stu)
        {
            Console.WriteLine($"{(stu.Point >80 ? "Telebe imtahandan kecdi":"Telebe imtahandan kesildi")}");
        }


        public static void customContains(this string str,string search)
        {
            string[] strArr = str.Split();

            foreach (var item in strArr)
            {
                if(item == search)
                {
                    Console.WriteLine(item == search);
                }
            }
        }
    }
}
