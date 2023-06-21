using Infrastructure;
using UniRx;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class BootsTrapInstaller : MonoInstaller
{
    public ButtonsModel rollButton;
        
    public override void InstallBindings()
    {
        Container.Bind<ButtonsModel>().FromInstance(rollButton);
        Container.Bind<Test>().AsSingle().NonLazy();
    }
}