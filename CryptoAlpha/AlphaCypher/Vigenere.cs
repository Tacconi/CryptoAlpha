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
        protected override string Letters
        {
            get
            {
                return "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            }
        }
        //FATTO - FUNZIONA
        #region[ENCODE]
        public override string Encode(string text, string cypher)
        {
            string resp = "";
            for (int i = 0; i < text.Length; i++)
                resp += base.Encode(text[i], cypher[i % cypher.Length]);
            return resp;
        }
        #endregion

        //FATTO - FUNZIONA
        #region[DECODE]
        public override string Decode(string text, string cypher)
        {
            string resp = "";
            for (int i = 0; i < text.Length; i++)
                resp += base.Decode(text[i], cypher[i % cypher.Length]);
            return resp;
        }


        #endregion

        //FATTO - FUNZIONA
        #region[ENCODE ASYNC]
        public override Task<string> EncodeAsync(string text, string cypher)
        {
            return Task.Factory.StartNew(() => Encode(text, cypher));
        }
        #endregion

        //FATTO - FUNZIONA
        #region[DECODE ASYNC]
        public override Task<string> DecodeAsync(string text, string cypher)
        {
            return Task.Factory.StartNew(() => Decode(text, cypher));
        }
        #endregion
    }
}
