using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaCypher
{
    public class Caesar : CypherBase
    {

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

    }
}
