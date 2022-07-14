using Elmah.Io.AspNetCore;
using Elmah.Io.Extensions.Logging;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevIO.Api.Configuration
{
    public static class LoggerConfig
    {
        public static IServiceCollection AddLoggingConfiguration(this IServiceCollection services)
        {
            services.AddElmahIo(o =>
            {
                o.ApiKey = "564e0d467ede4a9bb201cf673561ddfc";
                o.LogId = new Guid("793a9ed5-4e0e-4c64-82c8-4cc5d7783df6");
            });

            //services.AddLogging(builder => 
            //{
            //    builder.AddElmahIo(o =>
            //    {
            //        o.ApiKey = "564e0d467ede4a9bb201cf673561ddfc";
            //        o.LogId = new Guid("793a9ed5-4e0e-4c64-82c8-4cc5d7783df6");
            //    });
            //    builder.AddFilter<ElmahIoLoggerProvider>(null, LogLevel.Warning);
            //});

            return services;
        }

        public static IApplicationBuilder UseLoggingConfiguration(this IApplicationBuilder app)
        {
            app.UseElmahIo();

            return app;
        }
    }
}
