using System;
using Repositories;
using YamlDotNet.Serialization;

namespace RepositoriesConsole
{
   class Program
   {
      static void Main(string[] args)
      {
         IDeserializer globalDeserializer = new DeserializerBuilder()
            .WithTagMapping("!ChildClass1", typeof(ChildClass1))
            .WithTagMapping("!ChildClass2", typeof(ChildClass2))
            .Build();

         IRepository<Class> repo = new YamlRepository<Class>("class", globalDeserializer);
         foreach(Class @class in repo.FindAll())
         {
            Console.WriteLine(@class);
         }
      }
   }
}
