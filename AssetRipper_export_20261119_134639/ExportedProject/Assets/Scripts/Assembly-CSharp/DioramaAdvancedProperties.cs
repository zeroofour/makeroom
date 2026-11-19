using UnityEngine;
using UnityEngine.UI;

public class DioramaAdvancedProperties : MonoBehaviour
{
	[Header("Properties")]
	public Text[] positions;

	public Text[] rotations;

	public Text[] scales;

	[Header("Components")]
	public SpriteRenderer propertyPreview;

	[Header("Previews")]
	public Sprite previewPosition;

	public Sprite previewRotation;

	public Sprite previewScale;

	private Vector3 startingPosition;

	private Vector3 startingRotation;

	private Vector3 startingScale;

	private bool changing;

	public static DioramaAdvancedProperties instance { get; private set; }

	private void Awake()
	{
	}

	public void Show()
	{
	}

	public void Hide()
	{
	}

	private void Update()
	{
	}

	private void UpdateProperties()
	{
	}

	public void StartChanging()
	{
	}

	public void StopChanging()
	{
	}

	public void Hover(string _property)
	{
	}

	public void HoverOut()
	{
	}

	public void Set(string _property, float _offset)
	{
	}

	private float Snap(float _value, float _increment)
	{
		return 0f;
	}

	public Vector3 Clamp(Vector3 _value, float _min, float _max)
	{
		return default;
	}
}
