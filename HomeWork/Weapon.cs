using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    class Weapon
    {
        public int bulletCapacityOfComb;
        public int bulletCountInComb;
        public double timeOfDischargeOfComb;
        public bool autoOrSingle;


        public Weapon(int bulletCapacityOfComb, int bulletCountInComb, double timeOfDischargeOfComb, bool autoOrSingle)
        {
            this.bulletCapacityOfComb = bulletCapacityOfComb; this.bulletCountInComb = bulletCountInComb; this.timeOfDischargeOfComb = timeOfDischargeOfComb; this.autoOrSingle = autoOrSingle;
           
        }
        public void Info()
        {
            Console.WriteLine("Daragin max tutumu :"+bulletCapacityOfComb);
            Console.WriteLine("Daragin icinde olan gulle sayi :"+bulletCountInComb);
            Console.WriteLine("Daragin boshalma vaxti :"+timeOfDischargeOfComb+" san");
            Console.WriteLine("Silahin atish rejmi (auto) :"+autoOrSingle);
        }
        public void Shoot()
        {
            if (bulletCapacityOfComb>=bulletCountInComb)
            {
                if (bulletCountInComb == 0) Console.WriteLine("silahda gulle yoxdur :(");
                else bulletCountInComb -= 1; Console.WriteLine("silahdan bir gulle atildi---->");
            }
            else
            {
                Console.WriteLine("daragin max tutumundan cox gulle sayi ola bilmez");
            }
            
                        
        }
        public void Fire()
        {
            if (bulletCapacityOfComb >= bulletCountInComb)
            {
                if (bulletCountInComb == 0) Console.WriteLine("Silahda gulle yoxdur:(");
                else
                {
                    double firetime = bulletCountInComb * timeOfDischargeOfComb / bulletCapacityOfComb;
                    Console.WriteLine(firetime + "san");
                }
            }
            else
            {
                Console.WriteLine("daragin max tutumundan cox gulle sayi ola bilmez");
            }

        }
        public int GetRemainBulletCount()
        {

            if (bulletCapacityOfComb>bulletCountInComb) return bulletCapacityOfComb - bulletCountInComb;           
            else return -1;
        }
        public void Reload()
        {
            if (bulletCapacityOfComb>bulletCountInComb)
            {
                int needbullet = bulletCapacityOfComb - bulletCountInComb;
                bulletCountInComb = bulletCountInComb + needbullet;
                Console.WriteLine("Daraga elave olunan gulle sayi  :" + needbullet + "eded");
            }
            else if (bulletCapacityOfComb == bulletCountInComb)
            {
                Console.WriteLine("Darag doludur");
            }

        }
        public void ChangeFireMode()
        {
            if (bulletCapacityOfComb>=bulletCountInComb)
            {
                Console.WriteLine("(True auto mod)(False single mod)");
                bool secim = bool.Parse(Console.ReadLine());
                if (secim == true)
                {
                    autoOrSingle = true;
                }
                else if (secim == false)
                {
                    autoOrSingle = false;
                }
                else
                {
                    Console.WriteLine("True ve ya False'den istifade edin");
                }
            }
            else
            {
                Console.WriteLine("daragin max tutumundan cox gulle sayi ola bilmez");
            }
        }

    }
}
