using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkGladiator
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Battle
    {


        public Battle()
        {

        }

        public 
    }

    class Magician
    {
        private int _health = 100;
        
        public string Name { get; private set; }
        public int Health => _health;

        public Magician()
        {
            SetName();
        }

        public void SetName()
        {
            Console.WriteLine("Вы представитель магической гильдии! Назовите своё имя!");
            Name = Console.ReadLine();
        }


    }

    class Warrior
    {
        private string _name = "";
        private int _health = 100;

        public Warrior()
        {

        }
    }
}
