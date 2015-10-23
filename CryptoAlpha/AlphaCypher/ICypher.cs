using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaCypher
{
    public interface ICypher
    {
        string Decode(string text, string cypher);
        string Encode(string text, string cypher);
        Task<string> DecodeAsync(string text, string cypher);
        Task<string> EncodeAsync(string text, string cypher);
    }
}
