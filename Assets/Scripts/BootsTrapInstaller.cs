using Infrastructure;
using UniRx;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class BootsTrapInstaller : MonoInstaller
{
    public Buttons buttons;
    public MoreLessView view;
        
    public override void InstallBindings()
    {
        Container.Bind<Buttons>().FromInstance(buttons);
        
        Container.Bind<Presenter>().AsSingle();
        Container.Bind<Model>().AsSingle();
        Container.Bind<IMoreLessView>().To<MoreLessView>().FromInstance(view);
    }
}