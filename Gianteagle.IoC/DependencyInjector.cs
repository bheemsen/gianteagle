using System;
using System.Collections.Generic;
using System.Text;
using Gianteagle.BAL.IServices;
using Gianteagle.BAL.Services;
using Gianteagle.DAL;
using Gianteagle.DAL.Repositories;
using Gianteagle.DAL.Repositories.IRepositories;
using Gianteagle.DTO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Gianteagle.IoC
{
    public class DependencyInjector
    {
        private readonly IConfiguration Configuration;
        public DependencyInjector(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void InjectDependencies(IServiceCollection services)
        {
            services.AddDbContext<GianteagleDbContext>(dbContextOptions =>
            {
                dbContextOptions.UseSqlServer(Configuration.GetConnectionString("ConnectionString"));
            });

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IRepository<User>, Repository<User>>();
            services.AddScoped<IUnitOfWorkRepository, UnitOfWorkRepository>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IProductService, ProductService>();
            


        }
    }
}
