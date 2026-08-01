using System;
using System.Collections.Generic;
using UnityEngine;

namespace Ssar.Database
{
	[Serializable]
	[CreateAssetMenu(menuName = "ScriptableOject/FirebaseUserDataConfig")]
	public class FirebaseUserDataConfig : ScriptableObject
	{
		[SerializeField]
		public List<string> userDefinedFields;
	}
}
