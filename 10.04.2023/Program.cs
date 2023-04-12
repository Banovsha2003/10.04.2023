using Elasticsearch.Net;
using System;
using System.Collections.Generic;

namespace _10._04._2023
{
    public class Program
    {
        static void Main(string[] args)
        {
            ////Task:1
            Player Jennie = new Player()
            {
                Health = 100,
            };
            Player Taehyung = new Player()
            {
                Health = 500,
            };
            Enemy Jay = new Enemy()
            {
                Health = 250,
            };
            var result = CharacterHelper.CompareHealth<Character>(Jennie, Jay);
            Console.WriteLine(result);

            //         //Task:2
            //         Medkit medkit = new Medkit()
            //         {
            //             Value = 50;
            //     };

            //     Weapon weapon = new Weapon
            //     {
            //         Name = "Foo"
            //     };
            //     Weapon weapon1 = new Weapon
            //     {
            //         Name = "Foo"
            //     };

            //     List<IInventory> list = new List<IInventory>();
            //         list.Add(weapon);
            //         list.Add(medkit)
            //}
            //         Console.WriteLine(IsItemInInventory<IInventory>(list, weapon1));

            //     }
            // public static bool IsItemInInventory<T>(List<T> inventory,T item)
            // {
            //     return inventory.Contains(item);
            // }
            // }
        }
    }

    ////Task:1
    public class Character
    {
        public int Health { set; get; }
    }
    class Enemy : Character
    {

    }
    class Player : Character
    {

    }
    public static class CharacterHelper
    {
        public static int CompareHealth<T>(T character1, T character2) where T : Character
        {
            if (character1.Health == character2.Health)
            {
                return 0;
            }
            else if (character1.Health < character2.Health)
            {
                return -1;
            }
            else
            {
                return 1;
            }

        }
    }

    //Task:2


}
    
    

