using System;
using System.Collections.Generic;
using Assets.Scripts.Utils;
using Scripts.Config.Stats;

namespace Scripts.Config
{
	[Serializable]
	public abstract class AbsStats
	{
		private Dictionary<string, object> mainValue;

		private List<TransferRequest> properties2TransferType;

		private Dictionary<TransferRequest, object> properties2Data;

		protected TransferDataParameterType transferDataParameterType;

		protected virtual void AddTransferData(string attributeName, TransferType type, object value, bool isMain = false)
		{
		}

		public void MapDictionary(TransferDataParameterType type)
		{
		}

		protected abstract void Properties2Map();

		public List<TransferRequest> GetRequestList()
		{
			return null;
		}

		public object GetMainValue(string attributeName)
		{
			return null;
		}

		public object GetObjectData(TransferRequest key)
		{
			return null;
		}

		private bool IsValid(TransferType type, object value)
		{
			return false;
		}
	}
}
