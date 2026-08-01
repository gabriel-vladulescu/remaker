using System;
using System.Collections.Generic;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	[Serializable]
	public class CornerJumpConfig
	{
		public List<CornerJumpElementConfig> jumpByDistance;

		public string skillNumber;
	}
}
