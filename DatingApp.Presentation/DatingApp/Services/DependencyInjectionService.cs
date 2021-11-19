using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using AutoMapper;
using DatingApp.BusinesLogic.Services;
using DatingApp.BusinesLogic.Services.Interfaces;
using DatingApp.DataAccessLayer.Models;
using DatingApp.DataAccessLayer.Repositories;
using DatingApp.DataAccessLayer.Repositories.Interfaces;
using DatingApp.Presentation.Interfaces;
using DatingApp.Presentation.NavigationService;
using DatingApp.Presentation.Services.Interfaces;
using DatingApp.Presentation.WindowsForm;
using Microsoft.EntityFrameworkCore;
using SimpleInjector;
using SimpleInjector.Diagnostics;

namespace DatingApp.Presentation.Services
{
    public static class DependencyInjectionService
    {
        public static Container Container { get; set; }
        public static Container Bootstrap()
        {
            var container = new Container();

            container.Register<IFormOpener, FormOpener>(Lifestyle.Singleton);
            container.Register<IChatService, ChatService>();
            container.Register<IProfileService, ProfileService>();
            container.Register<IRegistrationService, RegistrationService>();
            container.Register<ISearchService, SearchService>();
            container.Register<IUserService, UserService>();
            container.Register<ILookupTypeService, LookupTypeService>();
            container.Register<ILookupValueService, LookupValueService>();
            container.Register<IChatRepository, ChatRepository>();
            container.Register<IProfileRepository, ProfileRepository>();
            container.Register<ILookupTypeRepository, LookupTypeRepository>();
            container.Register<ILookupValueRepository, LookupValueRepository>();
            container.Register<IRegistrationRepository, RegistrationRepository>();
            container.Register<IUnitOfWork, NewUnitOfWork>();
            container.Register<IChatSelected, ChatSelected>(Lifestyle.Singleton);
            container.Register<ProfileSelected, ProfileSelected>(Lifestyle.Singleton);

            container.Register(() =>
            {
                var options = new DbContextOptionsBuilder<DatingAppWinFormsContext>().UseSqlServer("Server=DESKTOP-BMNM0ER;Database=DatingAppWinForms;Trusted_Connection=True;").Options;
                return new DatingAppWinFormsContext(options);
            }, Lifestyle.Singleton);
            AutoRegisterWindowsForms(container);
            container.Verify();
            Container = container;
            return container;
        }

        private static void AutoRegisterWindowsForms(Container container)
            {
                var types = container.GetTypesToRegister<Form>(typeof(Program).Assembly);

                foreach (var type in types)
                {
                    var registration =
                        Lifestyle.Transient.CreateRegistration(type, container);

                    registration.SuppressDiagnosticWarning(
                        DiagnosticType.DisposableTransientComponent,
                        "Forms should be disposed by app code; not by the container.");

                    container.AddRegistration(type, registration);
                }
            }
    }
}
