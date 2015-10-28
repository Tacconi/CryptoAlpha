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
        
        //FATTO
        #region[ENCODE]
        public string Encode(string text, string cypher)
        {
            string resp = "";
            int spiazzamento = ReserchLetter(cypher.ToUpper()[0]);
            resp = Encode(text.ToUpper(), spiazzamento);
            return resp;
        }
        
        #endregion

        //FATTO
        #region[DECODE]
        public string Decode(string text, string cypher)
        {
            string resp = "";
            int spiazzamento = ReserchLetter(cypher.ToUpper()[0]);
            resp = Decode(text.ToUpper(), spiazzamento);
            return resp;
        }

        #endregion     
    }
}
