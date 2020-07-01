using System.IO;
using YamlDotNet.Serialization;

namespace Repositories
{
   public class YamlRepository<T> : IRepository<T>
   {
      private readonly string file;
      private readonly IDeserializer deserializer;

      public YamlRepository(string file, IDeserializer deserializer) //TODO: Remove from constructor and set a global yaml deserializer
      {
         this.file = file;
         this.deserializer = deserializer;
      }

      public T[] FindAll()
      {
         using StreamReader r = new StreamReader("../../../Resources/" + file + ".yaml");
         string yaml = r.ReadToEnd();
         return deserializer.Deserialize<T[]>(yaml);
      }
   }
}
