using System.Collections.Generic;
using SSAR.Equipment.Model;

namespace Ssar.Ancient.Command
{
	public class EnhanceAncientParams
	{
		public EquipmentCollectData mainAncient;

		public List<EquipmentCollectData> materials;

		public EnhanceAncientParams(EquipmentCollectData mainAncient, List<EquipmentCollectData> materials)
		{
		}
	}
}
