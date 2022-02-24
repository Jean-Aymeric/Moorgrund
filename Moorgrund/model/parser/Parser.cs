using Moorgrund.model.parser.chainofresponsability;
using Moorgrund.shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moorgrund.model.parser {
    abstract class Parser {
        public static IMobile Parse(string text) {
            IMobile mobile = null;
            foreach(string token in text.Split(' ')) {
                mobile = TokenChain.getInstance().Execute(token, mobile);
            }
            return mobile;
        }
    }
}
