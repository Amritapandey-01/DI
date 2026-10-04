Tools → NuGet Package Manager → Package Manager Console
Run:
Install-Package Ninject.MVC5
You may not get:
NinjectWebCommon.cs
Then create your own:
NinjectConfig.cs
In Solution Explorer, expand:
References
Look for Ninject-related references.
You should have packages/references such as:
Ninject
Ninject.Web.Common
Ninject.Web.Mvc
If necessary, install them from Package Manager Console:
Install-Package Ninject
Install-Package Ninject.Web.Common
Install-Package Ninject.Web.Mvc


using System.Collections.Generic;
namespace DependencyInjectionDemo.Models
{

public interface IStudentService
{
List<string> GetStudents();
}
}
