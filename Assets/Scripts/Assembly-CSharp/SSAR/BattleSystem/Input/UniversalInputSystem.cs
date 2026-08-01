using System;
using System.Collections.Generic;
using Artemis;
using Artemis.System;

namespace SSAR.BattleSystem.Input
{
	public class UniversalInputSystem : EntitySystemWithTime, ICallBack
	{
		private class Request
		{
			public readonly Entity entity;

			public readonly ActionType actionType;

			public readonly AbsInputParameter absInputParameter;

			private List<string> skillWhiteList;

			public Request(Entity entity, ActionType actionType, AbsInputParameter absInputParameter)
			{
			}

			public void Excute(int frame, ref bool buffered)
			{
			}

			public bool IsAvailableInputCastSkill(Entity entity, int skillOrder)
			{
				return false;
			}

			private bool IsInWhiteList(Entity entity, int skillOrder)
			{
				return false;
			}

			public void CastSkill(Entity entity, int skillOrder)
			{
			}

			public string GetSkillId(Entity entity, int skillOrder)
			{
				return null;
			}
		}

		public bool enable;

		private List<Request> requests;

		private List<Request> bufferedRequests;

		private Action<int> onEnterFrame;

		private Action<float> onUpdate;

		public bool enableUpdate;

		private int frame;

		public void ListenOnEnterFrame(Action<int> onEnterFrame)
		{
		}

		public void ListenOnUpdate(Action<float> onUpdate)
		{
		}

		public void CallBack(ActionType actionType, AbsInputParameter absInputParameter)
		{
		}

		protected override void Process(float deltaTime)
		{
		}

		public int GetCurrentFrame()
		{
			return 0;
		}
	}
}
