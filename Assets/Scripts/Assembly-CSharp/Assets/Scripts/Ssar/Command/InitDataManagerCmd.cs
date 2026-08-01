using Assets.Scripts.Ssar.MemoryShard;
using Assets.Scripts.Ssar.Signal;
using Ssar.Craft.Model;
using Ssar.DailyChallenge.Model;
using Ssar.Event.DemonInvasion.Model;
using Ssar.Event.EventLogin.Model;
using Ssar.Event.EventShop.Model;
using Ssar.Event.EventWar.Model;
using Ssar.LevelDesignTest.Model;
using Ssar.RaidBoss.Model;
using Ssar.Rune;
using buildTools;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Command
{
	public class InitDataManagerCmd : strange.extensions.command.impl.Command
	{
		[Inject(/*Could not decode attribute arguments.*/)]
		public SignalManager SignalManager { get; set; }

		[Inject]
		public MemoryShardSignalManager MemoryShardSignalManager { get; set; }

		[Inject]
		public RuneSignalManager RuneSignalManager { get; set; }

		[Inject]
		public CraftingSignalManager CraftingSignalManager { get; set; }

		[Inject]
		public RaidBossSignalManager RaidBossSignalManager { get; set; }

		[Inject]
		public DailyChallengeSignalManager DailyChallengeSignalManager { get; set; }

		[Inject]
		public LevelDesignTestSignalManager LevelDesignTestSignalManager { get; set; }

		[Inject]
		public EventWarSignalManager EventWarSignalManager { get; set; }

		[Inject]
		public EventLoginSignalManager EventLoginSignalManager { get; set; }

		[Inject]
		public EventShopSignalManager EventShopSignalManager { get; set; }

		[Inject]
		public DemonInvasionSignalManager DemonInvasionSignalManager { get; set; }

		public override void Execute()
		{
		}

		private void InitAutoSave()
		{
		}

		public AbsLoadAssetControlLogic GetLoadAssetLogic()
		{
			return null;
		}
	}
}
