using System;
using System.Collections.Generic;

namespace Assets.Scripts.Ssar.SceneLoader.View
{
	[Serializable]
	public class LoadingSceneChacterSetEquipment
	{
		public List<LoadingSceneChacterEquipment> list;

		public string name;

		public LoadingSceneChacterSetEquipment(string name)
		{
		}
	}
}
