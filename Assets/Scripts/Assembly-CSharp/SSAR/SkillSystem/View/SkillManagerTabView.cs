using System;
using SSAR.SkillSystem.Utils;
using UnityEngine;

namespace SSAR.SkillSystem.View
{
	public class SkillManagerTabView : MonoBehaviour
	{
		public SkillTabType type;

		public GameObject wg_active;

		public Action<SkillTabType> OnClick;

		private void Awake()
		{
		}

		public void Click(GameObject o)
		{
		}

		public void HideTab()
		{
		}

		public void Selected()
		{
		}

		public void UnSelect()
		{
		}
	}
}
