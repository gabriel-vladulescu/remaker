using System;
using strange.extensions.signal.impl;

namespace Assets.Scripts.Ssar.Signal
{
	public class CheckAndConsumeResourcesToPurchaseSignal : Signal<Currency, int, Action, Reason>
	{
	}
}
