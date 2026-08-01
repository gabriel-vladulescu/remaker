using Artemis;
using Artemis.Interface;
using Assets.Scripts.Core.Skills.Modifiers;

namespace SSAR.BattleSystem.System.Indicator.Component
{
	public class MonsterIndicatorComponent : IComponent
	{
		private string monsterId;

		private ModifierVfxManager vfxManager;

		private bool isActivated;

		internal string MonsterId => null;

		internal bool IsActivated => false;

		public MonsterIndicatorComponent(string monsterId)
		{
		}

		internal void Update(float dt)
		{
		}

		internal void Activate(Entity entity)
		{
		}

		internal void Deactivate()
		{
		}
	}
}
