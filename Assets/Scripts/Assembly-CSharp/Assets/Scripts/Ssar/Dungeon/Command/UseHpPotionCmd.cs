using Assets.Scripts.Core.Skills.Modifiers;
using Assets.Scripts.Ssar.Dungeon.GameModeLogic;
using Assets.Scripts.Ssar.Dungeon.Signal;
using SSAR.BattleSystem.Damage;
using Scripts.Config;
using Ssar.Analytics.Metrics;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Dungeon.Command
{
	public class UseHpPotionCmd : strange.extensions.command.impl.Command
	{
		public class DefaultInstantHpInfo : InstantHpModifier.Info
		{
			private float percentage;

			private float point;

			private string effectPath;

			public DefaultInstantHpInfo(float percentage, float point)
			{
			}

			public DefaultInstantHpInfo(float percentage, float point, string effectPath)
			{
			}

			public float Percentage()
			{
				return 0f;
			}

			public float Point()
			{
				return 0f;
			}

			public string EffectPath()
			{
				return null;
			}
		}

		[Inject]
		public int count { get; set; }

		[Inject]
		public UpdateMainCharacterHealthSignal UpdateMainCharacterHealthSignal { get; set; }

		[Inject]
		public Metric metric { get; set; }

		[Inject]
		public ConfigManager configManager { get; set; }

		[Inject]
		public OnUseHpPotionSuccessSignal OnUseHpPotionSuccessSignal { get; set; }

		[Inject]
		public IBattleModeLogic battleModeLogic { get; set; }

		public override void Execute()
		{
		}

		private void SendUseHpPotionMetric(MainCharacterData mcd, HealthComponent healthComponent)
		{
		}
	}
}
