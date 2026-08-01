using System;
using Artemis;
using Assets.Scripts.Core.Skills;
using Assets.Scripts.Ssar.Common.System.Resources;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	public class ProjectileEntityFactory
	{
		private ResourcesLoader resourcesLoader;

		public ProjectileEntityFactory(ResourcesLoader resourcesLoader)
		{
		}

		public virtual void CreateProjectileEntity(Character caster, Skill skill, EventFrame ef, Vector3 pos, object cookies, Action<EventFrame, Entity, object> onSuccessAction)
		{
		}
	}
}
