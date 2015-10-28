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

        public CypherBase()
        {
            _vettAlfabeto = new List<char>();
            InitializeAlphabet();
        }

        #region[INITIALIZE ALPHABET & RESERCH LETTER]
        public virtual void InitializeAlphabet()
        {
            for (int i = 0; i < 26; i++)
            {
                char tmp = (char)(i + 65);
                _vettAlfabeto.Add(tmp);
            }
        }
        public virtual int ReserchLetter(char tmp)
        {
            int resp = 0;
            for (int i = 0; i < _vettAlfabeto.Count; i++)
            {
                if (tmp == _vettAlfabeto[i])
                {

                    resp = i;
                }
            }
            return resp;
        }
        #endregion

        //Funzionante
        #region[ENCODE OK]

        public virtual string Encode(string text, string cypher)
        {
            return "";
        }

        protected char Encode(char text, char cypher)
        {
            char resp;
            int pos = ReserchLetter(text);
            int posCypher = ReserchLetter(cypher);
            int posCodificata = (pos + posCypher) % 26;
            resp = _vettAlfabeto[posCodificata];
            return resp;
        }

        #endregion

        //Funzionante
        #region[DECODE OK]
        public virtual string Decode(string text, string cypher)
        {
            return "";
        }

        protected char Decode(char text, char cypher)
        {
            char resp;
            int pos = ReserchLetter(text);
            int posCypher = ReserchLetter(cypher);
            int posCodificata = (pos - posCypher + 26) % 26;
            resp = _vettAlfabeto[posCodificata];

            return resp;

        }
        #endregion

        //TODO : Aggiungere Metodi ASYNC

        #region[ENCODE ASYNC]
        public virtual Task<string> EncodeAsync(string text, string cypher)
        {
            throw new NotImplementedException();

        }

        #endregion

        #region[DECODE ASYNC]
        public virtual Task<string> DecodeAsync(string text, string cypher)
        {
            throw new NotImplementedException();
        }

      


        #endregion
    }
}
