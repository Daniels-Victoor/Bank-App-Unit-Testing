using Core.Abstractions;
using Core.Helper;
using Core.Implimentations;
using Core.Services;
using DiscoveryBankUi;
using FluentAssertions.Common;
using Microsoft.Extensions.DependencyInjection;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscoveryBank
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


             var services = new ServiceCollection();

            ConfigureServices(services);

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var form1 = serviceProvider.GetRequiredService<LogInBtn>();
                Application.Run(form1);
            }
          
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddScoped<IFileWriteRead, FileWriteRead>();
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<IAutheticationServices, AutheticationServices>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<ITransactionService, TransactionService>();
            services.AddScoped<LogInBtn>();
            services.AddScoped<RegisterAsAUser>();
            services.AddScoped<RegistrationPage>();
          
        }
    }
}
