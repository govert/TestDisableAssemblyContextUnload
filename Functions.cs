using ExcelDna.Integration;
using System.Reflection;
using System.Runtime.Loader;

namespace TestDisableAssemblyContextUnload
{
    public static class Functions
    {
        public static object SayHello() => $"Hello from {ExcelDnaUtil.XllPathInfo.Name}!";

        public static object IsCollectible()
        {
            var ass = Assembly.GetExecutingAssembly();
            return $"{ass.FullName} is collectible: {AssemblyLoadContext.GetLoadContext(ass)!.IsCollectible}";
        }
    }
}