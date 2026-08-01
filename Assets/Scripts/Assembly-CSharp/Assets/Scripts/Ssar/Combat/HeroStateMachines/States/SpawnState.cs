using System;
using Assets.Scripts.Core.FiniteStateMachine;
using Checking;

namespace Assets.Scripts.Ssar.Combat.HeroStateMachines.States
{
	public class SpawnState : State
	{
		private Animation animation;

		private bool isSpawnAnimationEnd;

		private NotNullReference notNullReference;

		public SpawnState(Animation animation)
		{
			this.animation = animation;
		}

		public string Name()
		{
			return StateName.SPAWN;
		}

		public void Execute(float dt, StateMachine stateMachine)
		{
			if (isSpawnAnimationEnd)
			{
				stateMachine.ChangeStateWithHistory(StateName.IDLE);
			}
		}

		public void Enter(bool resume, string fromStateName)
		{
			isSpawnAnimationEnd = false;
			animation.ListenToSpawnAnimationEnd(OnSpawnAnimationEnd);
			animation.PlaySpawn();
		}

		public void Exit()
		{
			animation.UnlistenToSpawnAnimationEnd(OnSpawnAnimationEnd);
		}

		private void OnSpawnAnimationEnd(object source, EventArgs args)
		{
			isSpawnAnimationEnd = true;
		}
	}
}
