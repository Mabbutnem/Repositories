using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoriesConsole
{
   class ChildClass1 : IChildClass
   {
      public string Field1 { get; set; }

      public override string ToString()
      {
         return string.Format("#Field1: {0}#", Field1);
      }
   }
}
