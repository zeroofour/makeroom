using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class View : MonoBehaviour
{
	public enum Mode
	{
		Diorama = 0,
		World = 1,
		Preview = 2,
		Animation = 3
	}

	[Header("Components")]
	public PlayerInput input;

	public PostProcessVolume volume;

	public ViewUnrestricted viewUnrestricted;

	private Camera camera;

	public Camera cameraGizmo;

	private Mode mode;

	private Vector3 rotation;

	private float zoom;

	private float maximumZoom;

	private Vector3 zoomVelocity;

	private float zoomVelocityOrthographic;

	private Vector3 positionVelocity;

	private Vector3 offset;

	private Vector3 basePosition;

	private KenneyOutline outline;

	private bool immediatelySetZoom;

	private bool restricted;

	private bool checkControl;

	private bool checkTitlescreen;

	private bool checkHolding;

	private Plane groundPlane;

	private Vector3 panOffset;

	private Vector3 focusAnchor;

	private Vector3 focusOffset;

	private bool focusActive;

	private LayerMask focusMask;

	private float focusZoom;

	private float focusLimit;

	public static View instance { get; private set; }

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void ViewModeDiorama()
	{
	}

	private void CheckRestrictions()
	{
	}

	private void HandleDrag()
	{
	}

	private void HandleRotation()
	{
	}

	private void SetFocus()
	{
	}

	private bool GetFocusPoint(out Vector3 _point)
	{
		_point = default;
		return false;
	}

	private void HandleZoom()
	{
	}

	private void HandleZoomFocus(float _previousZoom)
	{
	}

	private void ViewModeWorld()
	{
	}

	private void ViewModeAnimation()
	{
	}

	public void SetCameraMode(bool _perspective)
	{
	}

	public bool InputAllowed(bool _holdingAllowed = false)
	{
		return false;
	}

	public void Reset()
	{
	}

	public void SetBasePosition(Vector3 _vector)
	{
	}

	public void SetFOV()
	{
	}

	public void SetFOVDefault()
	{
	}

	private float GetLogarithmicZoomMultiplier(float _zoom)
	{
		return 0f;
	}

	private Vector3 GetPanPosition(float _zoom)
	{
		return default;
	}

	private float GetZoomDistance(float _zoom)
	{
		return 0f;
	}

	private float GetZoomSize(float _zoom)
	{
		return 0f;
	}

	private float GetFocusWeight()
	{
		return 0f;
	}

	public void SetMode(Mode _mode)
	{
	}

	public void SwitchCameraMode(bool _active, bool _silent = true)
	{
	}

	public void SwitchCameraMode()
	{
	}
}
