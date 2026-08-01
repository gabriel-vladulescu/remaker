using Assets.Scripts.Ssar.CharacterSelection.Model;
using Assets.Scripts.Ssar.CharacterSelection.View;
using Assets.Scripts.Ssar.Signal;
using Ssar.Analytics.Metrics;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.CharacterSelection.Command
{
	public class CreateCharacterCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public CharacterCode TabType { get; set; }

		[Inject]
		public string name { get; set; }

		[Inject]
		public OnCreateCharacterSuccessSignal OnCreateCharacterSuccessSignal { get; set; }

		[Inject]
		public Metric metric { get; set; }

		[Inject]
		public CreateCharacterWidget.CharacterCreationSource characterCreationSource { get; set; }

		public override void Execute()
		{
		}

		private void SendCreateHeroMetric(int groupId, int subId, int count, CreateCharacterWidget.CharacterCreationSource characterCreationSource)
		{
		}

		private void SendResourceIn(MainCharacterData mcd)
		{
		}

		private bool NameIsValid()
		{
			return false;
		}
	}
}
