using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProyectoTaza
{
    public abstract class StateMachine
    {
        protected IState currentState;

        public void changeState(IState newState)
        {
            currentState?.Exit();

            currentState = newState;

            currentState.Enter();
        }

        public void HandleInput()
        {
            currentState?.HandleInput();
        }
        public void Update()
        {
            currentState?.Update();
        }
        public void PhysicsUpdate()
        {
            currentState?.PhysicsUpdate();
        }

    }
}
