﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallF.BaseNEncodings;

namespace AlphaCypher
{
    public class Caesar32 : Caesar
    {
        public override string Encode(string text, string cypher)
        {
            string resp = "";
            string tmp = base.Encode(text, cypher);
            byte[] vettToEncode = Encoding.UTF8.GetBytes(tmp);
            char[] Encoded = Base32Encoding.Base32.Encode(vettToEncode);
            resp = new string(Encoded);
            return resp;
        }
        public override string Decode(string text, string cypher)
        {
            string resp = "";
            //string tmp = base.Decode(text, cypher);
            //char[] vettToDecode = tmp.ToCharArray();
            //byte[] Decoded = Base32Encoding.Base32.Decode(vettToDecode);
            // resp = Encoding.UTF8.GetString(Decoded,0,Decoded.Length);
            return resp;
        }
    }
}
