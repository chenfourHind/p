using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using p01.Programs;

namespace p01 {
    class  EntryPoint{
        public EntryPoint() {
            exe02();
        }

        public bool estPremier(int number) {
            bool validity = true;

            if (number < 0) {
                return false;
            }

            for (int i = 2; i < number && validity == true; i++) {
                if (number % i == 0) {
                    validity = false;
                }
            }
                return validity;
        }

        public void exe01() {
            int number;
            bool isInteger;

            do {
                Console.Write("Entrer un nombre premier : ");
                String value = Console.ReadLine();
                number = 4;
                isInteger = int.TryParse(value, out number);
            } while (!estPremier(number) || isInteger == false);

            Console.Write("Réponse correcte");
        }

        public void exe02() {
            int[] tab = { 1, 2, 4, 6, 9, 11, 13 };

            SortedArray array = new SortedArray(tab);
            array.print();
            array.insertv2(-1);
            Console.WriteLine("On ajoute -1 : ");
            array.print();
        }

        static void Main(string[] args) {
            new EntryPoint();
            Console.Read();
        }
    }
}
