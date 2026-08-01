using UnityEngine;

namespace SSAR.Entry.Model
{
	public class ShowSkillInfoParameter
	{
		public string LbName { get; set; }

		public string LbLv { get; set; }

		public string Desc { get; set; }

		public GameObject ObjectClicked { get; set; }

		public Vector2 Offset { get; set; }

		public ShowSkillInfoParameter(string lbName, string lbLv, string desc, GameObject objectClicked, Vector2 offset)
		{
		}
	}
}
