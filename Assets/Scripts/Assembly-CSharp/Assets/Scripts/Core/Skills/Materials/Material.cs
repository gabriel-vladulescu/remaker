using SSAR.Dungeon.Caching;
using UnityEngine;

namespace Assets.Scripts.Core.Skills.Materials
{
	public class Material
	{
		private EventFrame eventFrame;

		private Character caster;

		private UnityEngine.Material[] materials;

		private CharacterObjectCaching characterObjectCaching;

		private UnityEngine.Material materialData;

		private string objectName;

		private float endFrame;

		private float elapsed;

		private bool isFinish;

		public Material(EventFrame eventFrame, Character caster)
		{
		}

		public void Update(float dt)
		{
		}

		public void Reset()
		{
		}

		private void ChangeMaterial(UnityEngine.Material material)
		{
		}
	}
}
