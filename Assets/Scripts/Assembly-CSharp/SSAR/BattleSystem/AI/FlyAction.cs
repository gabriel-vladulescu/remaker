using SSAR.BattleSystem.Movement;
using UnityEngine;

namespace SSAR.BattleSystem.AI
{
	public class FlyAction : AbsAction
	{
		public bool changeDirectionOneTime;

		public float amplitude;

		public float interval;

		private float frequency;

		private Vector3 direction;

		private float randomRange;

		private Direction dir;

		private float time;

		public FlyAction(NewMonsterAIComponent aiComponent, ActionConfig config)
			: base(null, null)
		{
		}

		protected override void MapValue(ActionConfig config)
		{
		}

		protected override void OnChangeToAwake(bool cancelAnimation)
		{
		}

		protected override void OnExcute()
		{
		}

		protected override void OnExcute(float deltaTime)
		{
		}

		private Direction GetDir()
		{
			return default(Direction);
		}
	}
}
