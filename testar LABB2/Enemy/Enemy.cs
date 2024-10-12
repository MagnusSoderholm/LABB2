

using LABB2.LevelElement;
using System.Diagnostics.Metrics;

namespace LABB2.Enemy

{
    public abstract class Enemy : LevelElement.LevelElement
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public Dice AttackDice { get; set; }
        public Dice DefenceDice { get; set; }
        public bool IsAlive = true;
        public bool ShouldDraw = true;




        public bool IsMovingTowardsPlayer { get; set; }





        public Enemy(string name, int health, char symbol, ConsoleColor color)
        {
            Name = name;
            Health = health;
            Symbol = symbol;
            Color = color;
        }
        public abstract void Update(Player player, LevelData levelData);









public void MoveTowards(Player player)
        {
            // Exempel på förflyttning, kolla om fienden flyttar sig närmare spelaren
            if (DistanceTo(player) > 1)
            {
                // Rör dig mot spelaren
                IsMovingTowardsPlayer = true;  // Fienden rör sig mot spelaren
                                               // Kod för förflyttning...
            }
            else
            {
                IsMovingTowardsPlayer = false; // Fienden står kvar
            }
        }

        // Hjälpmetod för att beräkna avståndet till spelaren
        public int DistanceTo(Player player)
        {
            // Returnera avståndet mellan fienden och spelaren (t.ex. Manhattan-avstånd)
            return Math.Abs(this.X - player.X) + Math.Abs(this.Y - player.Y);
        }
    }









}









