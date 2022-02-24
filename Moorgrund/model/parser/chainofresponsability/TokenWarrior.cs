using Moorgrund.model.mobile.custom;
using Moorgrund.shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moorgrund.model.parser.chainofresponsability {
    class TokenWarrior : TokenHandler {
        public TokenWarrior() : base("warrior") { }

        public override IMobile Execute(string token, IMobile mobile) {
            if (token.ToLower().Equals(Token)) {
                return new Warrior(mobile);
            }
            return Next.Execute(token, mobile);
        }
    }
}
