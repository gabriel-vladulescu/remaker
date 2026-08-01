using System.Collections.Generic;
using Ssar.RaidBoss.Model;
using UnityEngine;

namespace Ssar.RaidBoss.View
{
	public class RaidLeaderboardContainer : MonoBehaviour
	{
		public UIScrollView ScrollView;

		public UITable table;

		public GameObject loadingFx;

		public GameObject text_notAvailable;

		public int maxRow;

		private List<RaidLeaderboardRowView> RowViews;

		private Vector2 scrollViewOffset;

		private void Awake()
		{
		}

		internal void Init()
		{
		}

		private void InitRowView()
		{
		}

		internal void Show(List<RaidLeaderboardRowData> data)
		{
		}

		internal void Hide()
		{
		}

		private void Click(GameObject o, RaidLeaderboardRowData rowData)
		{
		}
	}
}
