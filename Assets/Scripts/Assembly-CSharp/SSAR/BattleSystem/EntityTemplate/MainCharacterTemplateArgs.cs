using Assets.Scripts.Config.Stats;
using Assets.Scripts.Ssar.Combat.Skills;
using Assets.Scripts.Ssar.Dungeon.Model;
using SSAR.Dungeon.HUD;
using Scripts.Config.Stats;
using UnityEngine;

namespace SSAR.BattleSystem.EntityTemplate
{
	public class MainCharacterTemplateArgs : BaseHeroTemplateArgs
	{
		public MainCharacterData MainCharacterData;

		public MainCharacterTemplateArgs(HeroData heroData, EntityAbilities abilities, Vector3 pos, GameObject instance, MainCharacterData mainCharacterData, HpBarType hpBarType = HpBarType.SMALL)
			: base(null, null, default(Vector3), null, default(HpBarType))
		{
		}

		public MainCharacterTemplateArgs(HeroData heroData, EntityAbilities abilities, Vector3 pos, GameObject instance, HpBarType hpBarType, int spawnedTicketId, SpawnSource spawnSource, SkillEventFrameConfig[] sefcs = null)
			: base(null, null, default(Vector3), null, default(HpBarType))
		{
		}
	}
}
