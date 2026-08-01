namespace Assets.Scripts.Ssar.Dungeon.Gates
{
	public abstract class Gate
	{
		private bool sealed_;

		public void Open()
		{
		}

		public void Close()
		{
		}

		public abstract bool IsOpened();

		public abstract bool IsClosed();

		public abstract bool IsOpening();

		public abstract bool IsClosing();

		public bool IsSealed()
		{
			return false;
		}

		public void Seal()
		{
		}

		public abstract void Update(float dt);

		protected abstract void OnOpen();

		protected abstract void OnClose();
	}
}
