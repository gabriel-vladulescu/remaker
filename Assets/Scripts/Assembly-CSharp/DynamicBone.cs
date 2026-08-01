using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Dynamic Bone/Dynamic Bone")]
public class DynamicBone : MonoBehaviour
{
	public enum FreezeAxis
	{
		None = 0,
		X = 1,
		Y = 2,
		Z = 3
	}

	private class Particle
	{
		public Transform m_Transform;

		public int m_ParentIndex;

		public float m_Damping;

		public float m_Elasticity;

		public float m_Stiffness;

		public float m_Inert;

		public float m_Radius;

		public float m_BoneLength;

		public Vector3 m_Position;

		public Vector3 m_PrevPosition;

		public Vector3 m_EndOffset;

		public Vector3 m_InitLocalPosition;

		public Quaternion m_InitLocalRotation;
	}

	public Transform m_Root;

	public float m_UpdateRate;

	[Range(0f, 1f)]
	public float m_Damping;

	public AnimationCurve m_DampingDistrib;

	[Range(0f, 1f)]
	public float m_Elasticity;

	public AnimationCurve m_ElasticityDistrib;

	[Range(0f, 1f)]
	public float m_Stiffness;

	public AnimationCurve m_StiffnessDistrib;

	[Range(0f, 1f)]
	public float m_Inert;

	public AnimationCurve m_InertDistrib;

	public float m_Radius;

	public AnimationCurve m_RadiusDistrib;

	public float m_EndLength;

	public Vector3 m_EndOffset;

	public Vector3 m_Gravity;

	public Vector3 m_Force;

	public List<DynamicBoneCollider> m_Colliders;

	public List<Transform> m_Exclusions;

	public FreezeAxis m_FreezeAxis;

	public bool m_DistantDisable;

	public Transform m_ReferenceObject;

	public float m_DistanceToObject;

	private Vector3 m_LocalGravity;

	private Vector3 m_ObjectMove;

	private Vector3 m_ObjectPrevPosition;

	private float m_BoneTotalLength;

	private float m_ObjectScale;

	private float m_Time;

	private float m_Weight;

	private bool m_DistantDisabled;

	private List<Particle> m_Particles;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	private void CheckDistance()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnValidate()
	{
	}

	private void OnDrawGizmosSelected()
	{
	}

	public void SetWeight(float w)
	{
	}

	public float GetWeight()
	{
		return 0f;
	}

	private void UpdateDynamicBones(float t)
	{
	}

	private void SetupParticles()
	{
	}

	private void AppendParticles(Transform b, int parentIndex, float boneLength)
	{
	}

	private void InitTransforms()
	{
	}

	private void ResetParticlesPosition()
	{
	}

	private void UpdateParticles1()
	{
	}

	private void UpdateParticles2()
	{
	}

	private void SkipUpdateParticles()
	{
	}

	private void ApplyParticlesToTransforms()
	{
	}
}
