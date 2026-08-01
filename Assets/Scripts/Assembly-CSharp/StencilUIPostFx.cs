using UnityEngine;

[ExecuteInEditMode]
public class StencilUIPostFx : MonoBehaviour
{
	public Shader stencilInterpolateShader;

	public Camera cam;

	public Color shadowColor;

	[SerializeField]
	protected int layer;

	private Mesh quadMesh;

	private Material stencilInterpolateMat;

	private void Start()
	{
	}

	protected void CreateQuadMesh()
	{
	}

	private void Update()
	{
	}

	private void DrawShadow()
	{
	}
}
