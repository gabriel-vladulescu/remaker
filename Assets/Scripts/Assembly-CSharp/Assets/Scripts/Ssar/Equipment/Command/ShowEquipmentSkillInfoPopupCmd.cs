using SSAR.Equipment.Model;
using UnityEngine;

namespace Assets.Scripts.Ssar.Equipment.Command
{
	public class ShowEquipmentSkillInfoPopupCmd : BaseShowPopupCmd
	{
		[Inject]
		public EquipmentSkillInfo EquipmentSkillInfo { get; set; }

		[Inject]
		public GameObject objectClicked { get; set; }

		[Inject]
		public Vector2 offset { get; set; }

		[Inject]
		public int groupId { get; set; }

		public override void Execute()
		{
		}

		protected override string GetAssetPath()
		{
			return null;
		}

		protected override string GetInjectName()
		{
			return null;
		}

		protected override PopupCamera GetCamera()
		{
			return default(PopupCamera);
		}
	}
}
