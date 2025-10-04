using System;

namespace Array
{
    public class Program
    {

        public static void Main(String[] args)
        {
            #region -Array explanation-
            /*Array you can store multiple variables of the same type in an
            Array datta structure. you declare an array by specifying the
            type of its elements.

           * an array can be single-dimensional, multidimensional or jagged.

           * The number of dimensions and the lenght of each dimension are
            established when the array instance is creatted.

            *Arrays are zero indexed: an array with n elements is indexed 
            from 0 to n-1

            *Array elements can be of any type, including an array type. */
            #endregion

            #region -Array--
            /*   int[] numbers = new int[10]; //Array capacity of 10 slots for numbers

               int[] numbersWithInit = new int[]  { 1, 2, 3 }; // 3 slots can be modify

               //multidimensional
               int[][] multiNumbers = new int[3][]
               {
                    new int [3] {1,2,3},
                    new int [3] {4,5,6},
                    new int [3] {7,8,9}
               };
               //other way to declare array 
               int[,] otherNumbers = new int[2,2];

           }
            */

            #endregion

            #region --Array Sample--
                              //  0            1          2
        /*    var names = new[] { "jayson", "lorenz", "daril" };
            Console.WriteLine("Before update");
            foreach(var name in names)
            {
                Console.WriteLine(name);
            }
            names[0] = "test";
            Console.WriteLine("After update");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine($"name at index 2: {names [1]}");
        */
            //Multidimensional
            var rowsAndCells = new int[3][]
            {
                new [] {1,2, 3 },
                new [] {4, 5, 6 },
                new [] {7, 8, 9 },
            };
            for (var row =0; row < rowsAndCells.Length; row++)
            {
                Console.WriteLine($"row {row}");
                foreach(var cell in rowsAndCells[row])
                {
                    Console.WriteLine($"value {cell}");
                }
            }

            #endregion

            #region --Enumerable, Collection and List--

            var countries = new[] { "Philippines", "USA", "Canada", "Pakistan", "Afghanisttan" };
            IEnumerable<string> enumCountries = countries;
           // enumCountries[0] = "PHL"; - cannot edit because Ienumerable can view only
           foreach(var country in enumCountries)
            {
                Console.WriteLine(country);
            }

            //Collections
            ICollection<string> colCountries = new List<string>(countries);
            colCountries.Add("Australia");
            colCountries.Remove("USA");
            // colCountries[0] = "Sample";   -cannot use function this [] but can add remove


            //List
            var ListCountries = new List<string>(countries); // with initial value from array
            var ListInitCountries = new List<string>() // with initial value
            {
                "Philippines",
                "USA"
            };

            var ListCountriesNew = new List<string>();
            ListCountriesNew.Add("Philippines");
            ListCountriesNew.Add("USA");
            ListCountriesNew.AddRange(new[] { "Canada", "Australia" });
            ListCountriesNew.Remove("Philippines");
            ListCountriesNew[0] = "America"; //this function can used on LIST
            Console.WriteLine("List of Countries");
            for (var index = 0; index < ListCountriesNew.Count; index++) 
            {
                Console.WriteLine($"{index}:{ListCountriesNew[index]}");
            }
            #endregion
        }
    }
}
