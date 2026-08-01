using System.Collections.Generic;
using SSAR.Entry.Model;
using Scripts.Config;
using UnityEngine;

namespace Assets.Scripts.Ssar.Pet.View
{
	public class PetSkillView : MonoBehaviour
	{
		private class BuffInfo
		{
			public string key;

			private GameObject prefab;

			private PetSkillStats petSkillStats;

			public BuffInfo(string key, GameObject prefab, PetSkillStats skillStats)
			{
			}

			public string GetDesc()
			{
				return null;
			}
		}

		public UISprite sp_icon;

		public Vector2 offset;

		private PetSkillStats petSkillStats;

		private void Awake()
		{
		}

		public void Show(PetSkillStats skillStats)
		{
		}

		public void Hide()
		{
		}

		private void Click(GameObject o)
		{
		}

		private ShowSkillInfoParameter GetParameter(GameObject obj)
		{
			return null;
		}

		private string GetDesc()
		{
			return null;
		}

		private List<BuffInfo> BuffInfos(PetSkillStats petSkillStats, GameObject prefab)
		{
			return null;
		}
	}
}
