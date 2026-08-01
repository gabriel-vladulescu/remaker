using Assets.Scripts.Ssar.Common.Pooling;

namespace SSAR.Dungeon.HUD
{
	public class HUDGameObjectItem : GameObjectItem
	{
		private bool isActive;

		public override bool IsActive()
		{
			return false;
		}

		public override void OnObtain()
		{
		}

		public override void OnReturn()
		{
		}
	}
}
