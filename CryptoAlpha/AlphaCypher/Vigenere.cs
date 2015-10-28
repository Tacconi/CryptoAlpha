using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaCypher
{
    public class Vigenere : CypherBase
    {
        public Vigenere() : base()
        {

        }

        public override string Encode(string text, string cypher)
        {
            string resp = "";
            for (int i = 0; i < text.Length; i++)
                resp += base.Encode(text[i], cypher[i % cypher.Length]);
            return resp;
        }
        


    }
}
