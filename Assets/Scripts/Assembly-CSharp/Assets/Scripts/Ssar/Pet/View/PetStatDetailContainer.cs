using System.Collections.Generic;
using SSAR.Equipment.Enum;
using SSAR.Equipment.View;
using Scripts.Ssar.Pet;
using UnityEngine;

namespace Assets.Scripts.Ssar.Pet.View
{
	public class PetStatDetailContainer : MonoBehaviour
	{
		public UITable table_offense;

		public UITable table_defense;

		private Dictionary<StatType, CharacterStatDetailRowView> subStas;

		private void Awake()
		{
		}

		private void Init()
		{
		}

		public void Show(PetCollectData petCollectData, MainCharacterData mainCharacterData)
		{
		}

		private void ShowStat(StatType statType, double value)
		{
		}

		private void InitOffense()
		{
		}

		private void InitDefense()
		{
		}

		private void AddStat(UITable parent, StatType statType, int width, bool hasColor = false)
		{
		}
	}
}
