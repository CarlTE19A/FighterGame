using System;
using System.Numerics;

namespace FighterSim
{
    static public class Weapons
    {
        public static string[] weaponNames = new string[]
        {
            "Korvsvärdet",
            "Yxan av Klyvning",
            "Mördarvapnet",
            "Ardas Revenge",
            "Pistolen",
            "Mickes Dator",
            "Karens Telefon"
        };
        
        public static Vector2[] weaponsDamage = new Vector2[]
        {
            new Vector2(5, 10),
            new Vector2(20, 40),
            new Vector2(15, 35),
            new Vector2(0, 100),
            new Vector2(20, 30),
            new Vector2(10, 20),
            new Vector2(0, 1)
        };
    }
}