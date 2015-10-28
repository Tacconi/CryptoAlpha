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

        #region[ENCODE OK]
        protected virtual string Encode(string text, int cypher)
        {
            string resp = "";
            char[] s = text.ToCharArray();
            for (int i = 0; i < s.Length; i++)
            {
                char tmp = s[i];
                int pos = ReserchLetter(tmp);
                int posCodificata = (pos + cypher) % 26;
                resp += _vettAlfabeto[posCodificata];
            }
            return resp;
        }
        #endregion

        #region[DECODE OK]

        protected virtual string Decode(string text, int cypher)
        {
            string resp = "";
            char[] s = text.ToCharArray();
            for (int i = 0; i < s.Length; i++)
            {
                char tmp = s[i];
                int pos = ReserchLetter(tmp);
                int decodedPos = (pos - cypher + 26) % 26;
                resp += _vettAlfabeto[decodedPos];
            }
            return resp;

        }
        #endregion

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

        public string Decode(string text, string cypher)
        {
            throw new NotImplementedException();
        }

        public string Encode(string text, string cypher)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
