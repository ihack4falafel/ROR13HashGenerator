using System;

// reference: https://www.tophertimzen.com/blog/shellcodeTechniquesCPP/
namespace ROR13HashGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Usage: ROR13HashGenerator <function name>");
                Console.ForegroundColor = ConsoleColor.White;
                System.Environment.Exit(1);
            }
            string FunctionName = args[0];
            int functionPreHash = (int)ROR13Hash(FunctionName, 13);
            int functionHash = (int)(functionPreHash & 0xFFFFFFFF);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Function Name = {0}", FunctionName);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("ROR13 Hash    = 0x{0:X}", functionHash);
            Console.ForegroundColor = ConsoleColor.White;
            System.Environment.Exit(1);
        }

        public static uint ROR13Hash(string FunctionName, int bits)
        {
            uint functionHash = 0;
            foreach (char c in FunctionName)
            {
                uint i = (uint)c;
                functionHash = ROR13(functionHash, 13);
                functionHash = (functionHash + i);
            }
            return functionHash;
        }

        public static uint ROR13(uint FucntionHash, int bits)
        {
            return ((FucntionHash >> bits | FucntionHash << (32 - bits)) & 0xFFFFFFFF);
        }
    }
}
