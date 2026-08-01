using Assets.Scripts.Ssar.Dungeon.Signal;
using Ssar.Analytics.Metrics;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Dungeon.Command
{
	public abstract class BaseFinishSetupDungeonCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public Metric metric { get; set; }

		[Inject]
		public Dungeon Dungeon { get; set; }

		[Inject]
		public DungeonPrepareSignal DungeonPrepareSignal { get; set; }

		[Inject]
		public OnDungeonStartSignal OnDungeonStartSignal { get; set; }

		public override void Execute()
		{
		}

		protected abstract void OnExcute();

		protected virtual bool DestroyLoadingScreen()
		{
			return false;
		}

		protected abstract void PlayAmbience();

		protected abstract void PlayBgm();

		protected virtual bool EnableDungeonUpdate()
		{
			return false;
		}
	}
}
