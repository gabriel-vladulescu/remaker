using System;
using System.Collections.Generic;

namespace SSAR.BattleSystem.AI
{
	public class StateMachine
	{
		private IState curState;

		private Type prevStateType;

		private Dictionary<Type, List<Type>> legalTransitions;

		private List<Type> wildcardStates;

		public IState CurrentState => null;

		public Type PreviousStateType => null;

		public void SetLegalTransition(Type fromType, Type toType)
		{
		}

		public void SetLegalTransition<TFrom, TTo>()
		{
		}

		public void SetLegalTransition(Type wildcardType)
		{
		}

		public void SetLegalTransition<TWildcard>()
		{
		}

		public virtual bool SetState(IState state)
		{
			return false;
		}

		public bool IsLegalTransition(IState state)
		{
			return false;
		}
	}
}
