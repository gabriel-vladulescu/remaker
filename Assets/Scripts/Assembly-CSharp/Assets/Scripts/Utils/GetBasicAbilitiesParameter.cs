using Scripts.Config;

namespace Assets.Scripts.Utils
{
	public class GetBasicAbilitiesParameter
	{
		public HeroLevelStats HeroLevelStats;

		public HeroBasicStats HeroBasicStats;

		public bool isHero;

		public GetBasicAbilitiesParameter(HeroLevelStats heroLevelStats, HeroBasicStats heroBasicStats, bool ishero)
		{
		}

		public override bool Equals(object obj)
		{
			return false;
		}
	}
}
