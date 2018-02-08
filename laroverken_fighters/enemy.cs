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
        protected Random randomness = new Random();

        protected int hp;
        public int dmg;
        public string name;
        public bool isAlive = true;

        //Klassens konstruktor
        public Enemy()
        {
            Setup();
        }

              
        //Initialize, sätt värden på variablerna
        private void Setup()
        {

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


        public virtual void DecideAction()
        {

            if (randomness.Next(0, 10) >= 7) //Enemy heals if number is greater than X

            {
                int healAmount = randomness.Next(1, 3);
                Heal(healAmount);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(name + " healed for " + dmg);
            }
            else
            {
                //Enemy attacks
                dmg = randomness.Next(2, 7);
                Program.playerHP -= dmg; //TODO Remove this Program.playerHP, make system

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(name + " attacked for " + dmg);
            }
        }


        public virtual void TakeDamage(int _damage)
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
