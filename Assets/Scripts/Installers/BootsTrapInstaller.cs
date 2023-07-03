using Model;
using Presenter;
using UI;
using UI.Model;
using UI.View;
using View;
using Zenject;

namespace Installers
{
    public class BootsTrapInstaller : MonoInstaller
    {
        public Buttons buttons;
        public MoreLessView view;
        
        public override void InstallBindings()
        {
            Container.Bind<Buttons>().FromInstance(buttons);
        
            Container.Bind<MoreLessPresenter>().AsSingle();
            Container.Bind<MoreLessModel>().AsSingle();
            Container.Bind<IMoreLessView>().To<MoreLessView>().FromInstance(view);
        }
    }
}