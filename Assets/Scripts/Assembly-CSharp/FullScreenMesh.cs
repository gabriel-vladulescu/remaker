using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(ParticleSystem))]
public class FullScreenMesh : MonoBehaviour
{
	public Material mat;

	public Gradient colorOverLifetime;

	private Mesh quadMesh;

	private ParticleSystem ps;

	private void Start()
	{
	}

	protected void CreateQuadMesh()
	{
	}

	private void Update()
	{
	}

	private void DrawMesh()
	{
	}
}
