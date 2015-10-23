using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaCypher
{
    public class Caesar : ICypher
    {

        protected List<Char> _vettAlfabeto;
        public Caesar()
        {
            _vettAlfabeto = new List<char>();
            InitializeAlphabet();
        }

        #region[INITIALIZE ALPHABET & RESERCH LETTER]
        protected virtual void InitializeAlphabet()
        {
            for (int i = 0; i < 26; i++)
            {
                char tmp = (char)(i + 65);
                _vettAlfabeto.Add(tmp);
            }
        }
        private int ReserchLetter(char tmp)
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

        #region[ENCODE]
        public string Encode(string text, string cypher)
        {
            string resp = "";
            int spiazzamento = ReserchLetter(cypher.ToUpper()[0]) + 1;
            resp = Encode(text.ToUpper(), spiazzamento);
            return resp;
        }
        protected string Encode(string testo, int codice)
        {
            string resp = "";
            char[] s = testo.ToCharArray();
            for (int i = 0; i < s.Length; i++)
            {
                char tmp = s[i];
                int pos = ReserchLetter(tmp);             
                int posCodificata = (pos + codice) % 26;      
                resp += _vettAlfabeto[posCodificata];
            }
            return resp;
        }
        #endregion

        #region[DECODE]
        public virtual string Decode(string text, string cypher)
        {
            throw new NotImplementedException();

        }

        #endregion

        #region[ENCODE ASYNC]
        public Task<string> EncodeAsync(string text, string cypher)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region[DECODE ASYNC]
        public Task<string> DecodeAsync(string text, string cypher)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
