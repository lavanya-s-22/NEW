using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARPEXAMPLES
{
    public class examples
    {
        public static string btoh (byte[] data)
        {
            if(!(data==null))
            {
                StringBuilder sb = new StringBuilder();
                for(int i=0;i<=data.Length;i++)
                {
                    sb.Append(data[i].ToString("x2"));
                }
                return sb.ToString();
            }
            else
            {
                return null;
            }

            /*int num;
            Console.WriteLine("enter a number:");
            num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {

                Console.WriteLine("the no is even");
            }
            else
            {
                Console.WriteLine("the no is odd");
            }
            */
            



        }
    }
}
