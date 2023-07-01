using UnityEngine;

namespace Infrastructure.StateMachine.States
{
    public class BootstrapState : IState
    {
        private const string InitialSceneName = "Initial";
        private const string GameMoreLess = "GameMoreLess";
        private readonly GameStateMachine _stateMachine;
        private SceneLoader _sceneLoader;

        public BootstrapState(GameStateMachine stateMachine, SceneLoader sceneLoader)
        {
            _stateMachine = stateMachine;
            _sceneLoader = sceneLoader;
        }
        
        public void Enter()
        {
            RegisterServices();
            _sceneLoader.Load(InitialSceneName, EnterLoadLevel);
        }

        private void EnterLoadLevel()
        {
            _stateMachine.Enter<LoadGameState, string>(GameMoreLess);
        }

        private void RegisterServices()
        {
            Debug.Log("Register sevices");
        }

        public void Exit()
        {
            
        }
        
    }
}