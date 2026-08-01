using System.Collections.Generic;
using Assets.Scripts.Ssar.Combat.Skills;
using Assets.Scripts.Ssar.Dungeon.Model;
using SSAR.Dungeon.HUD;
using Scripts.Config.Stats;
using UnityEngine;

namespace SSAR.BattleSystem.EntityTemplate
{
	public class BaseHeroTemplateArgs
	{
		public bool shouldAddAiComponent;

		public Vector3 pos;

		public AbsHeroData heroData;

		public EntityAbilities abilities;

		public GameObject instance;

		public HpBarType HpBarType;

		public int spawnedTicketId;

		public SpawnSource SpawnSource;

		public SkillEventFrameConfig[] comboVfxToReplace;

		public List<GameObject> weaponPassiveSkillPrefabs;

		public List<GameObject> ancientSkillPrefabs;

		public string name;

		public string groupOverride;

		public SkillEventFrameConfig[] ComboVfxToReplace
		{
			get
			{
				return comboVfxToReplace;
			}
			set
			{
				comboVfxToReplace = value;
			}
		}

		public BaseHeroTemplateArgs(AbsHeroData heroData, EntityAbilities abilities, Vector3 pos, GameObject instance, HpBarType hpBarType = HpBarType.SMALL)
		{
			this.heroData = heroData;
			this.abilities = abilities;
			this.pos = pos;
			this.instance = instance;
			HpBarType = hpBarType;
		}

		public BaseHeroTemplateArgs(AbsHeroData heroData, EntityAbilities abilities, Vector3 pos, GameObject instance, HpBarType hpBarType, int spawnedTicketId, SpawnSource spawnSource, SkillEventFrameConfig[] sefcs = null)
			: this(heroData, abilities, pos, instance, hpBarType)
		{
			this.spawnedTicketId = spawnedTicketId;
			SpawnSource = spawnSource;
			comboVfxToReplace = sefcs;
		}
	}
}
