using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallF.BaseNEncodings;

namespace AlphaCypher
{
    public class Vigenere32 : Vigenere
    {
        public override string Encode(string text, string cypher)
        {
            string resp = "";
            string tmp = base.Encode(text, cypher);
            byte[] vettToEncode = Encoding.UTF8.GetBytes(tmp);
            char[] Encoded = Base32Encoding.Base32.Encode(vettToEncode);
            resp = new string(Encoded);
            return resp;
        }
        public override string Decode(string text, string cypher)
        {
            return "";
        }
        
    }
}
