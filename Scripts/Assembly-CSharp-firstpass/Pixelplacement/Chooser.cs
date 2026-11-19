using System.Collections.Generic;
using UnityEngine;

namespace Pixelplacement;

public class Chooser : MonoBehaviour
{
	public enum Method
	{
		Raycast = 0,
		RaycastAll = 1
	}

	public GameObjectEvent OnSelected;

	public GameObjectEvent OnDeselected;

	public GameObjectEvent OnPressed;

	public GameObjectEvent OnReleased;

	public bool _cursorPropertiesFolded;

	public bool _unityEventsFolded;

	public Transform source;

	public float raycastDistance;

	public LayerMask layermask;

	public KeyCode[] pressedInput;

	public Transform cursor;

	public float surfaceOffset;

	public float idleDistance;

	public float stabilityDelta;

	public float snapDelta;

	public float stableSpeed;

	public float unstableSpeed;

	public bool flipForward;

	public bool matchSurfaceNormal;

	public bool autoHide;

	public bool cursorHidden;

	public bool flipCastDirection;

	public LineRenderer lineRenderer;

	[SerializeField]
	private Method _method;

	[SerializeField]
	private bool _debugView;

	private Transform _previousCursor;

	private List<Transform> _current;

	private List<Transform> _previous;

	private Transform _currentRaycast;

	private Transform _previousRaycast;

	private Vector3 _targetPosition;

	private bool _hidden;

	public Transform[] Current => null;

	public bool IsHitting { get; private set; }

	private void Reset()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDrawGizmosSelected()
	{
	}

	public void Pressed()
	{
	}

	public void Released()
	{
	}

	private void Update()
	{
	}
}
