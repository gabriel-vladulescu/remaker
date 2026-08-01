using System;

namespace Ssar.Ancient.Model
{
	[Serializable]
	public class AncientSkill
	{
		public int id;

		public int level;

		public int Level => 0;

		public int Id => 0;

		public bool IsActiveSkill => false;

		public AncientSkill()
		{
		}

		public AncientSkill(int id, int level)
		{
		}

		public void SetId(int id)
		{
		}
	}
}
