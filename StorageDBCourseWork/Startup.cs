using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StorageDBCourseWork.Startup))]
namespace StorageDBCourseWork
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
