using System;
using Artemis;
using Assets.Scripts.Ssar.Combat.Skills;
using Assets.Scripts.Ssar.Common.System.Resources;
using UnityEngine;

namespace Assets.Scripts.Core.Skills
{
	internal class TestProjectileEntityFactory : ProjectileEntityFactory
	{
		private ResourcesSubSystem resourcesLoader;

		private EntityWorld entityWorld;

		public TestProjectileEntityFactory(ResourcesSubSystem resourcesLoader, EntityWorld entityWorld)
			: base(null)
		{
		}

		public override void CreateProjectileEntity(Character caster, Skill skill, EventFrame ef, Vector3 pos, object cookies, Action<EventFrame, Entity, object> onSuccessAction)
		{
		}
	}
}
