using Artemis;
using SSAR.BattleSystem.Movement;

namespace SSAR.BattleSystem.AI
{
	public class SeekAction : AbsAction
	{
		private int changeFaceCount;

		private Direction[] directions;

		private Entity cameraEntity;

		public SeekAction(NewMonsterAIComponent aiComponent, ActionConfig config)
			: base(null, null)
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

		protected override bool IsExit()
		{
			return false;
		}

		public override bool IsRequireTarget()
		{
			return false;
		}
	}
}
