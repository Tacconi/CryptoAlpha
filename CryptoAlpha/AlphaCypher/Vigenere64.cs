using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallF.BaseNEncodings;

namespace AlphaCypher
{
    public class Vigenere64 : Vigenere
    {
        protected override string Letters
        {
            get
            {
                return "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/=";
            }
        }

        public override string Encode(string text, string cypher)
        {
            string resp = "";
            char[] text64 = BaseEncoding.Base64.Encode(Encoding.UTF8.GetBytes(text));
            char[] cypher64 = BaseEncoding.Base64.Encode(Encoding.UTF8.GetBytes(cypher));
            string stringText64 = new string(text64);
            string stringCypher64 = new string(cypher64);
            resp = base.Encode(stringText64, stringCypher64);
            return resp;
        }
        public override string Decode(string text, string cypher)
        {
            string resp = "";
            char[] cypher64 = BaseEncoding.Base64.Encode(Encoding.UTF8.GetBytes(cypher));
            string stringCypher64 = new string(cypher64);
            string stringText64 = base.Decode(text, stringCypher64);
            byte[] text64 = BaseEncoding.Base64.Decode(stringText64.ToCharArray());
            resp = Encoding.UTF8.GetString(text64, 0, text64.Length);
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


