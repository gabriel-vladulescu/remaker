using System.Collections.Generic;
using UnityEngine;

namespace Scripts.Ssar.Arena
{
	public class ArenaLeaderboardContainer : MonoBehaviour
	{
		public UIScrollView ScrollView;

		public UITable table;

		public List<ArenaLeaderboardRowView> RowViews;

		public GameObject loadingFx;

		public GameObject text_notAvailable;

		private Vector2 scrollViewOffset;

		private void Awake()
		{
		}

		public void Init()
		{
		}

		public void Show(List<ArenaLeaderboardRowData> datas, bool isRecord)
		{
		}

		public void Hide()
		{
		}

		private void InitRowView()
		{
		}

		private void Click(GameObject o, ArenaLeaderboardRowData rowData)
		{
		}

		private void ClickReplay(GameObject o, ArenaLeaderboardRowData rowData)
		{
		}
	}
}
