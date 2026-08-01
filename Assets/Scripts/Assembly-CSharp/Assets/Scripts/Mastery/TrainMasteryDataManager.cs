using System.Collections.Generic;
using Scripts.Config;
using Ssar.Rune.Model;

namespace Assets.Scripts.Mastery
{
	public class TrainMasteryDataManager
	{
		private MasteryInfo masterySelected;

		private List<MaterialData> materialDatas;

		public void Reset()
		{
		}

		public void SelectMastery(MasteryInfo masteryInfo)
		{
		}

		public void ClearMaterial()
		{
		}

		public MasteryInfo GetMasteryInfo()
		{
			return null;
		}

		public void AddMaterial(RuneType runeType, RuneRarity runeRarity)
		{
		}

		public void RemoveMaterial(RuneType runeType, RuneRarity runeRarity)
		{
		}

		public float GetLevelProgressWithMaterial()
		{
			return 0f;
		}

		public float GetLevelProgressWithMaterialAndSoulLink()
		{
			return 0f;
		}

		private float GetLevelProgress(int bonusExp)
		{
			return 0f;
		}

		private int GetRawMaterialsExp()
		{
			return 0;
		}

		public int GetMaterialsExpWithSoulLink()
		{
			return 0;
		}

		public int GetSoulRequire()
		{
			return 0;
		}

		public int MaterialCountOfRarity(RuneType runeType, RuneRarity runeRarity)
		{
			return 0;
		}

		private bool GetMaterialData(RuneRarity runeRarity, out MaterialData materialData)
		{
			materialData = null;
			return false;
		}

		private void AddMaterialData(MaterialData materialData)
		{
		}

		public List<MaterialData> GetMaterialDatas()
		{
			return null;
		}
	}
}
