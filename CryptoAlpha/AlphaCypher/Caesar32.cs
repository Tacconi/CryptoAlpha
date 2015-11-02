using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallF.BaseNEncodings;

namespace AlphaCypher
{
    public class Caesar32 : Vigenere
    {
        protected override string Letters
        {
            get
            {
                return "ABCDEFGHIJKLMNOPQRSTUVWXYZ23567=";
            }
        }

        public override string Encode(string text, string cypher)
        {
            string resp = "";

            char[] text32 = Base32Encoding.Base32.Encode(Encoding.UTF8.GetBytes(text));
            char[] cypher32 = Base32Encoding.Base32.Encode(Encoding.UTF8.GetBytes(cypher));

            string stringText32 = new string(text32);
            string stringcypher32 = new string(cypher32);

            resp = base.Encode(stringText32,stringcypher32);

            return resp;
        }
        public override string Decode(string text, string cypher)
        {
            string resp = "";

            char[] cypher32 = Base32Encoding.Base32.Encode(Encoding.UTF8.GetBytes(cypher));
            string stringcypher32 = new string(cypher32);

            resp = base.Decode(text, stringcypher32);
            return resp;
        }
    }
}
