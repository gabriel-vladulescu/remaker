using Scripts.Ssar.Pet;

namespace Assets.Scripts.Ssar.Pet.Command
{
	public class ShowPetManagerPopupCmd : BaseShowPopupCmd
	{
		[Inject]
		public PetCollectData PetCollectData { get; set; }

		public override void Execute()
		{
		}

		protected override string GetAssetPath()
		{
			return null;
		}

		protected override string GetInjectName()
		{
			return null;
		}

		protected override PopupCamera GetCamera()
		{
			return default(PopupCamera);
		}
	}
}
