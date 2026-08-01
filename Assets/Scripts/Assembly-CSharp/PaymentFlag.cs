using System;
using System.Collections.Generic;
using UnityEngine;
using core.nFury.Network;

public class PaymentFlag : MonoBehaviour
{
	public static bool isPaymentServiceInited;

	public static List<RecPurchaseValidationResult> results;

	public static List<Action<IPaymentService>> actions;

	public static void SetPSInited(bool value)
	{
	}

	public static void OnPaymentServiceInited(IPaymentService paymentService)
	{
	}

	public static void ExecuteResults(IPaymentService paymentService)
	{
	}

	public static void Execute(IPaymentService paymentService)
	{
	}
}
