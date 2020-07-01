using System;

namespace Repositories
{
   public interface IRepository<T>
   {
      T[] FindAll();
   }
}
