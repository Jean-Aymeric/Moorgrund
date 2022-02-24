using Moorgrund.shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moorgrund.model.parser.chainofresponsability {
    abstract class TokenHandler {
        protected string Token { get; set; }
        public TokenHandler Next { get; set; }

        public TokenHandler(string token) {
            Token = token;
            Next = null;
        }

        public abstract IMobile Execute(string token, IMobile mobile);
    }
}
