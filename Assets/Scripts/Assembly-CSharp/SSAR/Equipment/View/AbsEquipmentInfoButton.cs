using Assets.Scripts.Model;
using UnityEngine;
using strange.extensions.mediation.impl;

namespace SSAR.Equipment.View
{
	public abstract class AbsEquipmentInfoButton : strange.extensions.mediation.impl.View
	{
		protected override void Awake()
		{
		}

		public void Show(IItem equipmentCollectData)
		{
		}

		public void Hide()
		{
		}

		protected abstract void OnShow(IItem equipmentCollectData);

		protected abstract void OnClickButton(GameObject p);

		protected abstract bool IsValid(IItem equipmentCollectData);
	}
}
