using Assets.Scripts.Ssar.Common.System;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Command
{
	public class ScaleGameTimeCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public float scale { get; set; }

		[Inject(/*Could not decode attribute arguments.*/)]
		public DefaultSystem entryDefaultSystem { get; set; }

		public override void Execute()
		{
		}
	}
}
