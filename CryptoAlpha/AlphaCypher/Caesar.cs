using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaCypher
{
    public class Caesar : Vigenere
    {
        protected override string Letters
        {
            get
            {
                return "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            }
        }
        public Caesar() : base()
        {
            
        }
        
        //FATTO - FUNZIONA
        #region[ENCODE OK]
        public override string Encode(string text, string cypher)
        {
            string resp = "";
            for (int i = 0; i < text.Length; i++)
            {
                char tmp = base.Encode(text[i], cypher[0]);
                resp = resp + tmp.ToString();
            }
            return resp;
        }
        
        #endregion

        //FATTO - FUNZIONA
        #region[DECODE OK]
        public override string Decode(string text, string cypher)
        {
            string resp = "";

            for (int i = 0; i < text.Length; i++)
            {
                char tmp = base.Decode(text[i], cypher[0]);
                resp = resp + tmp.ToString();
            }

            return resp;
        }

        #endregion

        #region[ENCODE ASYNC]
        public override Task<string> EncodeAsync(string text, string cypher)
        {
            return Task.Factory.StartNew(() => Encode(text, cypher));
        }
        #endregion

        #region[DECODE ASYNC]
        public override Task<string> DecodeAsync(string text, string cypher)
        {
            return Task.Factory.StartNew(() => Decode(text, cypher));
        }
        #endregion


    }
}
