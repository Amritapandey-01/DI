Right-click:
App_Start → Add → Class
Name it:
NinjectConfig.cs
Add this complete code:
using Ninject;
using Ninject.Web.Mvc;
using System.Web.Mvc;
using DependencyInjectionDemo.Models;
namespace DependencyInjectionDemo.App_Start
{
public static class NinjectConfig
{
public static void RegisterDependencies()
{
IKernel kernel = new StandardKernel();
kernel.Bind<IStudentService>()
.To<StudentService>();
DependencyResolver.SetResolver(
new NinjectDependencyResolver(kernel)
);
}
}
}
