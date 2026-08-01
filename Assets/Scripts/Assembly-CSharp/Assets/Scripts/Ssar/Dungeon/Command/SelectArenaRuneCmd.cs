using Artemis;
using Assets.Scripts.Core.Skills.Modifiers;
using Scripts.Config;
using Ssar.Analytics.Metrics;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Dungeon.Command
{
	public class SelectArenaRuneCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public SelectArenaRuneParameter Parameter { get; set; }

		[Inject]
		public Metric metric { get; set; }

		[Inject]
		public ConfigManager ConfigManager { get; set; }

		public override void Execute()
		{
		}

		private Modifier ParseToModifier(ArenaRuneInfo runeInfo, Entity e)
		{
			return null;
		}
	}
}
