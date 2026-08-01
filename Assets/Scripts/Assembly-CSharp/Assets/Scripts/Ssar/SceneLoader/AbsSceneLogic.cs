namespace Assets.Scripts.Ssar.SceneLoader
{
	public abstract class AbsSceneLogic
	{
		private string sceneName;

		public string SceneName => null;

		public AbsSceneLogic(string sceneName)
		{
		}

		public abstract void OnExcute();
	}
}
