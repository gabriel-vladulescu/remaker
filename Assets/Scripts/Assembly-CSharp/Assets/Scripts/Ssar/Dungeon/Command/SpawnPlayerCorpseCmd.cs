using Artemis;
using Assets.Scripts.Ssar.Dungeon.Model;
using SSAR.BattleSystem.EntityTemplate;
using UnityEngine;

namespace Assets.Scripts.Ssar.Dungeon.Command
{
	public class SpawnPlayerCorpseCmd : AbsSpawnCharacterCmd
	{
		[Inject]
		public PlayerCorpseData Parameter { get; set; }

		protected override MainCharacterData MainCharacterData()
		{
			return null;
		}

		protected override Vector3 PositionSpawn()
		{
			return default(Vector3);
		}

		protected override Entity CreateEntityFromTemplate(MainCharacterTemplateArgs args)
		{
			return null;
		}

		protected override void CreateEntityFinish(Entity entity)
		{
		}

		protected override bool EnableSummonPest()
		{
			return false;
		}
	}
}
