using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCRUD
{
    class Program
    {
        static void Main(string[] args)
        {
            // add, remove,clear,count
            List<string> db = new List<string>();

            void Instructions()
            {
               
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("1. Melumat daxil et"); // Create
                Console.WriteLine("2. Melumatlari goster"); // Read
                Console.WriteLine("3. Melumati yenile"); // Update
                Console.WriteLine("4. Melumati sil"); // Delete
                Console.WriteLine("-----------------------------------");
                Console.Write("Istediyiniz emrin nomresini daxil edin: ");
                var emrNomresi = Convert.ToInt32(Console.ReadLine());


                switch (emrNomresi)
                {
                    case 1:
                        Create();
                        break;

                    case 2:
                        Read();
                        break;

                    case 3:
                        Update();
                        break;

                    case 4:
                        Delete();
                        break;

                    default:
                        Console.WriteLine("Sehv komanda secmisiniz");
                        Instructions();
                        break;

                }
            }
            void Create()
            {
                Console.WriteLine("-----------------------------------");
                Console.Write("Melumat daxil edin:");
                var data = Console.ReadLine();
                db.Add(data);
                
                Instructions();
                
            }

            void Read()
            {
                Console.WriteLine("-----------------------------------");
                var count = 0;
                foreach (var data in db)
                {
                    count++;
                    Console.WriteLine(count+"-"+data);
                }

                Instructions();
            }

            void Update()
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Update Data");

                Instructions();
            }

            void Delete()
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Delete Data");

                Instructions();
            }

            Instructions();
        }
    }
}
