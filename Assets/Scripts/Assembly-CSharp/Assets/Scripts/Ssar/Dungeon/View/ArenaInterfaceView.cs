using Artemis;
using SSAR.Dungeon.View;
using UnityEngine;
using strange.extensions.mediation.impl;

namespace Assets.Scripts.Ssar.Dungeon.View
{
	public class ArenaInterfaceView : strange.extensions.mediation.impl.View
	{
		public UILabel lb_time;

		public GameObject btn_pause;

		public ButtonAutoPlayView buttonAutoPlayView;

		public ArenaCharacterHealthBarView main;

		public ArenaCharacterHealthBarView enemy;

		private double battleTime;

		private int timeSleep;

		protected override void Awake()
		{
		}

		protected override void OnDestroy()
		{
		}

		private void DisableSleep(bool disableSleep)
		{
		}

		public void Init()
		{
		}

		private void InitButtonInput()
		{
		}

		public void OnSpawnLeftCharacter(MainCharacterData mainCharacterData, Entity entity)
		{
		}

		public void OnSpawnRightCharacter(MainCharacterData mainCharacterData, Entity entity)
		{
		}

		public void OnSpawnPet(Entity entity)
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
