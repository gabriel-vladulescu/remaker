namespace Scripts.Config.Remote
{
	public class Downloader
	{
		private class Counter
		{
			private int value;

			public Counter(int value)
			{
			}

			public void Increase()
			{
			}

			public int Value()
			{
				return 0;
			}
		}

		private string format;

		private string[] fileNames;

		private string firebaseStorageUrl;

		private int firebaseStorageMaxAllowedSize;

		private bool downloading;

		public Downloader(string[] fileNames, string firebaseStorageUrl, int firebaseStorageMaxAllowedSize)
		{
		}

		public bool IsDownloading(int version)
		{
			return false;
		}

		public bool IsFinishDownloading(int version)
		{
			return false;
		}
	}
}
