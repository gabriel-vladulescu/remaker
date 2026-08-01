using UnityEngine;

public class VfxNotAutoSpawn : MonoBehaviour
{
	public enum VfxType
	{
		Normal = 0,
		Break = 1,
		Startup = 2
	}

	public VfxType vfxType;
}
