using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Core.Skills.VfxFollowBones
{
	public class VfxFollowBone
	{
		private EventFrame eventFrame;

		private Environment environment;

		private readonly Character caster;

		private float elapsed;

		private List<GameObject> vfxs;

		public List<GameObject> Vfxs => null;

		public VfxFollowBone(EventFrame eventFrame, Environment environment, Character caster)
		{
		}

		public void Update(float dt)
		{
		}

		public bool IsFinish()
		{
			return false;
		}

		public void Interrupt()
		{
		}

		private void ReturnVfxToPool(GameObject vfx)
		{
		}
	}
}
