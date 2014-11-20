
namespace Com.Orzyourself.UserLimit.DALFactory
{

     public partial  class DalFactory
     {
         public static readonly string LimitAssemblyName;
         public static readonly string LimitNameSpace;

         static DalFactory() //
         {
             LimitAssemblyName = System.Configuration.ConfigurationManager.AppSettings["AssemblyName"];
             LimitNameSpace = System.Configuration.ConfigurationManager.AppSettings["NameSpace"];
         }

     }
}
