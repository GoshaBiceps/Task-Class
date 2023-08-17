using System;

namespace Task_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player("Max", 100, 50, 23);

            player.ShowData();
        }
    }

    class Player
    {
        private string Name;
        private int Health;
        private int Armor;
        private int Damage;

        public Player(string name, int health, int armor, int damage)
        {
            Name = name;
            Health = health;
            Armor = armor;
            Damage = damage;
        }

        public void ShowData()
        {
            Console.WriteLine($"Имя игрока: {Name}\nЗдоровье игрока: {Health}\nБроня игрока: {Armor}\nУрон Игрока: {Damage}");
        }
    }
}
