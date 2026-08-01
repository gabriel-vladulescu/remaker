using System;
using System.Collections.Generic;
using UnityEngine;

namespace SSAR.SkillSystem.Model
{
	[Serializable]
	[CreateAssetMenu(menuName = "ScriptableOject/ControllerLayoutConfig")]
	public class ControllerLayoutConfig : ScriptableObject
	{
		[SerializeField]
		public List<ControllerLayout> layouts;

		public ControllerLayout GetLayout(int id)
		{
			return null;
		}

		public ControllerLayout GetLayouts(ControllerForm form, ControllerStyle style)
		{
			return null;
		}
	}
}
