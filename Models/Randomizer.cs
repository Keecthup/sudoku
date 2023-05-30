using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sudoku.Models
{
    public static class Randomizer
    {
        private static Random random = new Random();

        public static int[] Shuffle(this int[] collection)
        {
            var array = collection.ToArray();
            var newArray = new int[array.Length];
            var index = array.Length - 1;
            while (index != -1)
            {
                var position = random.Next(array.Length);
                if (newArray[position] != 0)
                    continue;
                newArray[position] = array[index];
                index--;
            }
            return newArray;
        }
    }
}
