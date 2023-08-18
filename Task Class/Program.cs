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
        private string _name;
        private int _health;
        private int _armor;
        private int _damage;

        public Player(string name, int health, int armor, int damage)
        {
            _name = name;
            _health = health;
            _armor = armor;
            _damage = damage;
        }

        public void ShowData()
        {
            Console.WriteLine($"Имя игрока: {_name}\nЗдоровье игрока: {_health}\nБроня игрока: {_armor}\nУрон Игрока: {_damage}");
        }
    }
}
