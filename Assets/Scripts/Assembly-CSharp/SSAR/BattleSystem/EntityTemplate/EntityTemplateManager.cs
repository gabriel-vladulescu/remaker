using Artemis;
using Assets.Scripts.Ssar.BattleSystem.EntityTemplate;

namespace SSAR.BattleSystem.EntityTemplate
{
	public class EntityTemplateManager
	{
		private EntityWorld entityWorld;

		public void Init(EntityWorld entityWorld)
		{
			this.entityWorld = entityWorld;
		}

		public Entity CreateMainCharacter(BaseHeroTemplateArgs args)
		{
			return CreateEntity("MainChracter", args);
		}

		public Entity CreatePlayerCorpse(BaseHeroTemplateArgs args)
		{
			return CreateEntity("PlayerCorpse", args);
		}

		public Entity CreateArenaEnemy(BaseHeroTemplateArgs args)
		{
			return CreateEntity("ArenaEnemy", args);
		}

		public Entity CreateArenaCharacter(BaseHeroTemplateArgs args)
		{
			return CreateEntity("ArenaCharacter", args);
		}

		public Entity CreateRaidCompanion(BaseHeroTemplateArgs args)
		{
			return CreateEntity("RaidCompanion", args);
		}

		public Entity CreateRaidMainCharacter(BaseHeroTemplateArgs args)
		{
			return CreateEntity("RaidMainCharacter", args);
		}

		public Entity CreateNormalMob(BaseHeroTemplateArgs args)
		{
			return CreateEntity("NormalMob", args);
		}

		public Entity CreateMobStatic(BaseHeroTemplateArgs args)
		{
			return CreateEntity("MobStatic", args);
		}

		public Entity CreateMiniBoss(BaseHeroTemplateArgs args)
		{
			return CreateEntity("MiniBoss", args);
		}

		public Entity CreateBoss(BaseHeroTemplateArgs args)
		{
			return CreateEntity("Boss", args);
		}

		public Entity CreateProjectile(params object[] templateArgs)
		{
			return entityWorld.CreateEntityFromTemplate("Projectile", templateArgs);
		}

		public Entity CreateItemDropped(DropItemTemplateArgs args)
		{
			return entityWorld.CreateEntityFromTemplate("ItemDropped", args);
		}

		public Entity CreatePet(BaseHeroTemplateArgs args)
		{
			return CreateEntity("Pet", args);
		}

		private Entity CreateEntity(string tag, BaseHeroTemplateArgs args)
		{
			return entityWorld.CreateEntityFromTemplate(tag, args);
		}
	}
}
