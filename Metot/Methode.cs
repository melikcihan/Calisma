using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Metot
{
    public class Methode
    {
        class Ornek
        {

            public int YuksekDeger(int num1, int num2)
            {

                int result;

                if (num1 > num2)
                    result = num1;
                else
                    result = num2;

                return result;
            }


            public int DusukDeger(int num1, int num2)
            {
                int result;

                if (num1 > num2)
                    result = num1;
                else
                    result = num2;

                return result;
            }

            public int Toplam(int num1, int num2)
            {
                return num1 += num2;
            }
            public int Cıkarma(int num1, int num2)
            {

                return num1 -= num2;
            }
            public int Carpma(int num1,int num2)
            {
                return num1 * num2;
            }
            public int Bolme(int num1,int num2)
            {
                return num1 / num2;
            }
            public string Hata()
            {
                return "Dosyalar Eksik";
            }
            public string Basarılı()
            {
                return "Dosya Aktarımı Başarılı";
            }

        }
    }
}