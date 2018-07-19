using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEdukasi
{
    class Program
    {
        static void Main(string[] args)
        {
            string jawaban, jawaban1;
            Console.WriteLine("           -Welcome To Education Game EPS 1 : Nama Ibukota-");
            Console.WriteLine("             By : Galih Putra Windawan For : SD Kelas 1-3");
            Console.WriteLine("=======================================================================");
            Console.WriteLine("Jawab Pertanyaan Berikut Dengan Benar!");
            Console.WriteLine();

            Console.WriteLine("Apakah nama dari ibukota Negara Indonesia ?");
            jawaban = Console.ReadLine();
            jawaban1 = jawaban.ToLower();
            if (jawaban1 == "jakarta")
            {
                Console.WriteLine();
                Console.WriteLine("Apakah nama dari ibukota Negara Jepang ?");
                jawaban = Console.ReadLine();
                jawaban1 = jawaban.ToLower();
                if (jawaban1 == "tokyo")
                {
                    Console.WriteLine();
                    Console.WriteLine("Apakah nama dari ibukota Negara Malaysia ?");
                    jawaban = Console.ReadLine();
                    jawaban1 = jawaban.ToLower();
                    if (jawaban1 == "kuala lumpur")
                    {
                        Console.WriteLine();
                        Console.WriteLine("Apakah nama dari ibukota Negara Inggris ?");
                        jawaban = Console.ReadLine();
                        jawaban1 = jawaban.ToLower();
                        if (jawaban1 == "london")
                        {
                            Console.WriteLine();
                            Console.WriteLine("Apakah nama dari ibukota Negara German ?");
                            jawaban = Console.ReadLine();
                            jawaban1 = jawaban.ToLower();
                            if (jawaban1 == "berlin")
                            {
                                Console.WriteLine();
                                Console.WriteLine("Selamat Semua Jawaban Anda Benar!!");
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("Jawaban Anda Salah");
                            }
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Jawaban Anda Salah");
                        }
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Jawaban Anda Salah");
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Jawaban Anda Salah");
                }

            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Jawaban Anda Salah");
            }

            Console.ReadKey();
        }
    }
}
