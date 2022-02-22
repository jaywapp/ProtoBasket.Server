using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using ProtoBasket.Common.Model;
using ProtoBasket.Common.Model.Repository;
using ProtoBasket.Server.Crawler.Service;

namespace ProtoBasket.Server.API
{
    public class Startup
    {
        public static ProtoRepository ProtoRepository { get; private set; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

            var no = CrawlingManager.CrawlProtoNo();
            var proto = CrawlingManager.Crawl(2022, no);

            ProtoRepository = new ProtoRepository(new List<Proto>() { proto, });
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
