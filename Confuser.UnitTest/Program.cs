using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Confuser.UnitTest {


    class Program {

        private static void Test(Action<string> q, string e) {
            q(e);
        }

        [Obfuscation(Exclude = false, Feature = "+koi;")]
        public static void Main() {
            string x = "";
            for (int i = 0; i < 10; i++)
                Test(q => Console.WriteLine(q + (x += "a")), "1");
            for (int i = 0; i < 10; i++)
                Test(q => Console.WriteLine(q + (x += "b")), "2");

            Console.WriteLine("FisH!");
            Console.WriteLine("Koi {0}!", "VM");

            for (uint i = 1; i <= 100; i++) {
                if (i % 15 == 0)
                    Console.WriteLine("FizzBuzz");
                else if (i % 3 == 0)
                    Console.WriteLine("Fizz");
                else if (i % 5 == 0)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(i % 2 == 0 ? "0" : "1");
            }
            Console.WriteLine("1");
            try {
                try {
                    Console.WriteLine("2");
                } catch {
                    Console.WriteLine("X");
                } finally {
                    Console.WriteLine("3");
                }
                Console.WriteLine("4");
                try {
                    Console.WriteLine("5");
                    T("a");
                } catch (Exception ex) {
                    Console.WriteLine(ex.ToString());
                    try {
                        Console.WriteLine("6");
                        T("b");
                        Console.WriteLine("X");
                    } finally {
                        Console.WriteLine("7");
                    }
                } finally {
                    Console.WriteLine("8");
                    T("c");
                }
            } catch (Exception ex) {
                Console.WriteLine(ex.ToString());
                Console.WriteLine("9");
            } finally {
                Console.WriteLine("10");
            }
            Console.ReadKey();
        }

        private static void T(string q) {
            throw new Exception(q);
        }

    }

}
