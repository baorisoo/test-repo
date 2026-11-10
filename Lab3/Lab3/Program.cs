using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using Lab3;

namespace Lab2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Mp3Player myPlayer = Mp3Player.Instance;
            Mp3Player myPlayer2 = Mp3Player.Instance;
            Console.WriteLine(myPlayer.BgColor);
            myPlayer2.BgColor = "Black"; //меняем свойство у myPlayer2, и у
            //myPlayer выводится тоже новое значение,
            //тк переменные ссылаются на один объект.
            //Mp3Player свойство, возвращающее ссылку на объект класса
            Console.WriteLine(myPlayer.BgColor);
        }
    }
}