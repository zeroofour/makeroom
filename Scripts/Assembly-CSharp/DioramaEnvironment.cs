using UnityEngine;

public class DioramaEnvironment : MonoBehaviour
{
	[Header("Foliage")]
	public Mesh mesh;

	[Header("Foliage properties")]
	public float area;

	public float sizeMultiplier;

	public float offsetMultiplier;

	private string seed;

	private int amount;

	private float offset;

	private Material material;

	private Matrix4x4[] matrices;

	private MaterialPropertyBlock block;

	private Bounds bounds;

	private bool foliage;

	public static DioramaEnvironment instance { get; private set; }

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public void SetFoliage(bool _foliage, string _seed, int _amount, Material _material, float _offset = 0f)
	{
	}

	private void FoliageSetup()
	{
	}

	public void FoliageRender()
	{
	}

	private bool IsPositionInsideArea(Vector3 _position)
	{
		return false;
	}

	private Vector3 HaltonSequence(int index)
	{
		return default;
	}

	private float Halton(int index, int b)
	{
		return 0f;
	}
}
