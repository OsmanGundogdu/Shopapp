using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using shopapp.data.Concrete.EfCore;
using shopapp.webui.Identity;

namespace shopapp.webui.Extensions
{
    public static class MigrationManager
    {
        public static IHost MigrateDatabase(this IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                using (var applicationContext = scope.ServiceProvider.GetRequiredService<ApplicationContext>())
                {
                    try
                    {
                        applicationContext.Database.Migrate();
                    }
                    catch (System.Exception)
                    {
                        // loglama: Loglama, bilgisayar sistemlerindeki olayları, hataları ve diğer önemli durumları 
                        // kaydetme işlemidir. Bu kayıtlar, sistem yöneticileri ve geliştiriciler tarafından, 
                        // sistemlerin işleyişini anlamak, hataları tespit etmek ve geliştirmeler yapmak için kullanılır. 
                        // Loglama genellikle yazılım uygulamalarında kullanılır.
                        throw;
                    }
                }

                using (var shopContext = scope.ServiceProvider.GetRequiredService<ShopContext>())
                {
                    try
                    {
                        shopContext.Database.Migrate();
                    }
                    catch (System.Exception)
                    {
                        throw;
                    }
                }
            }
        
            return host;
        }
    }
}