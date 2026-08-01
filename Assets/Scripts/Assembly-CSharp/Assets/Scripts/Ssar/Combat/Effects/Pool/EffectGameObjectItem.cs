using System;
using Assets.Scripts.Ssar.Common.Pooling;

namespace Assets.Scripts.Ssar.Combat.Effects.Pool
{
	public class EffectGameObjectItem : GameObjectItem
	{
		public int initialSize;

		private Action undoAction;

		public void SetUndoAction(Action action)
		{
		}

		public override void OnObtain()
		{
		}

		public override void OnReturn()
		{
		}
	}
}
