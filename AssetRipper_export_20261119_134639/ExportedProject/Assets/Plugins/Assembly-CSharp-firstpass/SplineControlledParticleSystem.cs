using Pixelplacement;
using UnityEngine;

[RequireComponent(typeof(Spline))]
[ExecuteInEditMode]
public class SplineControlledParticleSystem : MonoBehaviour
{
	public float startRadius;

	public float endRadius;

	[SerializeField]
	private ParticleSystem _particleSystem;

	private Spline _spline;

	private ParticleSystem.Particle[] _particles;

	private const float _previousDiff = 0.01f;

	private void Awake()
	{
	}

	private void LateUpdate()
	{
	}
}
