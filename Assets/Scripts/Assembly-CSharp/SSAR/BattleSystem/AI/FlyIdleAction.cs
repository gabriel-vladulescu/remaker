using UnityEngine;

namespace SSAR.BattleSystem.AI
{
	public class FlyIdleAction : AbsAction
	{
		public float amplitude;

		public float interval;

		private float frequency;

		private Vector3 direction;

		public FlyIdleAction(NewMonsterAIComponent aiComponent, ActionConfig config)
			: base(null, null)
		{
		}

		protected override void MapValue(ActionConfig config)
		{
		}

		protected override bool IsExit()
		{
			return false;
		}

		protected override void OnExcute()
		{
		}

		protected override void OnExcute(float deltaTime)
		{
		}
	}
}
