using Newtonsoft.Json;
using System.IO;

namespace Repositories
{
   public class JsonRepository<T> : IRepository<T>
   {
      private readonly string file;

      public JsonRepository(string file)
      {
         this.file = file;
      }

      public T[] FindAll()
      {
         using StreamReader r = new StreamReader("../../../Resources/" + file + ".json");
         string json = r.ReadToEnd();
         return JsonConvert.DeserializeObject<T[]>(json);
      }
   }
}
