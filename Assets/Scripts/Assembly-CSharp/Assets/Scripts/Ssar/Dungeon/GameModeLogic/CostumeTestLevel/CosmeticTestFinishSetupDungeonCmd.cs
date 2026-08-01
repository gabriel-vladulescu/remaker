using Artemis;
using Assets.Scripts.Ssar.Common.System.Resources;
using Assets.Scripts.Ssar.Dungeon.Command;
using UnityEngine;

namespace Assets.Scripts.Ssar.Dungeon.GameModeLogic.CostumeTestLevel
{
	public class CosmeticTestFinishSetupDungeonCmd : AdventureModeFinishSetupDungeonCmd
	{
		private int index;

		[Inject]
		public ResourcesLoader ResourcesLoader { get; set; }

		protected override void OnExcute()
		{
		}

		private void OnEntityDeath(Entity entity)
		{
		}

		private void ModifyMainStat()
		{
		}

		private void InitGate()
		{
		}

		private void Camera()
		{
		}

		private void SpawnMonster()
		{
		}

		private Vector3 Position()
		{
			return default(Vector3);
		}

		protected override bool EnableDungeonUpdate()
		{
			return false;
		}
	}
}
