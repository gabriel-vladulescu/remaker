using System;
using UnityEngine;

namespace buildTools
{
	[Serializable]
	[CreateAssetMenu(menuName = "ScriptableOject/BuildConfig")]
	public class BuildConfigTool : ScriptableObject
	{
		public string configVersion;

		public LoadAssetsMode loadAssetsMode;

		public string keyStorePassword;

		public string keyStoreAlias;

		public string keyStoreAliasPassword;

		public int bundleVersionCode;

		public bool isBuildDev;
	}
}
