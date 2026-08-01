namespace Scripts.Config.Remote
{
	public class FileFromDisk
	{
		private string pathToVersionConstant;

		private string formatOfPathToConfigFile;

		public bool TryLoadConfigFile(string name, ref string text)
		{
			return false;
		}

		public bool TryLoadVersionConstant(ref VersionConstant vc)
		{
			return false;
		}

		public bool IsVersionConstantExisted()
		{
			return false;
		}

		public bool IsFileExisted(string path)
		{
			return false;
		}

		public bool SaveVersionConstant(VersionConstant vc)
		{
			return false;
		}

		public bool SaveObjectToFile(object obj, string path)
		{
			return false;
		}

		public bool SaveTextToFile(string text, string path)
		{
			return false;
		}

		public bool LoadTextFromFile(string path, ref string text)
		{
			return false;
		}
	}
}
