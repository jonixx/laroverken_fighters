using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laroverken_fighters
{
    //En class funkar som en beskrivning av någonting
    //Här beskriver vi hur en fiende fungerar och
    //vilka egenskaper den har
    class Enemy
    {
        int hp;
        public int dmg;
        public string name;
        public bool isAlive = true;
              
        //Initialize, sätt värden på variablerna
        public void Setup()
        {
            Random randomness = new Random();

            hp = randomness.Next(6, 15);
            dmg = randomness.Next(2, 6);

            string[] namesToPick =
            {
                "String Danne", //0
                "Last King", //1
                "Gunnar", //2
                "CSN", //3
                "Skolverket" //4
                
            };

            name = namesToPick[randomness.Next(0, namesToPick.Length)];

        }//End of void Setup

        public void TakeDamage(int _damage)
        {
            hp -= _damage;

            if (hp < 0)
            {
                isAlive = false;
            }
        }

        public void Heal(int _healAmount)
        {
            hp += _healAmount;
        }

        public void DisplayInfo()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(name + "'s HP:" + hp);
        }

    }//End of class
}
