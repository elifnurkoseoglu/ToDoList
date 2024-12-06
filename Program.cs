using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("To do List programına hoşgeldiniz!");
            List<string> taskList = new List<string>();
            string option = "";

            while (option != "e")
            {
                Console.WriteLine(new string('-', 30));
                Console.WriteLine("Ne yapmak istersiniz?");
                Console.WriteLine("1: Görev ekle");
                Console.WriteLine("2: Görev kaldır");
                Console.WriteLine("3: Listeyi görüntüle");
                Console.WriteLine("e: Çıkış");
                Console.WriteLine(new string('-', 30));
                option = Console.ReadLine();

                if (option == "1")
                {
                    Console.WriteLine("Lütfen listeye eklenecek görevi girin.");
                    string task = Console.ReadLine();
                    taskList.Add(task);
                    Console.WriteLine("Görev başarıyla listeye eklendi.");
                }

                else if (option == "2")
                {
                    if (taskList.Count > 0)
                    {
                        for (int i = 0; i < taskList.Count; i++)
                        {
                            Console.WriteLine(i + " : " + taskList[i]);
                        }
                        Console.WriteLine(" Lutfen kaldırmak istediginiz görevin numarasını giriniz.");
                        int taskNumber;
                        if (int.TryParse(Console.ReadLine(), out taskNumber) && taskNumber >= 00 && taskNumber < taskList.Count)
                        {
                            taskList.RemoveAt(taskNumber);
                            Console.WriteLine("Görev başarıyla kaldırıldı.");
                        }
                        else
                        {
                            Console.WriteLine("Geçersiz görev numarası girdiniz.");
                        }

                    }
                    else
                    {
                        Console.WriteLine("Liste boş, silinecek görev yok.");
                    }
                }

                else if (option == "3")
                {
                    if (taskList.Count > 0)
                    {
                        Console.WriteLine("Yapılacaklar listesindeki görevler: ");
                        for (int i = 0; i < taskList.Count; i++)
                        {
                            Console.WriteLine(i + ": " + taskList[i]);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Liste boş, görüntülenecek görev yok.");
                    }
                }

                else if (option == "e")
                {
                    Console.WriteLine("Programdan çıkılıyor...");
                }
                else
                {
                    Console.WriteLine("Lütfen gecerli bir deger girin.");
                }
            }

            Console.WriteLine("Uygulamayı kullandıgınız için tesekkür ederiz.");
        }
    }
}
