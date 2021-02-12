using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace araba_bilgileri
{
    class Program
    {
        static void Main(string[] args)
        {
            double fiyat = 0;
            int sure = 0, arac = 0;
            Console.WriteLine("------Araç Tipleri------");
            Console.WriteLine(" 1- Taksi\n 2- Otobüs\n 3- Ticari Araç\n 4-kamyon");
            Console.Write("Lütfen Araç Tipini Giriniz : ");
            arac = int.Parse(Console.ReadLine());
            Console.Write("Kalınan Süreyi Giriniz : ");
            sure = int.Parse(Console.ReadLine());
            if (sure > 1)
            {
                for (int i = 1; i <= sure; i++)
                {
                    if (i == 1)
                    {
                        if (arac == 1)
                        {
                            fiyat = i * 5;
                        }
                        else if (arac == 2)
                        {
                            fiyat = i * 6;
                        }
                        else if (arac == 3)
                        {
                            fiyat = i * 6.5;
                        }

                        }
                        else if (arac == 4)
                        {
                            fiyat = i * 10;
                    
                    }
                    else
                    {

                        sure -= 1;
                        if (arac == 1)
                        {
                            fiyat += sure * 5 * 1.20;
                        }
                        else if (arac == 2)
                        {
                            fiyat += sure * 6 * 1.215;
                        }
                        else if (arac == 3)
                        {
                            fiyat += sure * 6.5 * 1.25;
                        }
                    }
                }

            }

            else
            {

                if (arac == 1)
                {
                    fiyat = sure * 5;
                }
                else if (arac == 2)
                {
                    fiyat = sure * 6;
                }
                else if (arac == 3)
                {
                    fiyat = sure * 6.5;
                }

            }
            Console.WriteLine("Ödenecek Tutar : {0} TL", fiyat);
            Console.ReadKey();
        }
    }
}
