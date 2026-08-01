using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class PSMeshRendererUpdater : MonoBehaviour
{
	public GameObject MeshObject;

	private const string materialName = "MeshEffect";

	private List<Material[]> rendererMaterials;

	private List<Material[]> skinnedMaterials;

	public bool IsActive;

	private bool currentActiveStatus;

	private void Update()
	{
	}

	public void Activation(bool activeStatus)
	{
	}

	public void UpdateMeshEffect()
	{
	}

	public void UpdateMeshEffect(GameObject go)
	{
	}

	private void UpdatePSMesh(GameObject go)
	{
	}

	private void AddMaterialToMesh(GameObject go)
	{
	}

	private Material[] AddToSharedMaterial(Material[] sharedMaterials, WFX_MeshMaterialEffect meshMatEffect)
	{
		return null;
	}

	private void OnDestroy()
	{
	}
}
