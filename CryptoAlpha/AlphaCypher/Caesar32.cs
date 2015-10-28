using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallF.BaseNEncodings;

namespace AlphaCypher
{
    public class Caesar32 : Caesar
    {
        new List<Char> _vettAlfabeto;
        string alphabet32;
        public Caesar32() : base()
        {
            alphabet32 = Base32Encoding.STANDARD_ALPHABET;
            InitializeAlphabet();
        }
        public override void InitializeAlphabet()
        {
            for (int i = 0; i < alphabet32.Length; i++)
            {
                char temp = (char)i;
               _vettAlfabeto.Add(temp);                
            }
        }                
    }
}
