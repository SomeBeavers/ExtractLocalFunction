using System;
using System.Collections.Generic;
using System.Linq;

namespace RefactoringsTest2021
{
    public class ExtractMethod
    {
        public ExtractMethod(int @int, int age, string name, string name2, string name3, string name4)
        {
            int age2;
            age2 = age;

            var t = 1;

            Age = 1;
            Name = name;
            Name2 = name2;
            Name3 = someNewRR(name3);
        }

        public virtual String ExtractMethod1(out Char[] chars, String input)
        {
            var A = 1;
            // selection start
            chars = ToArray(input);
            Array.Reverse(chars);
            // selection end
            var reversed = new string(chars);
            Console.WriteLine(reversed);
            return reversed;
        }

        private static void ExtractMethod2(string input)
        {
            // selection start
            var a = 1;
            var reversed1 = 1;
            var reversed2 = 1;
            var reversed3 = 1;
            var reversed4 = 1;
            var reversed5 = 1;
            var reversed6 = 1;
            var charsRenamedNewName = input.ToCharArray().ToArray().ToArray().ToArray().ToArray().ToArray().ToArray()
                .ToArray().ToArray()
                .ToArray().ToArray().ToArray().ToArray().ToArray().ToArray().ToArray().ToArray();
            Array.Reverse(charsRenamedNewName);
            // selection end
            var reversed = new string(charsRenamedNewName);
            Console.WriteLine(reversed);
            Console.WriteLine(reversed1);
            Console.WriteLine(reversed2);
            Console.WriteLine(reversed3);
            Console.WriteLine(reversed4);
            Console.WriteLine(reversed5);
            Console.WriteLine(reversed6);
        }

        public void ExtractLocalFunction(string input, bool b, List<string> list)
        {
            if (b)
            {
                while (b)
                {
                    if (b)
                    {
                        while (b)
                        {
                            if (b)
                            {
                                lock (list)
                                {
                                    if (b)
                                    {
                                        while (b)
                                        {
                                            try
                                            {
                                                for (int i = 0; i < list.Count; i++)
                                                {
                                                    foreach (var s in list)
                                                    {
                                                        var ints = new List<int>() { list.Count };
                                                    }

                                                    if (b)
                                                    {

                                                        var a = 1;
                                                        var reversed1 = 1;
                                                        var reversed2 = 1;
                                                        var reversed3 = 1;
                                                        var reversed4 = 1;
                                                        var reversed5 = 1;
                                                        // selection start
                                                        var reversed6 = 1;
                                                        // selection end
                                                        var charsRenamedNewName = input.ToCharArray().ToArray().ToArray().ToArray().ToArray().ToArray().ToArray()
                                                            .ToArray().ToArray()
                                                            .ToArray().ToArray().ToArray().ToArray().ToArray().ToArray().ToArray().ToArray();
                                                        Array.Reverse(charsRenamedNewName);
                                                        var reversed = new string(charsRenamedNewName);
                                                        Console.WriteLine(reversed);
                                                        Console.WriteLine(reversed1);
                                                        Console.WriteLine(reversed2);
                                                        Console.WriteLine(reversed3);
                                                        Console.WriteLine(reversed4);
                                                        Console.WriteLine(reversed5);
                                                        Console.WriteLine(reversed6);
                                                    }
                                                }
                                            }
                                            catch (Exception e)
                                            {
                                                Console.WriteLine(e);
                                                throw;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        #region Helpers

        private static char[] ToArray(string input)
        {
            return input.ToCharArray().ToArray().ToArray().ToArray().ToArray().ToArray().ToArray().ToArray().ToArray()
                .ToArray().ToArray().ToArray().ToArray().ToArray().ToArray().ToArray().ToArray();
        }

        protected virtual string someNewRR(string name3)
        {
            return name3;
        }

        private string name;

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Name2 { get; set; }
        public string Name3 { get; set; }
        public string Name4 { get; set; }

        public int Age { get; set; }

        #endregion
    }
}