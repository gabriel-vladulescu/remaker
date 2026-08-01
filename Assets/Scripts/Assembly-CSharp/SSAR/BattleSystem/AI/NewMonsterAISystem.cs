using System.Collections.Generic;
using Artemis;
using Artemis.System;

namespace SSAR.BattleSystem.AI
{
	public class NewMonsterAISystem : EntityProcessingSystemWithTime
	{
		public bool enable;

		public bool enableUpdate;

		public NewMonsterAISystem(bool subscribeSimTime)
			: base(null, subscribeSimTime: false)
		{
		}

		public override void Process()
		{
		}

		protected override void Process(Entity entity, float deltaTime)
		{
		}

		private void ProcessEntity(Entity entity, float deltaTime)
		{
		}

		private void CheckTriggerAndSetAction(Entity entity, NewMonsterAIComponent AI, float deltaTime)
		{
		}

		private void SetNextAction(Entity entity, NewMonsterAIComponent AI, List<AbsAction> actions)
		{
		}

		private AbsAction GetNextAction(NewMonsterAIComponent AI, List<AbsAction> actions)
		{
			return null;
		}

		private bool CancelAnimation(AbsAction currentAction, AbsAction nextAction)
		{
			return false;
		}

		private void CheckAndCalculateTrigger(NewMonsterAIComponent AI, AbsAction currentAction, AbsAction nextAction, float deltaTime)
		{
		}

		private void UpdateAwakeCondition(NewMonsterAIComponent AI, AbsAction action, float deltaTime)
		{
		}

		private bool CanTrigger(NewMonsterAIComponent AI, AbsAction currentAction, AbsAction nextAction, AbsTrigger trigger)
		{
			return false;
		}

		private bool CanExcute(NewMonsterAIComponent AI, AbsAction currentAction, AbsAction nextAction)
		{
			return false;
		}
	}
}
