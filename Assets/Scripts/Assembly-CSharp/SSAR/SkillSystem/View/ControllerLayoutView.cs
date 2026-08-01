using SSAR.Dungeon.View;
using SSAR.SkillSystem.Model;
using UnityEngine;

namespace SSAR.SkillSystem.View
{
	public class ControllerLayoutView : MonoBehaviour
	{
		public GameObject controllerContainer;

		public GameObject[] objCurrent;

		private ControllerLayout controllerLayout;

		private GameObject prefabSkill;

		private GameObject prefabAncient;

		private void Awake()
		{
		}

		internal void LoadController(ControllerLayout layout)
		{
		}

		internal void UpdateStatus(ControllerLayout currentLayout)
		{
		}

		private void LoadController(GameObject container, ControllerLayout layout)
		{
		}

		private void LoadActiveSkills(ButtonSkillView[] buttonSkillViews)
		{
		}

		private void LoadAncientSkills(ButtonAncientSkillView[] buttonSkillViews)
		{
		}

		private void ClearExistController(GameObject container)
		{
		}
	}
}
