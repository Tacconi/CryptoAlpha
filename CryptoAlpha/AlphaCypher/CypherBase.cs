using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaCypher
{
    public abstract class CypherBase : ICypher
    {
        protected List<Char> _vettAlfabeto;
        protected virtual string Letters
        {
            get
            {
                return "";
            }
        }
        public CypherBase()
        {
            _vettAlfabeto = new List<char>();
            InitializeAlphabet();
        }

        #region[INITIALIZE ALPHABET & RESERCH LETTER]

        public virtual void InitializeAlphabet()
        {
            for (int i = 0; i < Letters.Length; i++)
            {
                _vettAlfabeto.Add(Letters[i]);
            }
        }
        public virtual int ReserchLetter(char tmp)
        {
            int resp = 0;        
            resp = _vettAlfabeto.IndexOf(tmp);
            return resp;
        }
        #endregion

        //Funzionante
        #region[ENCODE OK]

        public abstract string Encode(string text, string cypher);
        

        protected char Encode(char text, char cypher)
        {
            char resp;
            int pos = ReserchLetter(text);
            int posCypher = ReserchLetter(cypher);
            int posCodificata = (pos + posCypher) % _vettAlfabeto.Count;
            resp = _vettAlfabeto[posCodificata];
            return resp;
        }

        #endregion

        //Funzionante
        #region[DECODE OK]
        public abstract string Decode(string text, string cypher);
        

        protected char Decode(char text, char cypher)
        {
            char resp;
            int pos = ReserchLetter(text);
            int posCypher = ReserchLetter(cypher);
            int posCodificata = (pos - posCypher + _vettAlfabeto.Count) % _vettAlfabeto.Count;
            resp = _vettAlfabeto[posCodificata];
            return resp;

        }
        #endregion


        #region[ENCODE ASYNC]
        public abstract Task<string> EncodeAsync(string text, string cypher);


        #endregion

        #region[DECODE ASYNC]
        public abstract Task<string> DecodeAsync(string text, string cypher);
        

      


        #endregion
    }
}
