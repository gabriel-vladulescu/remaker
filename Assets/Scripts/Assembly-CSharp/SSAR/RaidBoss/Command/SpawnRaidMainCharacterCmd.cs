using Artemis;
using Assets.Scripts.Ssar.Dungeon.Command;
using SSAR.BattleSystem.EntityTemplate;
using UnityEngine;

namespace Ssar.RaidBoss.Command
{
	public class SpawnRaidMainCharacterCmd : SpawnMainCharacterCmd
	{
		protected override Vector3 PositionSpawn()
		{
			return default(Vector3);
		}

		protected override MainCharacterData MainCharacterData()
		{
			return null;
		}

		protected override Entity CreateEntityFromTemplate(MainCharacterTemplateArgs args)
		{
			return null;
		}

		protected override void CreateEntityFinish(Entity entity)
		{
		}

		protected override bool EnableModifyStatTest()
		{
			return false;
		}
	}
}
