using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralsConverter
{
    class ConvertFunctions
    {
        public int donustur(string s1)
        {
            int sayi;

            switch (s1)
            {
                case "M": sayi = 1000; break;
                case "D": sayi = 500; break;
                case "C": sayi = 100; break;
                case "L": sayi = 50; break;
                case "X": sayi = 10; break;
                case "V": sayi = 5; break;
                case "I": sayi = 1; break;
                default: sayi = 0; break;
            }

            return sayi;
        }

        public int normaleCevir(string s)
        {
            int sonuc = 0;
            s += "0";
            for (int i = 0; i < s.Length - 1; i++)
            {
                if (donustur(s.Substring(i, 1)) < donustur(s.Substring(i + 1, 1)))
                {
                    sonuc += donustur(s.Substring(i + 1, 1)) - donustur(s.Substring(i, 1));
                    i++;
                }
                else
                {
                    sonuc += donustur(s.Substring(i, 1));
                }

            }
            return sonuc;
        }

        public string romayaCevir(int normalSayi)
        {
            string sonuc = null;

            if (normalSayi > 0 && normalSayi < 4000)
            {
                //Verilen bir tamsayıyı roma rakamına çeviren fonksiyon.

                int binlerBasamagi, yuzlerBasamagi, onlarBasamagi, birlerBasamagi;   //abcd;
                binlerBasamagi = normalSayi / 1000;
                yuzlerBasamagi = (normalSayi / 100) % 10;
                onlarBasamagi = (normalSayi % 100) / 10;
                birlerBasamagi = normalSayi % 10;


                switch (binlerBasamagi)
                {
                    case 1: sonuc += 'M'; break;
                    case 2: sonuc += 'M'; sonuc += 'M'; break;
                    case 3: sonuc += 'M'; sonuc += 'M'; sonuc += 'M'; break;
                    default: break;
                }

                switch (yuzlerBasamagi)
                {
                    case 1: sonuc += 'C'; break;
                    case 2: sonuc += 'C'; sonuc += 'C'; break;
                    case 3: sonuc += 'C'; sonuc += 'C'; sonuc += 'C'; break;
                    case 4: sonuc += 'C'; sonuc += 'D'; break;
                    case 5: sonuc += 'D'; /*s = s % 100;*/ break;
                    case 6: sonuc += 'D'; sonuc += 'C'; break;
                    case 7: sonuc += 'D'; sonuc += 'C'; sonuc += 'C'; break;
                    case 8: sonuc += 'D'; sonuc += 'C'; sonuc += 'C'; sonuc += 'C'; break;
                    case 9: sonuc += 'C'; sonuc += 'M'; break;
                    default: break;
                }

                switch (onlarBasamagi)
                {
                    case 1: sonuc += 'X'; break;
                    case 2: sonuc += 'X'; sonuc += 'X'; break;
                    case 3: sonuc += 'X'; sonuc += 'X'; sonuc += 'X'; break;
                    case 4: sonuc += 'X'; sonuc += 'L'; break;
                    case 5: sonuc += 'L'; break;
                    case 6: sonuc += 'L'; sonuc += 'X'; break;
                    case 7: sonuc += 'L'; sonuc += 'X'; sonuc += 'X'; break;
                    case 8: sonuc += 'L'; sonuc += 'X'; sonuc += 'X'; sonuc += 'X'; break;
                    case 9: sonuc += 'X'; sonuc += 'C'; break;
                    default: break;
                }

                switch (birlerBasamagi)
                {
                    case 1: sonuc += 'I'; break;
                    case 2: sonuc += 'I'; sonuc += 'I'; break;
                    case 3: sonuc += 'I'; sonuc += 'I'; sonuc += 'I'; break;
                    case 4: sonuc += 'I'; sonuc += 'V'; break;
                    case 5: sonuc += 'V'; break;
                    case 6: sonuc += 'V'; sonuc += 'I'; break;
                    case 7: sonuc += 'V'; sonuc += 'I'; sonuc += 'I'; break;
                    case 8: sonuc += 'V'; sonuc += 'I'; sonuc += 'I'; sonuc += 'I'; break;
                    case 9: sonuc += 'I'; sonuc += 'X'; break;
                    default: break;
                }

            }

            else
            {

            }

            return sonuc;
        }

        public int ikiliyeCevir(string paramS)
        {
            //Kontrol ederek ikiliye çevirir.
            int controlSayisi = 0;
            string controlString = null;

            controlSayisi = normaleCevir(paramS);
            controlString = romayaCevir(controlSayisi);

            bool kontrol = String.Equals(paramS, controlString);

            if (kontrol)
            {

            }

            else
            {
                controlSayisi = -1;
            }

            return controlSayisi;
        }
    }
}
