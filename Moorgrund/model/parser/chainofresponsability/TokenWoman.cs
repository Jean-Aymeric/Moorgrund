using Moorgrund.model.mobile.custom;
using Moorgrund.shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moorgrund.model.parser.chainofresponsability {
    class TokenWoman : TokenHandler {
        public TokenWoman() : base("woman") { }

        public override IMobile Execute(string token, IMobile mobile) {
            if (token.ToLower().Equals(Token) || token.ToLower().Equals("femme")) {
                return new Woman(mobile);
            }
            return Next.Execute(token, mobile);
        }
    }
}
