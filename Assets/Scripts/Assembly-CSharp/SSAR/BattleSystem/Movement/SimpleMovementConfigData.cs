using UnityEngine;

namespace SSAR.BattleSystem.Movement
{
	public class SimpleMovementConfigData : MonoBehaviour
	{
		[Header("Move")]
		public float moveSpeed;

		[SerializeField]
		private float maxMoveSpeed;

		public float MaxMoveSpeed => 0f;
	}
}
