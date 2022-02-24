using Moorgrund.model.mobile;
using Moorgrund.shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moorgrund.model.parser.chainofresponsability {
    class TokenError : TokenHandler {
        public TokenError() : base("Error") {
        }

        public override IMobile Execute(string token, IMobile mobile) {
            return new Error();
        }
    }
}
