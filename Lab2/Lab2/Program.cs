using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Archer robin = new Archer(1, "Robin", 0, 0, 50f);
            Archer marian = new Archer(2, "Marian", 5, 5, 45f);
            Fort fort = new Fort(3, "Fort Knox", 10, 10, true);
            MobileHome house = new MobileHome(4, "Caravan", 2, 2, true);

            // Полиморфизм: атакуем через интерфейс
            IAttacker[] attackers = new IAttacker[] { robin, fort };
            foreach (IAttacker attacker in attackers)
            {
                attacker.Attack(marian);
                Console.WriteLine(marian.GetName() + ": HP = " + marian.GetHp() + ", alive = " + marian.IsAlive());
            }

            // Ещё одна атака, чтобы юнит умер
            robin.Attack(marian);
            Console.WriteLine(marian.GetName() + ": HP = " + marian.GetHp() + ", alive = " + marian.IsAlive());

            // Полиморфизм: двигаем через интерфейс
            IMoveable[] movers = new IMoveable[] { robin, house };
            foreach (IMoveable mover in movers)
            {
                mover.MoveTo(7, 7);
            }

            Console.WriteLine(robin.GetName() + ": (" + robin.GetX() + ", " + robin.GetY() + ")");
            Console.WriteLine(house.GetName() + ": (" + house.GetX() + ", " + house.GetY() + ")");
            Console.WriteLine(house.GetName() + " built: " + house.IsBuilt());
        }
    }
}