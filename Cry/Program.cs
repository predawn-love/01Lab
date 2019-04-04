using Gma.QrCodeNet.Encoding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cry
{
    class Program
    {
        static void Main(string[] args)
        {
            QrEncoder  IWannaCry = new QrEncoder();
            QrCode Crying = new QrCode();
            string intoEncode = String.Join(" ", args);
            if (args.Length > 4)
            {
                Console.WriteLine("请输入小于3个参数");
            }else if (args.Length<2)
            {
                Console.WriteLine("您没有输入任何参数");
            }
            else
            { 
                IWannaCry.TryEncode(intoEncode, out Crying);
                //Crying.Matrix[0,0];
                for (int aTemp = 0, i = Crying.Matrix.Height; i > 0 || aTemp < Crying.Matrix.Height; i--)
                {
                    for (int bTemp = 0, k = Crying.Matrix.Width; k > 0 || bTemp < Crying.Matrix.Width; k--)
                    {
                        if (Crying.Matrix[aTemp, bTemp] == true)
                        {
                            Console.Write("　");
                        }
                        else
                        {
                            Console.Write("■");
                        }
                        bTemp++;
                    }
                    Console.Write("\n");
                    aTemp++;
                }
            }
            Console.Read();
        }
    }
}
