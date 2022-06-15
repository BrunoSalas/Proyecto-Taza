using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProyectoTaza
{
    public class PlayerMovementStateMachine : StateMachine
    {
        public PlayerIdlingState IdlingState { get; }
        public PlayerWalkingState WalkingState { get; }
        public PlayerRunnerState RunnerState { get; }
        public PlayerSpringState SpringState { get; }

        public PlayerMovementStateMachine()
        {
            IdlingState = new PlayerIdlingState();

            WalkingState = new PlayerWalkingState();

            RunnerState = new PlayerRunnerState();

            SpringState = new PlayerSpringState();
        }
    }
}
