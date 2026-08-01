using Artemis;
using Assets.Scripts.Ssar.Dungeon.View;
using Scripts.Config;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Dungeon.Command
{
	public class OnArenaStartBattleCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public ConfigManager configManager { get; set; }

		public override void Execute()
		{
		}

		private void CooldownSkill(HeroConfig heroConfig, ArenaConstantConfig arenaConstantConfig, Entity entity)
		{
		}
	}
}
