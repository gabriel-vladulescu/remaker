using Artemis;
using SSAR.BattleSystem.Movement;

namespace SSAR.BattleSystem.AI
{
	public class AttackAction : AbsAction
	{
		private Entity target;

		private CharacterMediatorComponent sourCmc;

		private CharacterMediatorComponent targetCmc;

		public AttackAction(NewMonsterAIComponent aiComponent, ActionConfig config)
			: base(null, null)
		{
		}

		protected override void MapValue(ActionConfig config)
		{
		}

		protected override void OnExcute()
		{
		}

		protected override void OnExcute(float deltaTime)
		{
		}

		protected override void OnExit()
		{
		}
	}
}
