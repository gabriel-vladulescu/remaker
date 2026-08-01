using System.Collections.Generic;
using Assets.Scripts.Ssar.Dungeon.Environment;
using UnityEngine;

namespace Assets.Scripts.Ssar.Dungeon.Gates
{
	public class DefaultGate : Gate
	{
		private enum State
		{
			Closed = 0,
			Opening = 1,
			Opened = 2,
			Closing = 3
		}

		private const int DURATION = 0;

		private int gateId;

		private Assets.Scripts.Ssar.Dungeon.Environment.Environment environment;

		private State state;

		private float elapsed;

		private GameObject fxIdle;

		public DefaultGate(int gateId, Assets.Scripts.Ssar.Dungeon.Environment.Environment environment)
		{
		}

		public void SetCookies(IEnumerable<string> cookies)
		{
		}

		protected override void OnOpen()
		{
		}

		protected override void OnClose()
		{
		}

		public override bool IsOpened()
		{
			return false;
		}

		public override bool IsClosed()
		{
			return false;
		}

		public override bool IsOpening()
		{
			return false;
		}

		public override bool IsClosing()
		{
			return false;
		}

		public override void Update(float dt)
		{
		}

		private void PlayFxOpen()
		{
		}

		private void PlayFxClose()
		{
		}

		private GameObject FxIdle()
		{
			return null;
		}

		private void InitFx()
		{
		}
	}
}
