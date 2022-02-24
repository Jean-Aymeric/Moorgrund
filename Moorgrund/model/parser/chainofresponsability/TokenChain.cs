using Moorgrund.shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moorgrund.model.parser.chainofresponsability {
    class TokenChain : TokenHandler {
        private static TokenChain instance;

        private TokenChain() : base("Start") {
            TokenHandler temp = null;
            Next = new TokenParacrobunus();
            temp = Next;
            temp.Next = new TokenWoman();
            temp = temp.Next;
            temp.Next = new TokenWarrior();
            temp = temp.Next;
            temp.Next = new TokenError();
        }

        public static TokenChain getInstance() {
            if (TokenChain.instance == null) {
                TokenChain.instance = new TokenChain();
            }
            return TokenChain.instance;
        }

        public override IMobile Execute(string token, IMobile mobile) {
            return Next.Execute(token, mobile);
        }
    }
}
