using Artemis;
using Artemis.Interface;
using Assets.Scripts.Core.Skills.Cooldowns;
using Assets.Scripts.Core.Skills.Modifiers;
using SSAR.BattleSystem.EntityTemplate;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	public class SkillComponent : IComponent
	{
		private DefaultSkillCharacter defaultSkillCharacter;

		private EquippedSkills equippedSkills;

		private bool isSpawnByOther;

		private MainCharacterTemplate.CharacterRenderer characterRenderer;

		private CooldownsCollection cooldownsCollection;

		private AncientChargeContainer ancientChargeContainer;

		private Entity self;

		private object extra;

		public bool enableUpdate;

		public bool IsSpawnByOther
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public MainCharacterTemplate.CharacterRenderer CharacterRenderer => null;

		public CooldownsCollection CooldownsCollection => null;

		public AncientChargeContainer AncientChargeContainer => null;

		public object Extra => null;

		public SkillComponent(Entity self, DefaultSkillCharacter defaultSkillCharacter, EquippedSkills equippedSkills, MainCharacterTemplate.CharacterRenderer characterRenderer, CooldownsCollection cooldownsCollection, AncientChargeContainer ancientChargeContainer, object extra)
		{
		}

		public void Update(float dt)
		{
		}

		public DefaultSkillCharacter Character()
		{
			return null;
		}

		public EquippedSkills EquippedSkills()
		{
			return null;
		}

		private void ListenonAttachModifier(Modifier modifier)
		{
		}
	}
}
