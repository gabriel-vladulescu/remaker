using UnityEngine;

namespace Ssar.BattleSystem.EntityTemplate
{
	public class BehitVfxConfigData : MonoBehaviour
	{
		[SerializeField]
		private VFXBehitEntity vfxBehit;

		[SerializeField]
		private Vector3 offsetPosition;

		public VFXBehitEntity VfxBehitEntity => default(VFXBehitEntity);

		public Vector3 OffsetPosition => default(Vector3);
	}
}
