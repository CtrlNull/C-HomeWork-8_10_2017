using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections; // Add for ArrayList // think of this as a folder // was replaced with systems.collections.generic; for the new version of List and Dictionary
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            // arrays[]; only store one data type but lets you have multiple items
            //              0,  1,  2,  3,    4,   5, 6
            int[] ages = { 27, 28, 29, 30, 100000, 2, 8 }; //<---Array  dataType[]ArrayName={items/values}; 
            //Console.WriteLine(ages[5]);// arrayName[Position];<---  should call 100000
            ages[3] = 100; // arrayName[position #]; <--- this is how you change the array
                           // does not let you add or remove items from the array// in javescript you can

            string[] colors = { "red", "blue", "purple", "green" };

            int[] ages1; // array name
            ages1 = new int[] { 27, 28, 34, 42 }; // arrayName = new dataType[] {values,...,...,ect.};
            int[] ages3 = new int[5]; // creates empty array with 5 values
            ages3[0] = 27;
            ages3[1] = 16;

            //2 dimension arrays
            // first student
            int[,] scores = new int[5, 3]; // dataType[,] ArrayName = new dataType[5,3]; 5 students 3 subjects
                                           //first student

            scores[0, 0] = 10; // student 1, subject 1 
            scores[0, 1] = 12; // student 1, subject 2  
            scores[0, 2] = 15; // student 1, subject 3
            //second student
            scores[2, 0] = 12; // student 2, subject 1
            scores[2, 1] = 10; // student 2, subject 2
            scores[2, 2] = 8;  // student 2, subject 3
            // third student
            scores[3, 0] = 10; // student 3, subject 1 
            scores[3, 1] = 12; // student 3, subject 2  
            scores[3, 2] = 15; // student 3, subject 3
            // fourth student
            scores[4, 0] = 12; // student 4, subject 1
            scores[4, 1] = 10; // student 4, subject 2
            scores[4, 2] = 8;  // student 4, subject 3
            /////////////////////ANOTHER WAY FOR 2 DIMENSION /////////////////////////////////////////
            //                   student 1        student 2       student 3
            //                score{1,2,3}        {1,2,3}         {1,2,3}
            int[,] scores1 = { { 10, 12, 15 }, { 16, 24, 33 }, { 10, 5, 4 } }; // another way to do a two dimension array
            //[dimension 1, dimension 2]={ dimension 1 {dimension 2, dimension 2}, {dimension 2, dimension 2}}

            /////////////////////////////////////////////////////////////////////////////////////////
            // jagged array
            int[][] scores2 = new int[5][];
            scores2[0] = new int[3];
            scores2[1] = new int[2];
            /////////////////////////////////////////////////////////////////////////////////////
            // to get length of array use .length
            // Single dimension arrays
            int[] scores4 = { 1, 2, 3 };
            int x = scores4.Length;
            ///////////////////////////////////////////////////////////////////////////////////////
            //two dimension arrays
            //zero is first dimension one is second dimension---> int scores [0,1]
            int y = scores.GetUpperBound(0);
            int z = scores.GetUpperBound(1);
            ///////////////////////////////////////////////////////////////////////////////////////

            // ARRAY-LIST

            ArrayList scores5 = new ArrayList();
            scores5.Add(27);
            scores5.Add(28);
            scores5.Add("red");

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // List

            // <> means of // list of ints
            // list <int>
            List<int> grades = new List<int>();
            grades.Add(27);
            grades.Add(28);
            grades.Add(28);
            // Won't Work---> grades.Add("string"); // can only take a <int> because of the List DataType
            int d = grades[0];
            Console.ReadLine();
            // 0 is position, 55 is the value that is inserted in the 0 position and other positionsget pushed down one
            grades.Insert(0, 55);//<--- this pushes down the 0 position and takes its place

            Console.ReadLine();
            int e = grades[0]; // <-- this is 55
            Console.WriteLine("reads first position: " + d);
            Console.WriteLine("reads the new 0 position: " + e);
            Console.ReadLine();
            Console.WriteLine("count tells how many: " + grades.Count);// count tells you how many items
                                                                       // .Count = property//.Count() = method
            grades.RemoveAt(0); // removes first item at position 0
            grades.Remove(28);// removes element with the value 28
            Console.WriteLine("after removes the element with the value 28 the count is: " + grades.Count);
            Console.ReadLine();
            grades.Clear();// emptys list completely
            Console.WriteLine("removes everything: " + grades.Count);

            // Products
            List<Products> products = new List<Products>();
            Products phone = new Products
            {
                Id = 1,
                Title = "Phone",
                Price = 699.99,
                InStock = true
            };
            products.Add(phone);
            products.Add(new Products {
                Id = 2,
                Title = "sucks",
                Price = .01,
                InStock = true
            });
            Console.WriteLine("The product is: " + products.Count);
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine("{0} is for {1:c}", products[0].Title, products[0x].Price);
            }
            for (int i = 0; i < products.Count; i++)
            {
                Products items = products[i];
                Console.WriteLine("{0} is for {1:c}", products[i].Title, products[i].Price);
            }



            Console.ReadLine();
        }
    }
}










