using System;

namespace Task_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player("Max", 100, 50, 23);

            player.ShowDataPlayer();
        }
    }

    class Player
    {
        public string Name;
        public int Health;
        public int Armor;
        public int Damage;

        public Player(string name, int health, int armor, int damage)
        {
            Name = name;
            Health = health;
            Armor = armor;
            Damage = damage;
        }

        public void ShowDataPlayer()
        {
            Console.WriteLine($"Имя игрока: {Name}\nЗдоровье игрока: {Health}\nБроня игрока: {Armor}\nУрон Игрока: {Damage}");
        }
    }
}
