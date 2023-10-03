using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArdalisRating
{
    internal class Print
    {
        public static string FinalText() {
            return "Rating completed.";
        }
        public static void TextoInicial() {
            Console.WriteLine("Starting rate.\n" + "Loading policy.");
        }
        public static void TextoPolicy(string policyText) {
            Console.WriteLine($"Rating {policyText} policy...");
            Console.WriteLine("Validating policy.");

        }
        public static string Default(){
            return "Unknown policy type";
        }
        
        
    }
}
