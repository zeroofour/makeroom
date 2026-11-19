using System.Collections.Generic;
using UnityEngine;

public class Gizmo : MonoBehaviour
{
	[Header("Components")]
	public Transform gizmo;

	public LocalizationText gridDisplay;

	public PlayerInput input;

	private List<GameObject> targetList;

	private List<Vector3> startPositions;

	private List<Quaternion> startRotations;

	private Vector3 startCenter;

	private List<Vector3> targetPositions;

	private List<Quaternion> targetRotations;

	private List<Vector3> targetScales;

	private Vector2 mousePosition;

	private Transform handle;

	private Transform handleHover;

	private List<MeshRenderer> renderers;

	private List<GameObject> scaleHandles;

	private LibraryObject targetObject;

	private Bounds initialBounds;

	private Vector3 initialPosition;

	private Vector3 initialRotation;

	private Vector3 initialScale;

	private Vector3 dragStartPosition;

	private Vector3 dragAxis;

	private float startDistance;

	private float smoothing;

	private float grid;

	private int gridIndex;

	private float[] gridValues;

	private float[] gridValuesMultiplied;

	private float[] gridValuesMovement;

	private float[] angleValues;

	private string[] gridValueNames;

	public static Gizmo instance { get; private set; }

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void Preparation()
	{
	}

	private void Size()
	{
	}

	public void SetSelection()
	{
	}

	public void Set(List<GameObject> _targets)
	{
	}

	public void Set(GameObject _target)
	{
	}

	public void Refresh(bool _shift = false, bool _instant = false)
	{
	}

	public void Reset()
	{
	}

	public void Drag(Transform _handle)
	{
	}

	private void SetTarget(int _index, Vector3 _position, Quaternion _rotation, Vector3 _scale)
	{
	}

	private void ApplyTargets()
	{
	}

	private Vector3 GetSelectionCenter()
	{
		return default;
	}

	public void Hover(Transform _handle)
	{
	}

	public void HoverOut()
	{
	}

	public bool Using()
	{
		return false;
	}

	public Vector3 Clamp(Vector3 _value, float _min, float _max)
	{
		return default;
	}

	public void GridLarger()
	{
	}

	public void GridSmaller()
	{
	}

	public float GetGrid(float _minimum = 0.01f)
	{
		return 0f;
	}

	public float GetGridMultiplied()
	{
		return 0f;
	}

	public float GetGridMovement(float _minimum = 0.01f)
	{
		return 0f;
	}

	public float GetGridRotation()
	{
		return 0f;
	}

	public void SetGrid()
	{
	}

	private Vector3 GetMouseWorldPosition()
	{
		return default;
	}

	private Vector3 ClosestPointOnLine(Vector3 _lineOrigin, Vector3 _lineDir, Ray _ray)
	{
		return default;
	}

	private Bounds GetBounds(GameObject _root)
	{
		return default;
	}
}
