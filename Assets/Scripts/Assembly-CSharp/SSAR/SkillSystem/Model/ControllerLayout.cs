using System;
using UnityEngine;

namespace SSAR.SkillSystem.Model
{
	[Serializable]
	public class ControllerLayout
	{
		public int id;

		public GameObject prefab;

		public ControllerStyle style;

		public ControllerForm form;
	}
}
