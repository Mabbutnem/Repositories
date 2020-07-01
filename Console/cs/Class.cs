using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RepositoriesConsole
{
   class Class
   {
      public string Field1 { get; set; }
      public IChildClass[] List { get; set; }
      public IChildClass Child { get; set; }

      public override string ToString()
      {
         return string.Format("#Field1: {0}, List: [{1}], Child: {2}#",
            Field1,
            List.Select(c => c.ToString()).Aggregate((str1, str2) => str1 + ", " + str2),
            Child);
      }
   }
}
