using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MP_BusinessLogic.InterfacesDal;
using MP_BusinessLogic.InterfacesLL;
using MP_BusinessLogic.Services;
using MP_DataAccess.DALManagers;
using System;

namespace MP_WindowsFormsApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;
            Application.Run(ServiceProvider.GetRequiredService<LoginForm>());
        }

        public static IServiceProvider ServiceProvider { get; private set; }
        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {
                    services.AddTransient<IUserDalManager, UserDAL>();
                    services.AddTransient<IUserService, UserService>();
                    services.AddTransient<IBrandDalManager, BrandDAL>();
                    services.AddTransient<IBrandService, BrandService>();
                    services.AddTransient<ICategoryDalManager, CategoryDAL>();
                    services.AddTransient<ICategoryService, CategoryService>();
                    services.AddTransient<IDepartmentDalManager, DepartmentDAL>();
                    services.AddTransient<IDepartmentService, DepartmentService>();
                    services.AddTransient<IProductDalManager, ProductDAL>();
                    services.AddTransient<IProductService, ProductService>();
                    services.AddTransient<ISubCategoryDalManager, SubCategoryDAL>();
                    services.AddTransient<ISubCategoryService, SubCategoryService>();
                    services.AddTransient<LoginForm>();

                });
        }
    }
}