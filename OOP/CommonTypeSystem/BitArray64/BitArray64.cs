using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitArray64
{
    public class BitArray64 : IEnumerable<int>
    {
        private List<ulong> nums;
        // list for the nums

        public BitArray64(List<ulong> num)
        {
            this.nums = num;
        }

        public List<ulong> Nums
        {
            get { return this.nums;}
            set { this.nums = value; }
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < nums.Count; i++)
            {
                yield return i;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override bool Equals(object obj)
        {
            BitArray64 numbers = (BitArray64)obj;
            if (numbers.Nums.Count != this.Nums.Count)
            {
                return false;
            }

            for (int i = 0; i < nums.Count; i++)
            {
                if (this.Nums[i] != numbers.Nums[i])
                {
                    return false;
                }
            }
            return true;
        }

        public ulong this[int number]
        {
            get
            {
                return this.nums[number];
            }
            set
            {
                this.nums[number] = value;
            }
        }

        public override int GetHashCode()
        {
            int hashCode = 0;
            foreach (var num in nums)
            {
                hashCode += num.GetHashCode();
            }
            return hashCode;
        }

        public static bool operator == (BitArray64 firstArray, BitArray64 secondArray)
        {
            return firstArray.Equals(secondArray);
        }

        public static bool operator != (BitArray64 firstArray, BitArray64 secondArray)
        {
            return !firstArray.Equals(secondArray);
        }
    }
}
