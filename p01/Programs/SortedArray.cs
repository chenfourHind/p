using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p01.Programs{
    class SortedArray {
        private int[] tab;
        private int length;

        public SortedArray(int[] tab) {
            this.tab = tab;
            this.length = tab.Length;
        }

        public void insert(int number)
        {
            for (int i = 0; i < length; i++)
            {
                if (number < tab[i])
                {
                    int[] temp = new int[length + 1];
                    for (int j = 0; j < i + 1; j++)
                    {
                        temp[j] = tab[j];
                    }

                    temp[i] = number;

                    for (int k = i + 1; k < temp.Length; k++)
                    {
                        temp[k] = tab[k - 1];
                    }
                    length = temp.Length;
                    tab = temp;
                    i = length;
                }
            }
        }
        public void insertv2(int number) {
            // la methode Array.Resize crée un nouvel tableau avec la nouvelle dimension, et le reference
            //avec la reference du tableau d'avant, donc elle l'écrase.

            Array.Resize(ref tab, tab.Length + 1);
            length = tab.Length;

            for (int i = length - 1; i >= 0; i--) {
                if (number > tab[i - 1]) {
                    tab[i] = number;
                    i = -1;
                }

                else {
                    tab[i] = tab[i - 1];
                }
            }
        }

        public void print() {
            for (int i = 0; i < length; i++) {
                Console.WriteLine(" - " + tab[i]);
            }
        }
    }
}
