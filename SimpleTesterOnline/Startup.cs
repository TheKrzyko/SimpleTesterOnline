using Blazor.FileReader;
using Cloudcrate.AspNetCore.Blazor.Browser.Storage;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;
using SimpleTesterOnline.Services;
using Toolbelt.Blazor.Extensions.DependencyInjection;
namespace SimpleTesterOnline
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddFileReaderService(options => { options.UseWasmSharedBuffer = true; options.InitializeOnFirstCall = true; });
            services.AddStorage();
            services.AddSingleton<LocalAppStorage>();
            services.AddLoadingBar();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.UseLoadingBar();
            app.AddComponent<App>("app");
        }
    }
}
