using System.Collections.Generic;
using Assets.Scripts.Ssar.Dungeon.Environment;
using Assets.Scripts.Ssar.Dungeon.Environment.Character;

namespace Assets.Scripts.Ssar.Dungeon.Stages.LosingConditions
{
	public class HeroDeadLosingCondition : LosingCondition
	{
		private Character character;

		public HeroDeadLosingCondition(Character character)
		{
		}

		public HeroDeadLosingCondition(Assets.Scripts.Ssar.Dungeon.Environment.Environment environment)
		{
		}

		public void SetCookies(IEnumerable<string> cookies)
		{
		}

		public bool IsMet()
		{
			return false;
		}

		public void Update(float dt)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
