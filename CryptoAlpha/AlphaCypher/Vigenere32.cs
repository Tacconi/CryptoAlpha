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
        protected override string Letters
        {
            get
            {
                return "ABCDEFGHIJKLMNOPQRSTUVWXYZ234567=";
            }
        }
        public override string Encode(string text, string cypher)
        {
            string resp = "";
            char[] text32 = BaseEncoding.Base32.Encode(Encoding.UTF8.GetBytes(text));
            char[] cypher32 = BaseEncoding.Base32.Encode(Encoding.UTF8.GetBytes(cypher));
            string stringText32 = new string(text32);
            string stringCypher32 = new string(cypher32);
            resp = base.Encode(stringText32, stringCypher32);
            return resp;
        }
        public override string Decode(string text, string cypher)
        {
            string resp = "";
            char[] cypher32 = BaseEncoding.Base32.Encode(Encoding.UTF8.GetBytes(cypher));
            string stringCypher32 = new string(cypher32);
            string stringText32 = base.Decode(text, stringCypher32);
            byte[] text32 = BaseEncoding.Base32.Decode(stringText32.ToCharArray());
            resp = Encoding.UTF8.GetString(text32, 0, text32.Length);
            return resp;

        }
        public override Task<string> EncodeAsync(string text, string cypher)
        {
            return Task.Factory.StartNew(() => Encode(text, cypher));
        }
        public override Task<string> DecodeAsync(string text, string cypher)
        {
            return Task.Factory.StartNew(() => Decode(text, cypher));
        }


    }
}
