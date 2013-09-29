using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericListAndClasses
{
    public class GenericList<T>
         where T : IComparable
    {
        private int capacity = 1;
        private T[] arrayElements;
        private int index = 0;
        // I red the capacity with the constructor

        public T Min<T>()
            where T : IComparable<T>
            // this means that T will have the functionality
            // "IComparable" which means you can compare T1 with T2
        {
            dynamic min = arrayElements[0];
            for (int i = 1; i < this.arrayElements.Length; i++)
            {
                if (this.arrayElements[i].CompareTo(min) >= 0)
                {
                    min = this.arrayElements[i];
                    // I compare the 2 objects and if min is smaller i make it equal to the element
                }
            }
            return min;
        }

        public T Max<T>()
    where T : IComparable<T>
        // this means that T will have the functionality
        // "IComparable" which means you can compare T1 with T2
        {
            dynamic max = arrayElements[0];
            for (int i = 1; i < this.arrayElements.Length; i++)
            {
                if (this.arrayElements[i].CompareTo(max) <= 0)
                {
                    max = this.arrayElements[i];
                    // I compare the 2 objects and if max is smaller i make it equal to the element
                }
            }
            return max;
        }

        private T[] AutoGrow()
        {
            capacity *= 2;
            // i m making a new array with 
            // two times more elements so I am increasing the 
            // capacity two times
            T[] temp = new T[capacity];
            // new array with the new capacity
            for (int i = 0; i < this.arrayElements.Length; i++)
            {
                temp[i] = arrayElements[i];
            }
            return temp;
        }

        public GenericList()
        {
            this.capacity = capacity;
            arrayElements = new T[this.capacity];
            // making a new array by
            // the given capacity (like it is said in the task)
        }

        public void Add(T element)
        {
            if (index == capacity)
            {
                this.arrayElements = AutoGrow();
            }
            arrayElements[this.index] = element;
            this.index++;
            // this adds a new element to the array
        }

        public void RemoveElement(int index)
        {
            this.arrayElements = arrayElements.Except(new T[] { arrayElements[index] }).ToArray();
            // this method makes a new array with the same 
            // elements without the given one
        }

        public void InsertElement(int index, T element)
        {
            if (index == capacity-1)
            {
                this.arrayElements = AutoGrow();
            }
            this.capacity++;
            this.index++;
            // Im making it + 1 because when you insert
            // an element you get 1 more value in the array
            // increasing the index too (by obvious reasons)
            T[] tempArray = new T[capacity];

            for (int i = 0; i < this.arrayElements.Length; i++)
            {
                tempArray[i] = arrayElements[i];
                // making a the same array with
                // the new capacity
            }

            T curElement = this.arrayElements[index];
            tempArray[index] = element;

            for (int i = index + 1; i < tempArray.Length; i++)
            {
                T oldElement = curElement;
                curElement = tempArray[i];
                tempArray[i] = oldElement;               
                // replacing all the elements after
                // the inserted one element[i] = element[i+1]....
            }
            this.arrayElements = tempArray;
        }

        public void Clear()
        {
            this.arrayElements = new T[this.capacity];
            // this method clears the array
            // and makes a new array with the same capacity
        }

        public int FindByValue(T element)
        {
            return Array.IndexOf(this.arrayElements, element);
            // this method returns the index of the searched element
        }

        public override string ToString()
        {
            int counter = 1;
            foreach (var item in this.arrayElements)
            {
                Console.WriteLine("Element № {0} ---> {1}",counter,item);
                counter++;
                // I use counter so i can write which element
                // I am showing at the moment
            }
            return "";
        }
        public dynamic this[int index]
        {
            get
            {
                return arrayElements[index];
                // when you type numMatrix[row,col] it returns the given element
            }
            set
            {
                this.arrayElements[index] = value;
                // this makes numMatrix[row,col] equal to the given value
            }
        }
    }
}
