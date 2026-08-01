using Artemis;
using Artemis.System;

namespace Assets.Scripts.Ssar.Dungeon
{
	public class DungeonSystem : EntitySystemWithTime
	{
		private Dungeon dungeon;

		private DungeonDataManager dungeonDataManager;

		private bool mEnable;

		private bool enableBossWarningFx;

		public bool enableUpdate
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public DungeonSystem(Dungeon dungeon)
		{
		}

		public void DisableBossWarningEffect()
		{
		}

		private void EntityManagerOnAddedEntityEvent(Entity entity)
		{
		}

		protected override void Process(float deltaTime)
		{
		}
	}
}
