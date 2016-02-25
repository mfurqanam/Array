using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            // array class Object
            array arr = new array();

            //variable Declares
            int[] Array1 = new int[101];
            int[] Array2 = new int[101];
            int[] ARRAY = Array1;
            int[] Array3 = new int[201];

            ConsoleKeyInfo cki;

            // call Main Menu method from array class
            arr.MainMenu(ARRAY, Array1, Array2, Array3);


            Again:

            // get key which pressed
            cki = Console.ReadKey();
            // clear Screen
            Console.Clear();
            if (cki.Key == ConsoleKey.A || cki.Key == ConsoleKey.B || cki.Key == ConsoleKey.C || cki.Key == ConsoleKey.D //...
            || cki.Key == ConsoleKey.E || cki.Key == ConsoleKey.S || cki.Key == ConsoleKey.F || cki.Key == ConsoleKey.G || cki.Key == ConsoleKey.H
            || cki.Key == ConsoleKey.I || cki.Key == ConsoleKey.J || cki.Key == ConsoleKey.Y)
            {
                // if "A" pressed
                //create array
                if (cki.Key == ConsoleKey.A)
                {
                    if (ARRAY == Array1)
                    {
                        Array1[0] = 0;
                        ARRAY = Array1;
                        Console.Write("Enter a size of Array1 : ");
                        try
                        {
                            arr.CreateUserDefineArray(Convert.ToInt16(Console.ReadLine()));
                        }
                        catch
                        {

                            Console.Clear();
                            arr.MainMenu(ARRAY, Array1, Array2, Array3);
                            Console.WriteLine("Input value must be integer");
                            goto Again;

                        }
                        if (arr.LogicalSizeArray > 100 || arr.LogicalSizeArray <= 0)
                        {
                            Console.Clear();
                            arr.LogicalSizeArray = 0;
                            // call Main Menu method from array class
                            arr.MainMenu(ARRAY, Array1, Array2, Array3);
                            Console.WriteLine("\nArray1 Size must be greater to 0 and less to 101");
                        }
                        else
                        {
                            // clear Screen
                            Console.Clear();
                            // call Main Menu method from array class
                            arr.MainMenu(ARRAY, Array1, Array2, Array3);
                            Console.WriteLine("\nArray1 has been successfully created");
                        }
                    }
                    else
                    {
                        Array2[0] = 0;
                        ARRAY = Array2;
                        Console.Write("Enter a size of Array2 : ");
                        try
                        {
                            arr.CreateUserDefineArray(Convert.ToInt16(Console.ReadLine()));
                        }
                        catch
                        {

                            Console.Clear();
                            arr.MainMenu(ARRAY, Array1, Array2, Array3);
                            Console.WriteLine("Input value must be integer");
                            goto Again;

                        }
                        if (arr.LogicalSizeArray > 100 || arr.LogicalSizeArray <= 0)
                        {
                            Console.Clear();
                            arr.LogicalSizeArray = 0;
                            // call Main Menu method from array class
                            arr.MainMenu(ARRAY, Array1, Array2, Array3);
                            Console.WriteLine("\nArray2 Size must be greater to 0 and less to 101");
                        }
                        else
                        {
                            // clear Screen
                            Console.Clear();
                            // call Main Menu method from array class
                            arr.MainMenu(ARRAY, Array1, Array2, Array3);
                            Console.WriteLine("\nArray2 has been successfully created");
                        }
                    }
                    // goto Again;
                }

                // if "B" pressed
                // insert element
                else if (cki.Key == ConsoleKey.B)
                {
                    if (arr.LogicalSizeArray != 0)
                    {
                        if (arr.IsArrayFull(arr.LogicalSizeArray, ARRAY[0]) == 0)
                        {
                            Console.WriteLine("--Select a Insertion mode--\n");
                            Console.WriteLine("1. Insert At Last");
                            Console.WriteLine("2. Insert At Specific Location");
                            Console.WriteLine("3. Insert At Before Specific Elements");
                            Console.WriteLine("4. Insert At After Specific Elements");
                            cki = Console.ReadKey();
                            // if "1" pressed
                            if (cki.KeyChar == 49)
                            { // clear Screen
                                Console.Clear();
                                //Ask message
                                Console.WriteLine("How many elements do you want to insert ?");
                                // take input for insert no of elements
                                int insert = int.Parse(Console.ReadLine());
                                if (insert + ARRAY[0] <= arr.LogicalSizeArray)
                                {
                                    for (int i = 1; i <= insert; i++)
                                    {
                                        Console.Write("Enter " + i + " element to insert : ");
                                        ARRAY[0]++;
                                        arr.InsertAtLast(ARRAY, ARRAY[0], Convert.ToInt16(Console.ReadLine()));
                                    }
                                    // clear Screen
                                    Console.Clear();
                                    arr.MainMenu(ARRAY, Array1, Array2, Array3);
                                    Console.WriteLine("\nElement has been successfully inserted");
                                }
                                else
                                {
                                    Console.WriteLine("No of elements is exceeded from array size please extend array size");
                                    System.Threading.Thread.Sleep(3000);
                                    // clear Screen
                                    Console.Clear();
                                    arr.MainMenu(ARRAY, Array1, Array2, Array3);
                                }

                            }
                            // if "2" pressed
                            else if (cki.KeyChar == 50)
                            {

                                // clear Screen
                                Console.Clear();
                                Console.WriteLine("Enter an element to insert :");
                                int insertElement = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter a Location where you insert an element");
                                int SpecificLocation = int.Parse(Console.ReadLine());
                                if (ARRAY[0] + 1 < SpecificLocation)
                                {
                                    Console.Clear();
                                    arr.MainMenu(ARRAY, Array1, Array2, Array3);
                                    Console.WriteLine("Please fill previous array element first array " + (ARRAY[0] + 1) + " location is empty");

                                }
                                else
                                {
                                    arr.ShiftRight(ARRAY, ARRAY[0], SpecificLocation);
                                    arr.InsertAtSpecificLocation(ARRAY, SpecificLocation, insertElement);
                                    ARRAY[0]++;
                                    // clear Screen
                                    Console.Clear();
                                    arr.MainMenu(ARRAY, Array1, Array2, Array3);
                                    Console.WriteLine("\nElement has been successfully inserted");
                                }


                            }
                            // if "3" pressed
                            else if (cki.KeyChar == 51)
                            {
                                if (ARRAY[0] > 0)
                                {
                                    if (arr.IsArrayEmpty(ARRAY[0]) == 0)
                                    {
                                        Console.Clear();
                                        Console.Write("Enter an element to insert :");
                                        int insertElement = int.Parse(Console.ReadLine());
                                        Console.Write("Enter an element to insert at before this : ");
                                        int Beforelement = Convert.ToInt16(Console.ReadLine());
                                        if (arr.LinearSearch(ARRAY, Beforelement, ARRAY[0]) == 1)
                                        {
                                            int SpecificLocationORElement = arr.Index;
                                            arr.ShiftRight(ARRAY, ARRAY[0], SpecificLocationORElement);
                                            arr.InsertAtSpecificLocation(ARRAY, SpecificLocationORElement, insertElement);
                                            ARRAY[0]++;
                                            // clear Screen
                                            Console.Clear();
                                            arr.MainMenu(ARRAY, Array1, Array2, Array3);
                                            Console.WriteLine("\nElement has been successfully inserted");
                                        }
                                        else
                                        {// clear Screen
                                            Console.Clear();
                                            arr.MainMenu(ARRAY, Array1, Array2, Array3);
                                            Console.WriteLine("This element is does not exit in this array");
                                        }
                                    }
                                    else
                                    {
                                        // clear Screen
                                        Console.Clear();
                                        arr.MainMenu(ARRAY, Array1, Array2, Array3);
                                        Console.WriteLine("\nArray is empty");
                                    }
                                }
                                else
                                {

                                    // clear Screen
                                    Console.Clear();
                                    arr.MainMenu(ARRAY, Array1, Array2, Array3);
                                    Console.WriteLine("\nPlease select 1 or 2 option for insert because no element in this array");
                                }
                            }
                            // if "4" pressed
                            else if (cki.KeyChar == 52)
                            {
                                if (ARRAY[0] > 0)
                                {
                                    if (arr.IsArrayEmpty(ARRAY[0]) == 0)
                                    {
                                        Console.Clear();
                                        Console.Write("Enter an element to insert :");
                                        int insertElement = int.Parse(Console.ReadLine());
                                        Console.Write("Enter an element to insert at after this : ");
                                        int Beforelement = Convert.ToInt16(Console.ReadLine());
                                        if (arr.LinearSearch(ARRAY, Beforelement, ARRAY[0]) == 1)
                                        {
                                            int SpecificLocationORElement = arr.Index;
                                            SpecificLocationORElement = arr.Index + 1;
                                            arr.ShiftRight(ARRAY, ARRAY[0], SpecificLocationORElement);
                                            arr.InsertAtSpecificLocation(ARRAY, SpecificLocationORElement, insertElement);
                                            ARRAY[0]++;
                                            // clear Screen
                                            Console.Clear();
                                            arr.MainMenu(ARRAY, Array1, Array2, Array3);
                                            Console.WriteLine("\nElement has been successfully inserted");
                                        }
                                        else
                                        {// clear Screen
                                            Console.Clear();
                                            arr.MainMenu(ARRAY, Array1, Array2, Array3);
                                            Console.WriteLine("This element is does not exit in this array");
                                        }
                                    }
                                    else
                                    {
                                        // clear Screen
                                        Console.Clear();
                                        arr.MainMenu(ARRAY, Array1, Array2, Array3);
                                        Console.WriteLine("\nArray is empty");
                                    }
                                }
                                else
                                {
                                    // clear Screen
                                    Console.Clear();
                                    arr.MainMenu(ARRAY, Array1, Array2, Array3);
                                    Console.WriteLine("\nPlease select 1 or 2 option for insert because no element in this array");
                                }
                            }
                            // goto Again;
                        }
                        else
                        {
                            // clear Screen
                            Console.Clear();
                            arr.MainMenu(ARRAY, Array1, Array2, Array3);
                            Console.WriteLine("Array is full please delete some element to insert");
                        }
                    }
                    else
                    {
                        // clear Screen
                        Console.Clear();
                        arr.MainMenu(ARRAY, Array1, Array2, Array3);
                        Console.WriteLine("Create array first");
                    }
                }
                // if "C" pressed
                // delete element
                else if (cki.Key == ConsoleKey.C)
                {
                    if (arr.IsArrayEmpty(ARRAY[0]) == 0)
                    {
                        // clear Screen
                        Console.Clear();
                        Console.WriteLine("--Select a Delete mode--\n");
                        Console.WriteLine("1. Delete by element");
                        Console.WriteLine("2. Delete by Location");
                        cki = Console.ReadKey();
                        if (cki.KeyChar == 49)
                        { // clear Screen
                            Console.Clear();
                            Console.Write("Enter an element do you want to delete : ");
                            int deleteelement = int.Parse(Console.ReadLine());
                            if (arr.LinearSearch(ARRAY, deleteelement, ARRAY[0]) == 1)
                            {
                                deleteelement = arr.Index;
                                arr.ShiftLeft(ARRAY, ARRAY[0], deleteelement);
                                ARRAY[0]--;
                                // clear Screen
                                Console.Clear();
                                arr.MainMenu(ARRAY, Array1, Array2, Array3);
                                Console.WriteLine(deleteelement + " is succesfully deleted in this array ");
                            }
                            else
                            {
                                // clear Screen
                                Console.Clear();
                                arr.MainMenu(ARRAY, Array1, Array2, Array3);
                                Console.WriteLine(" this element is not present in this array");
                            }
                        }
                        else if (cki.KeyChar == 50)
                        {// clear Screen
                            Console.Clear();
                            Console.Write("Enter a location do you want to delete this element: ");
                            int deleteelement = int.Parse(Console.ReadLine());
                            if (ARRAY[0] >= deleteelement)
                            {
                                arr.ShiftLeft(ARRAY, ARRAY[0], deleteelement);
                                ARRAY[0]--;
                                // clear Screen
                                Console.Clear();
                                arr.MainMenu(ARRAY, Array1, Array2, Array3);
                                Console.WriteLine("location  " + deleteelement + " element is succesfully deleted in this array ");
                            }
                            else
                            {
                                // clear Screen
                                Console.Clear();
                                arr.MainMenu(ARRAY, Array1, Array2, Array3);
                                Console.WriteLine("No element in this Location");
                            }
                        }

                        // goto Again;
                    }
                    else
                    {
                        // clear Screen
                        Console.Clear();
                        arr.MainMenu(ARRAY, Array1, Array2, Array3);
                        Console.WriteLine("\nArray is empty");
                    }
                }
                // if "D" pressed
                //display
                else if (cki.Key == ConsoleKey.D)
                {
                    Console.Clear();
                    // call Main Menu method from array class
                    arr.MainMenu(ARRAY, Array1, Array2, Array3);
                    //call Display method in array class
                    arr.Display(ARRAY, ARRAY[0]);
                    // goto Again;
                }
                // if "E" pressed
                //Exit
                else if (cki.Key == ConsoleKey.Y)
                {
                    goto Exit;
                }
                // if "SPACE" pressed
                //switch array
                else if (cki.Key == ConsoleKey.S)
                {
                    if (Array3[0] != 0)
                    {
                        Console.WriteLine("Which array do you want switch ?\n1. Array1 2. Array2 3.Array3");
                        cki = Console.ReadKey();
                        if (cki.KeyChar == 49)
                        {
                            ARRAY = Array1;
                            // goto Again;
                        }
                        else if (cki.KeyChar == 50)
                        {
                            ARRAY = Array2;
                        }
                        else if (cki.KeyChar == 51)
                        {
                            Console.WriteLine(">> On Array3");
                            ARRAY = Array3;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Which array do you want switch ?\n1. Array1 2. Array2");
                        cki = Console.ReadKey();
                        if (cki.KeyChar == 49)
                        {
                            ARRAY = Array1;
                            // goto Again;
                        }
                        else if (cki.KeyChar == 50)
                        {
                            ARRAY = Array2;
                        }
                    }
                    // clear Screen
                    Console.Clear();
                    // call Main Menu method from array class
                    arr.MainMenu(ARRAY, Array1, Array2, Array3);
                }
                // Sorting elements
                else if (cki.Key == ConsoleKey.E)
                {
                    if (arr.IsArrayEmpty(ARRAY[0]) == 0)
                    {
                        // clear Screen
                        Console.Clear();
                    Console.WriteLine("--Select an order of sort--\n1.Ascending order 2.Descending order");
                    cki = Console.ReadKey();
                    // clear Screen
                    Console.Clear();
                    if (cki.KeyChar == 49)
                    {

                        Console.WriteLine("-- Select a Sorting Algorithm--\n1.Bubble Sort 2.Selection Sort 3.Quick Sort");
                        cki = Console.ReadKey();
                        if (cki.KeyChar == 49)
                        {

                            // clear Screen
                            Console.Clear();
                            arr.BubbleSortAsc(ARRAY, ARRAY[0]);
                            arr.MainMenu(ARRAY, Array1, Array2, Array3);
                            Console.WriteLine("Array is sorted in ascending order in {0} step",arr.stepCounter);
                        }
                        else if (cki.KeyChar == 50)
                        {
                            // clear Screen
                            Console.Clear();
                            arr.SelectionionSortAsc(ARRAY, ARRAY[0]);
                            arr.MainMenu(ARRAY, Array1, Array2, Array3);
                            Console.WriteLine("Array is sorted in ascending order in {0} step", arr.stepCounter);
                        }
                        else if (cki.KeyChar == 51)
                        {
                                // clear Screen
                                Console.Clear();
                                arr.QuickSortAsc(ARRAY,1,ARRAY[0]);
                                arr.MainMenu(ARRAY, Array1, Array2, Array3);
                                Console.WriteLine("Array is sorted in ascending order in {0} step", arr.stepCounter);
                            }
                    }
                    else if (cki.KeyChar == 50)
                    {
                        Console.WriteLine("-- Select a Sorting Algorithm--\n1.Bubble Sort 2.Selection Sort 3.Quick Sort");
                        cki = Console.ReadKey();

                        if (cki.KeyChar == 49)
                        {

                            // clear Screen
                            Console.Clear();
                            arr.BubbleSortDesc(ARRAY, ARRAY[0]);
                            arr.MainMenu(ARRAY, Array1, Array2, Array3);
                            Console.WriteLine("Array is sorted in descending order in {0} step", arr.stepCounter);
                        }
                        else if (cki.KeyChar == 50)
                        {
                            // clear Screen
                            Console.Clear();
                            arr.SelectionionSortDesc(ARRAY, ARRAY[0]);
                            arr.MainMenu(ARRAY, Array1, Array2, Array3);
                            Console.WriteLine("Array is sorted in descending order in {0} step", arr.stepCounter);
                        }
                        else if (cki.KeyChar == 51)
                        {
                                // clear Screen
                                Console.Clear();
                                arr.QuickSortDesc(ARRAY, 1, ARRAY[0]);
                                arr.MainMenu(ARRAY, Array1, Array2, Array3);
                                Console.WriteLine("Array is sorted in descending order in {0} step", arr.stepCounter);
                            }
                    }
                }
                else
                {
                        // clear Screen
                        Console.Clear();
                        arr.MainMenu(ARRAY, Array1, Array2, Array3);
                        Console.WriteLine("\nArray is empty");
                    }
                }
                // search element
                else if (cki.Key == ConsoleKey.F)
                {
                    if (arr.IsArrayEmpty(ARRAY[0]) == 0)
                    {  // clear Screen
                        Console.Clear();
                        Console.WriteLine("--Select a Search mode--\n1.Linear Search 2.Binary Search");
                        cki = Console.ReadKey();
                        if (cki.KeyChar == 49)
                        {   // clear Screen
                            Console.Clear();
                            Console.Write("Enter a search element : ");
                            int SearchElement = int.Parse(Console.ReadLine());
                            if (arr.LinearSearch(ARRAY, SearchElement, ARRAY[0]) == 1)
                            {
                                // clear Screen
                                Console.Clear();
                                arr.MainMenu(ARRAY, Array1, Array2, Array3);
                                Console.WriteLine("The element " + SearchElement + " is found at " + arr.Index + " position.");


                            }
                            else
                            { // clear Screen
                                Console.Clear();
                                arr.MainMenu(ARRAY, Array1, Array2, Array3);
                                Console.WriteLine("No element in this Location");

                            }

                        }
                        else if (cki.KeyChar == 50)
                        {
                            // clear Screen
                            Console.Clear();
                            Console.Write("Enter a search element : ");
                            int SearchElement = int.Parse(Console.ReadLine());
                            if (arr.IsArraySortedAsc(ARRAY, ARRAY[0]) == 1)
                            {
                                // clear Screen
                                Console.Clear();
                                arr.binarySearch(ARRAY, SearchElement, ARRAY[0], 1);
                                arr.MainMenu(ARRAY, Array1, Array2, Array3);
                                if(arr.Index==0)
                                {
                                    Console.WriteLine("No element in this Location");
                                }
                                else
                                Console.WriteLine("The element " + SearchElement + " is found at " + arr.Index + " position.");


                            }
                            else if (arr.IsArraySortedDesc(ARRAY, ARRAY[0]) == 1)
                            {
                                // clear Screen
                                Console.Clear();
                                arr.binarySearch(ARRAY, SearchElement, ARRAY[0], 0);
                                arr.MainMenu(ARRAY, Array1, Array2, Array3);
                                Console.WriteLine("The element " + SearchElement + " is found at " + arr.Index + " position.");
                            }
                            else
                            { // clear Screen
                                Console.Clear();
                                arr.MainMenu(ARRAY, Array1, Array2, Array3);
                                Console.WriteLine("In binary search array must be sorted in Asc or Desc order");

                            }
                        }

                    }

                    else
                    {

                        // clear Screen
                        Console.Clear();
                        arr.MainMenu(ARRAY, Array1, Array2, Array3);
                        Console.WriteLine("\nArray is empty");
                    }
                }
                // append array
                else if (cki.Key == ConsoleKey.G)
                {
                    if (arr.IsArrayEmpty(Array1[0]) == 0 && arr.IsArrayEmpty(Array2[0]) == 0)
                    {
                        // clear Screen
                        Console.Clear();
                        Console.WriteLine("Which Array do you want to first\n1.Array1 2.Array2");
                        cki = Console.ReadKey();
                        // clear Screen
                        Console.Clear();
                        if (cki.KeyChar == 49)
                        {
                            arr.AppendArray(Array1, Array2, Array3, Array1[0], Array2[0], 1);
                            arr.MainMenu(ARRAY, Array1, Array2, Array3);
                            Console.WriteLine("Array1 and Array2 is successfully append in Array3");
                        }
                        else if (cki.KeyChar == 50)
                        {
                            arr.AppendArray(Array1, Array2, Array3, Array1[0], Array2[0], 0);
                            arr.MainMenu(ARRAY, Array1, Array2, Array3);
                            Console.WriteLine("Array1 and Array2 is successfully append in Array3");
                        }


                    }
                    else
                    { // clear Screen
                        Console.Clear();
                        arr.MainMenu(ARRAY, Array1, Array2, Array3);
                        if (arr.IsArrayEmpty(Array1[0]) == 1)
                            Console.WriteLine("Array1 is empty");
                        else
                            Console.WriteLine("Array2 is empty");

                    }
                }
                // merge array
                else if (cki.Key == ConsoleKey.H)
                {
                    if (arr.IsArrayEmpty(Array1[0]) == 0 && arr.IsArrayEmpty(Array2[0]) == 0)
                    {
                        Console.Clear();
                        if ((arr.IsArraySortedAsc(Array1, Array1[0]) == 1 && arr.IsArraySortedAsc(Array2, Array2[0]) == 1) ||
                            (arr.IsArraySortedDesc(Array1, Array1[0]) == 1 && arr.IsArraySortedDesc(Array2, Array2[0]) == 1))
                        {
                            arr.MergeArrays_Asc_Asc(Array1, Array2, Array3, Array1[0], Array2[0]);
                            arr.MainMenu(ARRAY, Array1, Array2, Array3);
                            Console.WriteLine("Array1 and Array2 is successfully merge in Array3");
                        }
                        else if ((arr.IsArraySortedAsc(Array1, Array1[0]) == 1 && arr.IsArraySortedDesc(Array2, Array2[0]) == 1))
                                                        {
                            arr.MergeArrays_AscOrDesc(Array1, Array2, Array3, Array1[0], Array2[0],1);
                            arr.MainMenu(ARRAY, Array1, Array2, Array3);
                            Console.WriteLine("Array1 and Array2 is successfully merge in Array3");
                        }
                        else if((arr.IsArraySortedDesc(Array1, Array1[0]) == 1 && arr.IsArraySortedAsc(Array2, Array2[0]) == 1))
                        {
                            arr.MergeArrays_AscOrDesc(Array1, Array2, Array3, Array1[0], Array2[0], 0);
                            arr.MainMenu(ARRAY, Array1, Array2, Array3);
                            Console.WriteLine("Array1 and Array2 is successfully merge in Array3");
                        }
                        else
                        { // clear Screen
                            Console.Clear();
                            arr.MainMenu(ARRAY, Array1, Array2, Array3);
                            Console.WriteLine("In binary search array must be sorted in Asc or Desc order");

                        }
                    }
                    else
                    { // clear Screen
                        Console.Clear();
                        arr.MainMenu(ARRAY, Array1, Array2, Array3);
                        if (arr.IsArrayEmpty(Array1[0]) == 1)
                            Console.WriteLine("Array1 is empty");
                        else
                            Console.WriteLine("Array2 is empty");

                    }
                }
                // extend array size
                else if (cki.Key == ConsoleKey.I)
                {
                    if (arr.LogicalSizeArray != 0)
                    {
                        Console.Clear();
                        Console.Write("Enter a size for increase : ");
                        int temp = arr.LogicalSizeArray;
                        arr.ExtendArray(ARRAY, int.Parse(Console.ReadLine()));
                        if (arr.LogicalSizeArray > 100)
                        {
                            Console.Clear();
                            arr.LogicalSizeArray = temp;
                            // call Main Menu method from array class
                            arr.MainMenu(ARRAY, Array1, Array2, Array3);
                            Console.WriteLine("\nArray Size must be 100 or less");
                        }
                        else
                        {
                            Console.Clear();
                            arr.MainMenu(ARRAY, Array1, Array2, Array3);
                            Console.WriteLine("Array size is succesfully increased, Now this Array size is "+ arr.LogicalSizeArray);
                        }
                    }
                    else
                    {
                        arr.MainMenu(ARRAY, Array1, Array2, Array3);
                        Console.WriteLine("Create array first");
                    }
                }
                // Swap two elements
                else if (cki.Key == ConsoleKey.J)
                {
                    if (arr.IsArrayEmpty(Array1[0]) == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Enter two Locations which you want to swap this elements");
                        int location1, location2;
                        Console.Write("Enter locaton1 : ");
                        location1 = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.Write("Enter locaton2 : ");
                        location2 = int.Parse(Console.ReadLine());
                        arr.SwapArray(ARRAY, location1, location2);
                        Console.Clear();
                        arr.MainMenu(ARRAY, Array1, Array2, Array3);
                        Console.WriteLine("Successfully swaped two elements of array ");
                    }
                    else
                    {
                        // clear Screen
                        Console.Clear();
                        arr.MainMenu(ARRAY, Array1, Array2, Array3);
                        Console.WriteLine("Array1 is empty");
                    }
                }
            }
            else
            {
                arr.MainMenu(ARRAY, Array1, Array2, Array3);
            }

                goto Again;
                Exit:;
            }
        }
    }

