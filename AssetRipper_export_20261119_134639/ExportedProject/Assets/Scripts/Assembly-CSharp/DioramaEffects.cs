using UnityEngine;

public class DioramaEffects : MonoBehaviour
{
	[Header("Effects")]
	public GameObject effectSnow;

	public GameObject effectRain;

	public GameObject effectVehicleShadow;

	public GameObject effectOcean;

	[Header("Particles")]
	public ParticleSystem effectDust;

	public ParticleSystem effectSplash;

	public GameObject particleDome;

	public static DioramaEffects instance { get; private set; }

	private void Awake()
	{
	}

	public void ToggleSnow(bool _active)
	{
	}

	public void ToggleRain(bool _active)
	{
	}

	public void ToggleVehicleShadow(bool _active)
	{
	}

	public void ToggleOcean(bool _active)
	{
	}

	public void SetVehicleShadowLength(float _length = 4.75f)
	{
	}

	public void Sparkles(DioramaChunk _chunk)
	{
	}

	public void Sparkles(GameObject _object)
	{
	}

	public void Sparkles(Vector3 _position, Vector3 _size, int _count = 10)
	{
	}

	public void Splash(Vector3 _position, Vector3 _rotation, int _count = 20, int _color = 0, float _scale = 1f, DioramaChunk _chunk = null)
	{
	}

	public void Domes(Vector3 _position, Vector3 _rotation, int _count = 20, float _scale = 1f, DioramaChunk _chunk = null)
	{
	}
}
