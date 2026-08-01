using System;
using System.Collections.Generic;

[Serializable]
public class PaymentModel
{
	public List<string> completedTransactions;

	public Dictionary<string, Purchase> pendingTransactions;

	public bool AddPendingTransaction(string tranId, Purchase purchase)
	{
		return false;
	}

	public void RemovePendingTransaction(string tranId)
	{
	}

	public bool CompleteTransaction(string tranId)
	{
		return false;
	}

	public bool HasTransaction(string tranId)
	{
		return false;
	}
}
