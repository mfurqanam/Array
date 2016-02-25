using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Array
{
    class array
    {
        // this variable used for store logical size of array
        public int LogicalSizeArray,
            // Step counter use for count primitive steps of sorting algo
            stepCounter,
            // Index variable use store element index
            Index;
        //Main Menu
        public void MainMenu(int[] ARRAY, int[] Array1, int[] Array2, int[] Array3)
        {
            Console.WriteLine("Effort by Muhammad Furqan\n");
            if (ARRAY == Array1)
                Console.WriteLine(">> On Array1");
            else if (ARRAY == Array2)
                Console.WriteLine(">> On Array2");
            else if (ARRAY == Array3)
                Console.WriteLine(">> On Array3");

            Console.WriteLine("\n<==============Main Menu==============>\n");

            Console.WriteLine("| Create Array              : Press A |");
            Console.WriteLine("| Insert Element  in Array  : Press B |");
            Console.WriteLine("| Delete Element  in Array  : Press C |");
            Console.WriteLine("| Display Elements in Array : Press D |");
            Console.WriteLine("| Sort Array                : Press E |");
            Console.WriteLine("| Search Element in Array   : Press F |");
            Console.WriteLine("| Append Arrays             : Press G |");
            Console.WriteLine("| Merge Arrays              : Press H |");
            Console.WriteLine("| Extend Array              : Press I |");
            Console.WriteLine("| Swap Array Element        : Press J |");
            Console.WriteLine("| Switch Array              : Press S |");
            Console.WriteLine("| Exit for Program          : Press Y |");
            Console.WriteLine("_______________________________________");
        }
        // Create array method
        public void CreateUserDefineArray(int Logical_Size)
        {
            LogicalSizeArray = Logical_Size;
        }

        // Display Array Elements
        public void Display(int[] array, int NoOfElements)
        {
            int i = 1;
            Console.WriteLine("Array elementes are :");
            for (; i < NoOfElements; i++)
            {
                Console.Write(array[i] + ",");
            }
            if (NoOfElements == 0)
            {
                Console.WriteLine("Array Is Empty");
            }
            else
                Console.WriteLine(array[i]);
        }
        // Insert Element At Last method
        public void InsertAtLast(int[] array, int NoOfElements, int Element)
        {
            array[NoOfElements] = Element;
            // array[0] used for count no. of elements present in the array
        }
        //Check Array full method
        public int IsArrayFull(int Logical_Size, int NoOFElements)
        {
            if (Logical_Size == NoOFElements)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        //Check array is empty or not
        public int IsArrayEmpty(int NoOFElements)
        {
            if (NoOFElements == 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        // shift right method
        public void ShiftRight(int[] array, int NoOFElements, int SpecificLocationORElement)
        {
            for (int i = NoOFElements; i >= SpecificLocationORElement; i--)
            {
                array[i + 1] = array[i];
            }
        }
        //shift left method
        public void ShiftLeft(int[] array, int NoOFElements, int DeleteLocation)
        {
            for (int i = DeleteLocation; i < NoOFElements; i++)
            {
                array[i] = array[i + 1];
            }
        }
        //Bubble sort asc method
        public void BubbleSortAsc(int[] array, int NoOFElements)
        {
            //for using store temporary array element
            int temp;
            stepCounter = 0;
            //this loop execute 1 time less of NoOfElements
            for (int i = 1; i < NoOFElements; i++)

            {
                //this loop execute each time one less iteration of previous iterations
                for (int j = 1; j <= NoOFElements - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j];
                        stepCounter += 2;
                        array[j] = array[j + 1];
                        stepCounter += 4;
                        array[j + 1] = temp;
                        stepCounter += 3;
                    }
                }
            }
        }
        //Bubble sort desc method
        public void BubbleSortDesc(int[] array, int NoOFElements)
        {
            //for using store temporary array element
            int temp;
            stepCounter = 0;
            //this loop execute 1 time less of NoOfElements
            for (int i = 1; i < NoOFElements; i++)

            {
                //this loop execute each time one less iteration of previous iterations
                for (int j = 1; j <= NoOFElements - i; j++)
                {
                    if (array[j] < array[j + 1])
                    {
                        temp = array[j];
                        stepCounter += 2;
                        array[j] = array[j + 1];
                        stepCounter += 4;
                        array[j + 1] = temp;
                        stepCounter += 3;
                    }
                }
            }
        }
        //selection sort asc
        public void SelectionionSortAsc(int[] array, int NoOFElements)
        {
            //for using store temporary array element
            int temp;
            stepCounter = 0;
            //this loop execute 1 time less of NoOfElements
            for (int i = 1; i < NoOFElements; i++)

            { //this loop execute each time a less iteration of previous iterations
                for (int j = i + 1; j <= NoOFElements; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        stepCounter += 2;
                        array[i] = array[j];
                        stepCounter += 3;
                        array[j] = temp;
                        stepCounter += 2;
                    }
                }

            }

        }
        //selection sort desc
        public void SelectionionSortDesc(int[] array, int NoOFElements)
        {
            //for using store temporary array element
            int temp;
            stepCounter = 0;
            //this loop execute 1 time less of NoOfElements
            for (int i = 1; i < NoOFElements; i++)

            { //this loop execute each time a less iteration of previous iterations
                for (int j = i + 1; j <= NoOFElements; j++)
                {
                    if (array[i] < array[j])
                    {
                        temp = array[i];
                        stepCounter += 2;
                        array[i] = array[j];
                        stepCounter += 3;
                        array[j] = temp;
                        stepCounter += 2;
                    }
                }

            }

        }
       
        //insert element at specific location
        public void InsertAtSpecificLocation(int[] array, int SpecificLocationORElement, int Element)
        {
            array[SpecificLocationORElement] = Element;
        }
        // linear Search
        public int LinearSearch(int[] array, int Search_element, int NoOFElements)
        {
            for (int i = 1; i <= NoOFElements; i++)
            {
                if (array[i] == Search_element)
                {
                    Index = i;
                    return 1;
                }
            }
            return 0;
        }
        // check array sort in Asc order
        public int IsArraySortedAsc(int[] array, int NoOfElements)
        {
            int sortedAsc = 1;

            for (int i = 1; i < NoOfElements; i++)
            {

                if (array[i] - array[i + 1] <= 0)
                {
                    sortedAsc++;
                }

            }
            if (sortedAsc == NoOfElements)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
       
        // Quick sort Asc
        public void QuickSortAsc(int[] A, int left, int right)
        {
            stepCounter = 0;
            int pivot = A[left + (right - left) / 2];
            int i = left;
            int j = right;
            stepCounter += 7;
            while (i <= j)
            {
                while (A[i] < pivot)
                {
                    i++;
                    stepCounter += 2;
                }
                while (A[j] > pivot)
                {
                    j--;
                    stepCounter += 2;
                }
                if (i <= j)
                {
                    SwapArray(A,i, j);
                    stepCounter += 1;
                    i++;
                    j--;
                    stepCounter += 4;
                }
            }

            if (left < j)
            {
                QuickSortAsc(A, left, j);
                stepCounter += 1;
            }

            if (i < right)
            {
                QuickSortAsc(A, i, right);
                stepCounter += 1;
            }
                
        }
        // Quick sort Desc
        public void QuickSortDesc(int[] A, int left, int right)
        {
            int pivot = A[left + (right - left) / 2];
            int i = left;
            int j = right;
            stepCounter += 7;
            while (i <= j)
            {
                while (A[i] > pivot)
                {
                    i++;
                    stepCounter += 2;
                }
                while (A[j] < pivot)
                {
                    j--;
                    stepCounter += 2;
                }
                if (i <= j)
                {
                    SwapArray(A, i, j);
                    stepCounter += 1;
                    i++;
                    j--;
                    stepCounter += 4;
                }
            }

            if (left < j)
            {
                QuickSortDesc(A, left, j);
                stepCounter += 1;
            }

            if (i < right)
            {
                QuickSortDesc(A, i, right);
                stepCounter += 1;
            }
                
        }
        // Swap Array
        public void SwapArray(int[] array, int Location1, int location2)
        {
            int temp = array[Location1];
            array[Location1] = array[location2];
            array[location2] = temp;

        }
        // check array sort in desc order
        public int IsArraySortedDesc(int[] array, int NoOfElements)
        {
            int sortedDesc = 1;

            for (int i = 1; i < NoOfElements; i++)
            {

                if (array[i] - array[i + 1] >= 0)
                {
                    sortedDesc++;
                }

            }
            if (sortedDesc == NoOfElements)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        //binary search
        public void binarySearch(int[] array, int Search_element, int NoOfElements, int sortedAsc)
        {
            int mid_element = 0, low_element, high_element;
            low_element = 1;
            high_element = NoOfElements;

            if (sortedAsc == 1)
            {
                again:

                mid_element = (low_element + high_element+1) / 2;

                if (array[mid_element] == Search_element)
                {
                    Index = mid_element;
                    return;
                }

                if (array[mid_element] > Search_element)
                {
                    high_element = mid_element - 1;

                }
                else if (array[mid_element - 1] < Search_element)
                    low_element = mid_element + 1;

                goto again;

            }
            else
            {
                again1:

                mid_element = (low_element + high_element+1) / 2;

                if (array[mid_element] == Search_element)
                {
                    Index = mid_element;
                    return;
                }

                if (array[mid_element] < Search_element)
                {
                    high_element = mid_element - 1;

                }
                else if (array[mid_element] > Search_element)
                    low_element = mid_element + 1;

                goto again1;

            }


        }
        //Appent array
        public void AppendArray(int[] Array1, int[] Array2, int[] Array3, int NoOfElementArray1, int NoOfElementArray2, int Array1First)
        {
            Array3[0] = NoOfElementArray1 + NoOfElementArray2;
            int i = 1, j;
            if (Array1First == 1)
            {
                for (j = 1; i <= NoOfElementArray1; i++, j++)
                {
                    Array3[i] = Array1[j];
                }
                for (j = 1; i <= Array3[0]; i++, j++)
                {
                    Array3[i] = Array2[j];
                }
            }
            else
            {
                for (j = 1; i <= NoOfElementArray2; i++, j++)
                {
                    Array3[i] = Array2[j];
                }
                for (j = 1; i <= Array3[0]; i++, j++)
                {
                    Array3[i] = Array1[j];
                }
            }
        }
        // merge array for both Asc or Desc
        public void MergeArrays_Asc_Asc(int[] Array1, int[] Array2, int[] Array3, int NoOfElementArray1, int NoOfElementArray2)
        {
            Array3[0] = Array1[0] + Array2[0];

            for (int i = 1, j = 1, k = 1; k <= Array3[0]; k++)
            {
                if ((Array1[i] <= Array2[j] && i <= Array1[0]) || (Array1[i] >= Array2[j] && j > Array2[0]))
                {
                    Array3[k] = Array1[i];
                    i++;
                }
                else
                {
                    Array3[k] = Array2[j];
                    j++;

                }
            }
        }
        // merge array for Array1 Acs and Array2 desc OR Array1 Desc and Array2 Asc
        public void MergeArrays_AscOrDesc(int[] Array1, int[] Array2, int[] Array3, int NoOfElementArray1, int NoOfElementArray2,int AscFirst)
        {
            Array3[0] = Array1[0] + Array2[0];
            if(AscFirst==1)
            {
                for (int i = 1, j = Array2[0], k = 1; k <= Array3[0]; k++)
                {
                    if ((Array1[i] <= Array2[j] && i <= Array1[0]) || (Array1[i] >= Array2[j] && j > Array2[0]))
                    {
                        Array3[k] = Array1[i];
                        i++;
                    }
                    else
                    {
                        Array3[k] = Array2[j];
                        j--;

                    }
                }
            }
            else
            {
                for (int i = Array1[0], j = 1, k = 1; k <= Array3[0]; k++)
                {
                    if ((Array1[i] <= Array2[j] && i <= Array1[0]) || (Array1[i] >= Array2[j] && j > Array2[0]))
                    {
                        Array3[k] = Array1[i];
                        i--;
                    }
                    else
                    {
                        Array3[k] = Array2[j];
                        j++;

                    }
                }
            }
           
        }
        //Extend Array
        public void ExtendArray(int[] array, int Size)
        {
            LogicalSizeArray += Size;
        }
        
    }
}

