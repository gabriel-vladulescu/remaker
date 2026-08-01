using System;
using System.Collections.Generic;

namespace Scripts.Config
{
	public class ConfigManager
	{
		private class ConfigData
		{
			public string text;

			public IConfig config;

			private bool isNew;

			public void SetData(string text)
			{
			}

			public T GetConfig<T>() where T : IConfig
			{
				return default(T);
			}
		}

		private string FOLDER;

		private Dictionary<Type, ConfigData> dic;

		private GameConfigPathScriptableObject setup;

		protected bool hasInit;

		public virtual void Init()
		{
		}

		public void SetFileSetup(GameConfigPathScriptableObject data)
		{
		}

		public void Map(string name, string text)
		{
		}

		public void MapConfig<T>(string text) where T : IConfig
		{
		}

		public T GetConfig<T>() where T : IConfig
		{
			return default(T);
		}

		public GameConfigPathScriptableObject GetSetup()
		{
			return null;
		}

		public string Version()
		{
			return null;
		}

		protected List<string> GetListConfigInitWhenRun()
		{
			return null;
		}
	}
}
