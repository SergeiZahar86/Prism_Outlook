using Prism_Outlook.Modules.Mail.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using Prism_Outlook.Core;

namespace Prism_Outlook.Modules.Mail
{
    public class MailModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public MailModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            //_regionManager.RegisterViewWithRegion(RegionNames.OutlookGroupRegion, typeof(MailGroup));
            _regionManager.RegisterViewWithRegion(RegionNames.ContentRegion, typeof(ViewA));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            //ViewModelLocationProvider.Register<MailGroup, MailGroupViewModel>();

            //containerRegistry.RegisterForNavigation<MailList, MailListViewModel>();
            //containerRegistry.RegisterForNavigation<MessageView, MessageViewModel>();
            //containerRegistry.RegisterForNavigation<MessageReadOnlyView, MessageReadOnlyViewModel>();

            //containerRegistry.RegisterSingleton<IMailService, MailService>();

            //containerRegistry.RegisterDialog<MessageView, MessageViewModel>();
        }
    }
}