using Assets.Scripts.Model;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Equipment.Command
{
	public class LockEquipmentCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public IItem EquipmentCollectData { get; set; }

		public override void Execute()
		{
		}
	}
}
