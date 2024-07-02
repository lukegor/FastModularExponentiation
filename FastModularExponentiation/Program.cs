namespace FastModularExponentiation
{
    public class Program
    {
        static void Main(string[] args)
        {
            int y = ReadInteger("Enter a: ");
            int exp = ReadInteger("Enter exponent: ");
            int mod = ReadInteger("Enter modulo: ");

            Console.WriteLine();

            int result = ModularExponentiation(y, exp, mod);
            Console.WriteLine();
            Console.WriteLine($"Result: {result}");

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }

        static int ReadInteger(string prompt)
        {
            Console.Write(prompt);
            return int.Parse(Console.ReadLine());
        }

        public static int ModularExponentiation(int y, int exp, int mod)
        {
            string binary = Convert.ToString(exp, 2);
            char[] binaryArray = binary.ToCharArray();
            Array.Reverse(binaryArray);

            int x = 1;

            Console.WriteLine($"{"i",2} | {"x",8} | {"a",8} | {"t_i"}");

            for (int i = 0; i < binaryArray.Length; ++i)
            {
                Console.WriteLine($"{i,2} | {x,8} | {y,8} | {binaryArray[i]}");
                x = binaryArray[i] == '0' ? x : (x * y) % mod;
                y = (y * y) % mod;
            }

            Console.WriteLine($"{binaryArray.Length,2} | {x,8} | {y,8} | -");
            return x;
        }
    }
}
