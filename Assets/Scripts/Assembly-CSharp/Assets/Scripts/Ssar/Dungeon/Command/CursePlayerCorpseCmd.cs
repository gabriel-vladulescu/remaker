using Assets.Scripts.Ssar.Dungeon.Model;
using Assets.Scripts.Ssar.Dungeon.Signal;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Dungeon.Command
{
	public class CursePlayerCorpseCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public PlayerCorpseData Data { get; set; }

		[Inject]
		public SpawnPlayerCorpseSignal SpawnPlayerCorpseSignal { get; set; }

		public override void Execute()
		{
		}
	}
}
