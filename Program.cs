using System;

namespace ATM_Projem  
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int loop = 3;
            double purse = 0.0;
            int dön = 3;


            while (loop > 0)
            {   
                // KULLANICIDAN BİLGİLERİ ALMA
                Console.Write("Kullanıcı Adınızı Giriniz : ");
                string username = Console.ReadLine();  
                Console.Write("Şifrenizi Girin : ");
                string password = Console.ReadLine();

                //BİLGİLERİN DOĞRULUĞUNU TEYİDİ
                if (username == "samet" && password == "123")
                {
                    Console.WriteLine("=========================================");
                    Console.WriteLine("Giriş Başarılı !");

                    while (dön > 0)
                    {
                        //İŞLEMLER
                        Console.WriteLine("1 -> Para Yatır");
                        Console.WriteLine("2 -> Para Çek");
                        Console.WriteLine("3 -> Hesap Bilgileri");
                        Console.WriteLine("4 -> Çıkış Yap");
                        Console.WriteLine("");
                        Console.Write("Yapmak İstediğiniz işlem türünü seçin (1-4): ");
                        string process = Console.ReadLine();
                        
                        

                        // İŞLEMLER VE OLACAKLAR
                        if (process == "1")//İŞLEM 1
                        {
                            Console.WriteLine("--------------------------------------------");
                            Console.Write("Yatırılacak tutarı girin : ");
                            double invested = Convert.ToDouble(Console.ReadLine());
                            purse += invested;
                            Console.WriteLine($"{invested} TL para yatırıldı.");
                            Console.WriteLine("--------------------------------------------");
                        }
                        else if (process == "2") //İŞLEM 2
                        {
                            Console.WriteLine("--------------------------------------------");
                            Console.Write("Çekilecek Tutarı giriniz : ");
                            double pull = Convert.ToDouble(Console.ReadLine());


                            if (pull > purse)
                            {
                                Console.WriteLine("-----------------------------------------");
                                Console.WriteLine("bakiyenizden Fazla bir miktar girdiniz ");
                                Console.WriteLine("Tekrar Deneyin !");
                                Console.WriteLine("-----------------------------------------");
                            }
                            else
                            {
                                purse -= pull;
                                Console.WriteLine($"{pull} TL para Çekildi.");
                                Console.WriteLine("--------------------------------------------");
                            }


                        }
                        else if (process == "3")//İŞLEM 3
                        {
                            Console.WriteLine("====================");
                            Console.WriteLine($"Bakiyeniz : {purse}");
                            Console.WriteLine("====================");
                        }
                        else if (process == "4")//İŞLEM 4
                        {
                            Console.WriteLine("=========================================");
                            Console.WriteLine("Çıkış yapıldı Tekrar bekleriz. ");
                            break;
                        }
                    }



                    break;
                }
                else
                {
                    Console.WriteLine("=========================================");
                    loop--;
                    if (loop == 0)
                    {
                        Console.WriteLine("||-------------------------------------------------||");
                        Console.WriteLine("||Hesap Bloke Olmuştur. Banka İle İletişime Geçin !||");
                        Console.WriteLine("||-------------------------------------------------||");
                        break;
                    }

                    Console.WriteLine("Tekrar Deneyin");
                    Console.WriteLine($"Kalan Hak : {loop}");

                }

            }
        }
    }
}
