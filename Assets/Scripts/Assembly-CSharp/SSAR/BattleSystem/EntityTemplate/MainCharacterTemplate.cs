using System;
using System.Collections.Generic;
using Artemis;
using Artemis.Attributes;
using Assets.Scripts.Config.Stats;
using Assets.Scripts.Core.Skills;
using Assets.Scripts.Ssar;
using Assets.Scripts.Ssar.Combat.Effects;
using Assets.Scripts.Ssar.Combat.HeroStateMachines;
using Assets.Scripts.Ssar.Combat.Skills;
using Assets.Scripts.Ssar.Common.System.RoutineRunner;
using SSAR.BattleSystem.AI;
using SSAR.BattleSystem.Damage;
using SSAR.BattleSystem.Movement;
using SSAR.BattleSystem.System.Animation.Component;
using SSAR.BattleSystem.System.Event.Component;
using SSAR.BattleSystem.System.Input.Model;
using SSAR.Dungeon.Caching;
using SSAR.Dungeon.HUD;
using Scripts.Config;
using UnityEngine;

namespace SSAR.BattleSystem.EntityTemplate
{
	[ArtemisEntityTemplate("MainChracter")]
	public class MainCharacterTemplate : BaseEntityTemplate
	{
		public class CharacterRenderer : DefaultSkillCharacter.Renderer
		{
			private Renderer[] renderers;

			private ParticleSystem[] particleSystems;

			public CharacterRenderer(Renderer[] renderers, ParticleSystem[] particleSystems)
			{
				this.renderers = renderers ?? new Renderer[0];
				this.particleSystems = particleSystems ?? new ParticleSystem[0];
			}

			public void AddRenderers(Renderer[] renderersToAdd)
			{
				if (renderersToAdd == null)
				{
					return;
				}
				Renderer[] combined = new Renderer[renderers.Length + renderersToAdd.Length];
				renderers.CopyTo(combined, 0);
				renderersToAdd.CopyTo(combined, renderers.Length);
				renderers = combined;
			}

			public void AddParticleSystems(ParticleSystem[] particleSystemsToAdd)
			{
				if (particleSystemsToAdd == null)
				{
					return;
				}
				ParticleSystem[] combined = new ParticleSystem[particleSystems.Length + particleSystemsToAdd.Length];
				particleSystems.CopyTo(combined, 0);
				particleSystemsToAdd.CopyTo(combined, particleSystems.Length);
				particleSystems = combined;
			}

			public void TurnOn()
			{
				for (int i = 0; i < renderers.Length; i++)
				{
					if (renderers[i] != null)
					{
						renderers[i].enabled = true;
					}
				}
			}

			public void TurnOff()
			{
				for (int i = 0; i < renderers.Length; i++)
				{
					if (renderers[i] != null)
					{
						renderers[i].enabled = false;
					}
				}
			}

			public void TurnOnParticles()
			{
				for (int i = 0; i < particleSystems.Length; i++)
				{
					if (particleSystems[i] != null)
					{
						particleSystems[i].Play();
					}
				}
			}

			public void TurnOffParticles()
			{
				for (int i = 0; i < particleSystems.Length; i++)
				{
					if (particleSystems[i] != null)
					{
						particleSystems[i].Stop();
					}
				}
			}
		}

		private class DashJumpFrameAdjustment : DefaultSkillFactory.FrameAdjustment
		{
			private HeroStateMachine hsm;

			private bool shouldAdjust;

			public void SetHeroStateMachine(HeroStateMachine hsm)
			{
			}

			public int Adjust(EventFrameConfig efc)
			{
				return 0;
			}

			private void OnPreStateTransition(string from, string to, bool resume)
			{
			}
		}

		public class Character3Skill8Swap
		{
			private CharacterMove cm;

			private CharacterMediatorComponent cmc;

			private HUDMediatorComponent hmc;

			private CachingComponent cc;

			private CharacterAnimation ca;

			private MovementComponent mc;

			private SoundEffectsPlayer sep;

			private CharacterInput ci;

			private GameObject original;

			private GameObject arcane;

			private Entity entity;

			private ModelEffectEditor mee;

			private Dictionary<string, float> scaleTimeByAnimationName;

			private bool isSwapped;

			public Character3Skill8Swap(CharacterMove cm, CharacterMediatorComponent cmc, CharacterAnimation ca, CharacterInput ci)
			{
			}

			public void Prepare(GameObject original, GameObject arcane, Entity entity)
			{
			}

			public void SwapToArcane()
			{
			}

			public void SwapToOriginal()
			{
			}

			public GameObject OriginalGameObject()
			{
				return null;
			}

			public bool IsSwapped()
			{
				return false;
			}

			private Dictionary<string, float> CalculateScaleTimeByAnimationName(GameObject arcaneGameObject)
			{
				return null;
			}
		}

		public new const string Name = "MainChracter";

		// Scoped simplification: skips weapon-skin swapping, ancient-item skill
		// config, and particle/material discovery (Combat/Skills phase concerns).
		// Wires up exactly the movement-relevant components.
		protected override void OnBuild(Entity entity, BaseHeroTemplateArgs baseHeroTemplateArgs)
		{
			GameObject go = baseHeroTemplateArgs.instance;
			if (go == null)
			{
				return;
			}

			int groupId = baseHeroTemplateArgs.heroData != null ? baseHeroTemplateArgs.heroData.groupId : 1;
			int subId = baseHeroTemplateArgs.heroData != null ? baseHeroTemplateArgs.heroData.subId : 1;

			SimpleMovementConfigData configData = go.GetComponent<SimpleMovementConfigData>();
			MovementComponent movementComponent = new MovementComponent(configData, 0f, Direction.Right, true, true, configData != null ? configData.MaxMoveSpeed : -1f);
			entity.AddComponent(movementComponent);

			CharacterMediatorComponent mediator = new CharacterMediatorComponent(baseHeroTemplateArgs.pos, go);
			entity.AddComponent(mediator);

			CharacterEvent characterEvent = new CharacterEvent();
			entity.AddComponent(new CharacterEventComponent(characterEvent));

			CharacterInput characterInput = GetCharacterInput(null, groupId, subId);
			entity.AddComponent(new CharacterInputComponent(characterInput));
			CharacterMove characterMove = new CharacterMove(go, entity, characterInput, characterEvent);
			CharacterJump characterJump = new CharacterJump(entity, MaxJumpCharge(groupId));

			RoutineRunnerSubSystem routineRunner = new RoutineRunnerSubSystem();
			routineRunner.StartUp();
			Assets.Scripts.Ssar.Combat.HeroStateMachines.Animation animation = CreateAnimationController(baseHeroTemplateArgs.heroData, baseHeroTemplateArgs.abilities, entity, go, routineRunner);

			HeroStateMachine heroStateMachine = GetHeroStateMachine(go, entity, characterInput, animation, characterMove, characterEvent, characterJump, baseHeroTemplateArgs, characterInput, characterJump);
			entity.AddComponent(new HeroStateMachineComponent(heroStateMachine));
		}

		public static GameObject InstantiateGameObjectFromPrefab(GameObject prefab)
		{
			return prefab != null ? UnityEngine.Object.Instantiate(prefab) : null;
		}

		protected override void FinishSetupBase(Entity entity, BaseHeroTemplateArgs baseHeroTemplateArgs)
		{
		}

		protected override string GetGroup()
		{
			return args != null && args.heroData != null ? args.heroData.groupId + "_" + args.heroData.subId : null;
		}

		protected override string GetTag()
		{
			return Name;
		}

		protected override HeroStateMachine GetHeroStateMachine(GameObject herGameObject, Entity entity, UserInput userInput, Assets.Scripts.Ssar.Combat.HeroStateMachines.Animation animation, Assets.Scripts.Ssar.Combat.HeroStateMachines.Movement movement, Assets.Scripts.Ssar.Combat.HeroStateMachines.Event @event, Hero hero, BaseHeroTemplateArgs baseHeroTemplateArgs, CharacterInput ci, CharacterJump cj)
		{
			int groupId = baseHeroTemplateArgs.heroData != null ? baseHeroTemplateArgs.heroData.groupId : 1;
			int subId = baseHeroTemplateArgs.heroData != null ? baseHeroTemplateArgs.heroData.subId : 1;
			Type type = HeroStateMachineType(groupId, subId);

			DefaultSkillCharacter.Renderer renderer = new CharacterRenderer(FindRendererComponents(herGameObject), FindParticleSystems(herGameObject));
			CachingComponent cachingComponent = entity.GetComponent<CachingComponent>();
			Character character = new DefaultSkillCharacter(null, animation, entity.GetComponent<MovementComponent>(), entity.GetComponent<CharacterMediatorComponent>(), cachingComponent, baseHeroTemplateArgs.heroData, GetGroup(), subId, @event, ci, cj, renderer);

			return (HeroStateMachine)Activator.CreateInstance(type, userInput, animation, movement, @event, hero, character, null);
		}

		private void LoadAncientSkillConfig(BaseHeroTemplateArgs baseHeroTemplateArgs, SkillEventFrameConfig sefc)
		{
		}

		private void LoadWeaponPassiveSkillConfig(BaseHeroTemplateArgs baseHeroTemplateArgs, SkillEventFrameConfig sefc, GameObject herGameObject, JsonEquipmentDropConfig jedc)
		{
		}

		private void MappingWeaponPassiveSkillData(HeroData heroData, JsonEquipmentDropConfig jedc, SkillConfig sc, JsonEquipmentDropConfig.WeaponPassiveSkillName sn, int heroGroupId, int heroSubId)
		{
		}

		private TriggerType GetTriggerType(JsonEquipmentDropConfig.WeaponPassiveSkillName weaponPassiveSkillName)
		{
			return default(TriggerType);
		}

		private ModifierType GetModifierType(JsonEquipmentDropConfig.WeaponPassiveSkillName weaponPassiveSkillName)
		{
			return default(ModifierType);
		}

		private ParticleSystem[] FindParticleSystems(GameObject herGameObject)
		{
			return herGameObject != null ? herGameObject.GetComponentsInChildren<ParticleSystem>(true) : new ParticleSystem[0];
		}

		private Renderer[] FindRendererComponents(GameObject herGameObject)
		{
			return herGameObject != null ? herGameObject.GetComponentsInChildren<Renderer>(true) : new Renderer[0];
		}

		private Type HeroStateMachineType(int groupId, int subId)
		{
			switch (groupId)
			{
				case 2:
					return typeof(Character2StateMachine);
				case 3:
					return typeof(Character3StateMachine);
				case 4:
					return typeof(Character4StateMachine);
				default:
					return typeof(HeroStateMachine);
			}
		}

		private void ReplaceSkillVfx(SkillEventFrameConfig sefc)
		{
		}

		private List<EventFrameConfig> FindVfxEventFrameConfigOf(SkillConfig sc)
		{
			return null;
		}

		private List<EventFrameConfig> FindVfxFollowsBoneEventFrameConfigOf(SkillConfig sc)
		{
			return null;
		}

		private List<EventFrameConfig> FindDamageEventFrameConfigWithRangerProjectile(SkillConfig sc)
		{
			return null;
		}

		private List<EventFrameConfig> FindDamageEventFrameConfigWithMeleeProjectile(SkillConfig sc)
		{
			return null;
		}

		private void LogReplace(string s, string s2)
		{
		}

		private EquippedSkill CreateEquipSkill(string skillId, SkillEventFrameConfig sefc, float bonusScaleTime)
		{
			return null;
		}

		private bool EnableReplaceSkillVfx()
		{
			return false;
		}

		private void InitCooldown(HeroData heroData, AttackComponent ac)
		{
		}

		protected virtual string GetAITab()
		{
			return null;
		}

		protected virtual bool EnableAI()
		{
			return false;
		}

		protected virtual MainCharacterData GetMainCharacterData()
		{
			return null;
		}

		public List<ActionConfig> AncientItemAction()
		{
			return null;
		}
	}
}
