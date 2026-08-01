using System;
using System.Collections.Generic;
using System.Linq;
using Checking;
using UnityEngine;

namespace Assets.Scripts.Core.FiniteStateMachine
{
	public class StateMachine
	{
		private State currentState;

		private Stack<string> statesStack;

		private Dictionary<string, List<string>> stateTransitionTable;

		private Dictionary<string, State> definedStates;

		private NotNullReference notNullReference;

		private List<Action<string, string, bool>> listeners;

		private List<Action<string, string, bool>> preTransitionListeners;

		private bool debug;

		public StateMachine(State startState)
			: this(startState, false)
		{
		}

		public StateMachine(State startState, bool debug)
		{
			this.debug = debug;
			statesStack = new Stack<string>();
			stateTransitionTable = new Dictionary<string, List<string>>();
			definedStates = new Dictionary<string, State>();
			listeners = new List<Action<string, string, bool>>();
			preTransitionListeners = new List<Action<string, string, bool>>();

			currentState = startState;
			definedStates[startState.Name()] = startState;
			statesStack.Push(startState.Name());
			currentState.Enter(false, null);
		}

		public void ListenToStateTransition(Action<string, string, bool> action)
		{
			listeners.Add(action);
		}

		public void ListenToPreStateTransition(Action<string, string, bool> action)
		{
			preTransitionListeners.Add(action);
		}

		public void Update(float dt)
		{
			currentState.Execute(dt, this);
		}

		public void DefineState(string stateName, State state)
		{
			definedStates[stateName] = state;
		}

		public void DefineTransition(string stateName, List<string> destinationStates)
		{
			stateTransitionTable[stateName] = destinationStates;
		}

		public void GoBackToPreviousState()
		{
			if (statesStack.Count <= 1)
			{
				return;
			}

			statesStack.Pop();
			string previousStateName = statesStack.Peek();
			State previousState = GetStateFromDefinedStatesBy(previousStateName);

			string fromStateName = currentState.Name();
			NotifyPreStateTransition(fromStateName, previousStateName);

			currentState.Exit();
			currentState = previousState;
			currentState.Enter(true, fromStateName);

			NotifyStateTransition(fromStateName, true);
		}

		public void ChangeStateWithHistory(string stateName)
		{
			CheckStateIsDefined(stateName);
			CheckStateTransitionLegal(stateName);

			State newState = GetStateFromDefinedStatesBy(stateName);
			ChangeStateWithHistory(newState);
		}

		public void ReplaceCurrentStateBy(string stateName)
		{
			CheckStateIsDefined(stateName);

			State newState = GetStateFromDefinedStatesBy(stateName);
			ChangeStateWithoutTransitionChecking(newState);
		}

		private void NotifyPreStateTransition(string previousStateName, string nextStateName)
		{
			for (int i = 0; i < preTransitionListeners.Count; i++)
			{
				preTransitionListeners[i](previousStateName, nextStateName, false);
			}
		}

		private void NotifyStateTransition(string previousState, bool resume)
		{
			string currentStateName = currentState.Name();
			for (int i = 0; i < listeners.Count; i++)
			{
				listeners[i](previousState, currentStateName, resume);
			}
		}

		private void ChangeStateWithHistory(State newState)
		{
			string fromStateName = currentState.Name();
			string toStateName = newState.Name();

			NotifyPreStateTransition(fromStateName, toStateName);

			currentState.Exit();
			currentState = newState;
			statesStack.Push(toStateName);
			currentState.Enter(false, fromStateName);

			NotifyStateTransition(fromStateName, false);

			if (debug)
			{
				DumpStack();
			}
		}

		private void ChangeStateWithoutTransitionChecking(State newState)
		{
			string fromStateName = currentState.Name();
			string toStateName = newState.Name();

			NotifyPreStateTransition(fromStateName, toStateName);

			currentState.Exit();
			currentState = newState;
			statesStack.Push(toStateName);
			currentState.Enter(false, fromStateName);

			NotifyStateTransition(fromStateName, false);

			if (debug)
			{
				DumpStack();
			}
		}

		private void CheckStateIsDefined(string stateName)
		{
			if (!definedStates.ContainsKey(stateName))
			{
				throw new Exception("State not defined: " + stateName);
			}
		}

		private State GetStateFromDefinedStatesBy(string stateName)
		{
			return definedStates[stateName];
		}

		private void CheckStateTransitionLegal(string newStateName)
		{
			if (!IsTransitionLegal(newStateName))
			{
				throw new Exception("Illegal transition from " + currentState.Name() + " to " + newStateName);
			}
		}

		private bool IsTransitionLegal(string newStateName)
		{
			return ListOfStatesCanBeTransitFromCurrentState().Contains(newStateName);
		}

		private List<string> ListOfStatesCanBeTransitFromCurrentState()
		{
			string currentStateName = currentState.Name();
			if (stateTransitionTable.ContainsKey(currentStateName))
			{
				return stateTransitionTable[currentStateName];
			}

			return new List<string>();
		}

		private void DumpStack()
		{
			Debug.Log(string.Join(" <- ", statesStack.ToArray()));
		}

		public string GetCurrentStateName()
		{
			return currentState.Name();
		}
	}
}
