using Assets.Scripts.Ssar.Dungeon.Model;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Dungeon.Command
{
	public class PrayPlayerCorpseCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public PlayerCorpseData Data { get; set; }

		public override void Execute()
		{
		}
	}
}
