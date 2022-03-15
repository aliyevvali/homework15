using System;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Daragin max gulle tutumunu yazin(ancaq reqem) :");
            int bulletcapacityofcomb = Int32.Parse(Console.ReadLine());
            Console.Write("Daragda olan gulle sayini daxil edin(ancaq reqem) :");
            int bulletcountincomb = Int32.Parse(Console.ReadLine());
            Console.Write("Daragin doshalma vaxtini qeyd edin(ancaq reqem) :");
            double timeofdischargeofcomb = double.Parse(Console.ReadLine());
            Console.Write("Silahin modunu secin true - auto, false - single(ancaq true,false))");
            bool autoorsingle = bool.Parse(Console.ReadLine());
            Console.Write("-------------------------------------------");

            Weapon weapon = new Weapon(bulletcapacityofcomb,bulletcountincomb,timeofdischargeofcomb, autoorsingle);
             

            string choice = "0";
            while (choice != "6")
            {
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("1 - Shoot methodu  2 - Fire methodu  3 -GetRemainBulletCount methodu  4 - Reload  5 - ChangeFireMode  6 - Proqrami dayandirmaq ucun");

                
                 Console.Write("Reqem daxil edin : ");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        weapon.Shoot();
                        break;
                    case "2":
                        weapon.Fire();
                        break;
                    case "3":
                        weapon.GetRemainBulletCount();
                        int bullet = weapon.GetRemainBulletCount();
                        if (bullet == -1) Console.WriteLine("daragin max tutumundan cox gulle sayi ola bilmez");
                        else Console.WriteLine("Daragin tam dolmasi ucun lazim olan gulle sayi :" + bullet);   
                        
                        break;
                    case "4":
                        weapon.Reload();
                        break;
                    case "5":
                        weapon.ChangeFireMode();
                        break;
                    case "6":
                        Console.WriteLine("Program darayndirildi......");
                        break;
                    case "0":
                        weapon.Info();
                        break;
                       
                    default:
                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine("1,2,3,4,5,6,0 Reqemlerinden istifade edin");
                        break;
                }
            }

        }
    }
}

