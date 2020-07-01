using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoriesConsole
{
   class ChildClass2 : IChildClass
   {
      public string Field1 { get; set; }
      public string Field2 { get; set; }

      public override string ToString()
      {
         return string.Format("#Field1: {0}, Field2: {1}#", Field1, Field2);
      }
   }
}
