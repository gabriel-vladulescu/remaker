using Scripts.Config;
using Ssar.Rune.Model;

namespace Assets.Scripts.Ssar.Rune
{
	public class RuneDisassembling
	{
		private RuneConfig runeConfig;

		private MainCharacterData mainCharacterData;

		private RuneType runeType;

		private RuneRarity runeRarity;

		public RuneDisassembling(RuneConfig runeConfig, MainCharacterData mainCharacterData, RuneType runeType, RuneRarity runeRarity)
		{
		}

		public void Disassemble(int amount, ref global::Ssar.Rune.Model.Rune lowerRune, ref global::Ssar.Rune.Model.Rune higherRune, ref bool success)
		{
		}

		private void ThrowException(string msg)
		{
		}
	}
}
