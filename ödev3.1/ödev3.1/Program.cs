using System;

namespace ödev3._1
{
    class Program
    {
        static void Main(string[] args)
        {

            int askermiktar = 0, saymasayisi = 0;//kullanıcının gireceği değerleri tutmak için değişkenler oluşturduk.

            Console.WriteLine("Asker sayısını giriniz:");//kullanıcıdan değerleri aldık ve değişkenlere atadık.
            askermiktar = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("sayma sayısını giriniz:");
            saymasayisi = Convert.ToInt32(Console.ReadLine());


            int[] askerler = new int[askermiktar];//hesaplama içerisinde asker sayısı ve hayatta olup olmama durumlarını tutacağımız bir dizi oluşturduk
            int sonkontrol = askermiktar, askerkontrol = 0, adimkontrol = 1;

            for (int i = 0; i < askermiktar; i++) //programın başında tüm askerlerin yaşam durumunu 1 olarak atadık
            {
                askerler[i] = 1; //tüm dizi değerlerinin durumu bir atandı
            }

            while (sonkontrol != 2) //en son 2 asker hayatta kalıncaya kadar işlem yapacak döngüyü kurduk.
            {

                if (askerkontrol == askermiktar) { askerkontrol = 0; }//son askere gelindiği zaman döngü baştan başlayaacak

                if (askerler[askerkontrol] == 1)//sıradaki asker hayattamı değilmi
                {

                    if (adimkontrol % saymasayisi == 0)//askerler arasında sayma sayısı kadar ilerlendimi kontrol ettik
                    {
                        askerler[askerkontrol] = 0;//askerin yaşan durumu 0 atandı
                        sonkontrol--;
                        adimkontrol = 1;
                    }
                    else
                    {
                        adimkontrol++;
                        askerkontrol++;//asker hayatta deilse atladı ve sayma sayısını 1 artırdık
                    }

                }
                else
                {
                    askerkontrol++;//asker hayatta değilse sonrakine geçildi
                }

            }

            Console.WriteLine("Sona kalan asker numaraları:");//sona kalacak iki askerin sıra numaralarını yazdırdık.

            for (int k = 0; k < askermiktar; k++)
            {
                if (askerler[k] == 1)
                {
                    Console.WriteLine(k + 1);
                }
            }

            Console.ReadKey();
        }
    }
}
