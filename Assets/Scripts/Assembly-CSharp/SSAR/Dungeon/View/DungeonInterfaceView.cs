using Assets.Scripts.Ssar.Dungeon.GameModeLogic;
using Assets.Scripts.Ssar.Dungeon.View;
using UnityEngine;
using strange.extensions.mediation.impl;

namespace SSAR.Dungeon.View
{
	public class DungeonInterfaceView : strange.extensions.mediation.impl.View
	{
		public GameObject mainCharacterInfoContainer;

		public GameObject bossInfoContainer;

		public GameObject objectiveContainer;

		public GameObject startContainer;

		public GameObject topRightContainer;

		public GameObject inputContainer;

		public UILabel lb_time;

		public UILabel lb_node;

		public UILabel lb_stage;

		public GameObject btn_pause;

		public GameObject wg_info;

		public ButtonAutoPlayView buttonAutoPlayView;

		public ButtonAutoSkillView buttonAutoSkillView;

		private DungeonObjectiveView dungeonObjectiveView;

		private DungeonStartWarningContainer startWarningContainer;

		private IDungeonInterfaceLogic _dungeonInterfaceLogic;

		protected override void Awake()
		{
		}

		protected override void OnDestroy()
		{
		}

		public void Init(IDungeonInterfaceLogic _dungeonInterfaceLogic)
		{
		}

		public void OnStartDungeon()
		{
		}

		public void OnEnterStage()
		{
		}

		public void DisableTopRightContainer()
		{
		}

		public void OnEnterWave(int waveOrder)
		{
		}

		public void HideMainCharacterInfo(bool hide)
		{
		}

		public void HideStageInfo(bool hide)
		{
		}

		public void HideObjective(bool hide)
		{
		}

		private void InitButtonInput()
		{
		}

		private void InitMainCharacterInfo()
		{
		}

		private void InitBossInfo()
		{
		}

		private void InitObjectiveContainer()
		{
		}

		private void InitStageLosingView()
		{
		}

		private void InitWarningMask()
		{
		}

		private void InitStartContainer()
		{
		}

		private void Update()
		{
		}

		private void UpdateDungeonTime()
		{
		}

		private void Pause(GameObject o)
		{
		}

		private void ListenPause()
		{
		}

		private void ListenBack()
		{
		}
	}
}
