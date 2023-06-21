using Infrastructure.StateMachine.States;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

namespace Infrastructure
{
    public class Bootstrapper : MonoBehaviour, ICoroutineRunner
    {
        private Game _game;

        private void Awake()
        {
            _game = new Game(this);
            _game.StateMachine.Enter<BootstrapState>();
            

            DontDestroyOnLoad(this);
        }
    }
}
