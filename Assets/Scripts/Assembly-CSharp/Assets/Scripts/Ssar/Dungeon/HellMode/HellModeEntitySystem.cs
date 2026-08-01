using Artemis.System;

namespace Assets.Scripts.Ssar.Dungeon.HellMode
{
	public class HellModeEntitySystem : EntitySystemWithTime
	{
		private HellModeLogic hellModeLogic;

		public HellModeEntitySystem(HellModeLogic hellModeLogic)
		{
		}

		protected override void Process(float deltaTime)
		{
		}
	}
}
