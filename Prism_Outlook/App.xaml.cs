using Prism_Outlook.Views;
using Prism.Ioc;
using Prism.Modularity;
using System.Windows;
using Prism_Outlook.Modules.Mail;
using Prism_Outlook.Modules.Contacts;

namespace Prism_Outlook
{
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<MailModule>();
            moduleCatalog.AddModule<ContactsModule>();
        }
    }

}
