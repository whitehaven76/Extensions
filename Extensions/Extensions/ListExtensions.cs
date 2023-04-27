using System.Collections.Generic;
using System.Linq;

namespace Extensions {

    public static class ListExtensions {

        public static bool IsEmpty(this IEnumerable<object> list) => !list.Any();

    }

}