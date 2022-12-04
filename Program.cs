using System;

namespace TryParse {
    internal class Program {
        public static void Main(string[] args) {
            int result;
            if (!int.TryParse(s: Console.ReadLine(), result: out result))
                Console.Write(value: "Input a number "); 
        }

        public static bool TryParse(string s, out int result) {
            bool parsed;
            int tempRes = 0;
            result = tempRes;

            try {

                result = Convert.ToInt32(value: s);
                parsed = true;

                if (parsed == true) {
                    return true;
                }

            } catch (System.Exception) {

                parsed = false;

                if (parsed == false) {
                    return false;
                }

            }

            return false;
        }
    }
}