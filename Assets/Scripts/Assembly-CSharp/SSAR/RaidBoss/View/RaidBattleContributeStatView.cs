using UnityEngine;

namespace Ssar.RaidBoss.View
{
	public class RaidBattleContributeStatView : MonoBehaviour
	{
		public UILabel lbRank;

		public UILabel lbName;

		public UILabel lbDmg;

		public Color firstColor;

		public Color baseColor;

		internal void Show(int rank, int level, string name, float damage)
		{
		}

		internal void Show(string name, float damage)
		{
		}

		internal void Hide()
		{
		}
	}
}
