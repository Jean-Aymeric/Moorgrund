using Moorgrund.model.mobile;
using Moorgrund.shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moorgrund.model.parser.chainofresponsability {
    class TokenParacrobunus : TokenHandler {
        public TokenParacrobunus() : base("heros") { }

        public override IMobile Execute(string token, IMobile mobile) {
            if (token.ToLower().Substring(0, Token.Length).Equals(Token)) {
                if (token.Substring(Token.Length, 1).Equals("(")) {
                    string temp = token.Substring(Token.Length);
                    temp = temp.Trim('(');
                    temp = temp.Trim(')');
                    string[] coord = temp.Split(',');
                    int x = Int16.Parse(coord[0]);
                    int y = Int16.Parse(coord[1]);
                    return new Paracrobunus(x, y, null);
                }
            }
            return Next.Execute(token, mobile);
        }
    }
}
