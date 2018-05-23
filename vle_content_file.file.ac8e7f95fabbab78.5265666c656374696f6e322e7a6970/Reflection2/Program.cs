using System;
using System.Reflection;
using System.Linq;

namespace Reflection2
{
    //Fuente: https://johnlnelson.com/tag/type-getinterfaces/
    class Program
    {
        static void Main(string[] args)
        {
            var a = Assembly.LoadFile(@"C:\Users\sfigu\Desktop\vle_content_file.file.ac8e7f95fabbab78.5265666c656374696f6e322e7a6970\Reflection2\bin\Debug\netcoreapp2.0\ClassLibrary1.dll");
            Type[] types = a.GetTypes();
            foreach (Type type in types)
            {
                if (!type.IsPublic)
                {
                    continue;
                }

                MemberInfo[] members = type.GetMembers(BindingFlags.Public
                                                      | BindingFlags.Instance
                                                      | BindingFlags.InvokeMethod);
                foreach (MemberInfo member in members)
                {
                    Console.WriteLine(member.MemberType + "." + type.Name + "." + member.Name + "." + member.MetadataToken);
                }
            }
            Console.ReadLine();
        }
    }
}
