using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Data_Structures_Arrays
{
    class Array
    {
        public Array(int size = 10)
        {
            this.Index = -1;
            this.Data = new object[size];
        }

        private int Index;
        private object[] Data;

        public object Get()
        {
            if (0 < Index && Index < this.Data.Length)
            {
                return Data[Index];
            }

            return null;
        }

        public int Push(object data)
        {
            if (Index + 1 < this.Data.Length)
            {
                Data[++Index] = data;
            }
            else if (Index + 1 == this.Data.Length && Data[Index] == null)
            {
                Data[Index] = data;
            }

            return this.Index;
        }

        public int Pop()
        {
            if (0 <= Index && Index < this.Data.Length)
            {
                Data[Index] = null;
                this.Index--;
            }

            return this.Index;
        }

        public int Delete(int deletedIndex)
        {
            this.Data[deletedIndex] = null;
            this.Index--;

            ShiftArray(deletedIndex);

            return this.Index;
        }

        private void ShiftArray(int deletedIndex)
        {
            for (int i = deletedIndex; i < this.Data.Length; i++)
            {
                if (i + 1 < this.Data.Length)
                {
                    this.Data[i] = this.Data[i + 1];
                }
                else
                {
                    this.Data[i] = null;
                }
            }
        }
    }

}
