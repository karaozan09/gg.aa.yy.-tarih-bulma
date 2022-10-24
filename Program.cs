using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haftaucdördüncükısım
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String tarih;
            Console.WriteLine("gg.aa.yy. olacak şekilde tarih bilgisi giriniz");
            tarih = Console.ReadLine();
            String[] tarih_deger = tarih.Split('.');
            switch (tarih_deger[0])
            {
                case "01": Console.WriteLine("Ocak"); break;
                case "02": Console.WriteLine("şubat"); break;
                case "03": Console.WriteLine("Mart"); break;
                case "04": Console.WriteLine("nisan"); break;
                case "05": Console.WriteLine("mayıs"); break;
                case "06": Console.WriteLine("haziran"); break;
                case "07": Console.WriteLine("temmuz"); break;
                case "08": Console.WriteLine("ağustos"); break;
                case "09": Console.WriteLine("eylül"); break;
                case "10": Console.WriteLine("ekim"); break;
                case "11": Console.WriteLine("kasım"); break;
                case "12": Console.WriteLine("aralık"); break;
               default : Console.WriteLine("öyle bir ay yok");break;

            }
            Console.ReadLine();
        }
    }
}
