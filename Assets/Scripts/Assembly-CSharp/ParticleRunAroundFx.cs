using UnityEngine;

public class ParticleRunAroundFx : MonoBehaviour
{
	public UIWidget widget;

	private bool hasSetup;

	private ParticleMoveEffect[] effects;

	public ParticleSystem[] glow;

	public ParticleSystem[] exp;

	private int max;

	private void Awake()
	{
	}

	public void Setup(GameObject anchor, float duration, int maxParticle = 2, bool loop = false)
	{
	}

	public void Play()
	{
	}

	public void Stop()
	{
	}
}
