using System.Collections.Generic;
using UnityEngine;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Dungeon.Command
{
	public class InitMonsterPoolCommand : strange.extensions.command.impl.Command
	{
		[Inject(/*Could not decode attribute arguments.*/)]
		public Dictionary<GameObject, int> monsterPrefabs { get; set; }

		public override void Execute()
		{
		}
	}
}
