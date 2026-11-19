using System.Collections.Generic;
using UnityEngine;

public class DioramaEdit : MonoBehaviour
{
	[Header("Properties")]
	public GameMode gameMode;

	[Header("Components")]
	public PlayerInput input;

	public Gizmo gizmo;

	private LibraryObject libraryModel;

	private DioramaTool tool;

	private Vector3 velocity;

	private Vector2 mousePosition;

	private Vector2 mousePositionBegin;

	private int boxSelecting;

	private bool dragging;

	private bool allowPlacement;

	private bool active;

	private MovementType movementType;

	private LayerMask maskDefault;

	private LayerMask maskGizmo;

	private bool soundRotatePitch;

	private Vector3 holderPosition;

	private Vector3 positionAdditional;

	private Quaternion rotationInitial;

	private float rotationAdditional;

	private DioramaObject hoveringObject;

	private bool optionStickToSurface;

	private bool optionDirectGizmo;

	public static DioramaEdit instance { get; private set; }

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public void Placement(bool _interaction = true)
	{
	}

	private void UpdatePlacementPosition(bool _shift, bool _control, RaycastHit _hit, bool _hasHit)
	{
	}

	private void HandlePlacementInteraction(bool _shift, RaycastHit _hit, bool _hasHit)
	{
	}

	public void ApplyHolderPosition()
	{
	}

	public void HandleRotation(float _angles = 16f)
	{
	}

	private void HandleSelection()
	{
	}

	private void HandleSelectionDefault()
	{
	}

	private void HandleSelectionClean()
	{
	}

	public void HandleToolbar(Vector3 _position)
	{
	}

	public DioramaObject GetDioramaObject(Transform transform)
	{
		return null;
	}

	public void RotateSelectedObject(float _value)
	{
	}

	public DioramaObject GetSelectedObject()
	{
		return null;
	}

	public void SoundTick(string _sound = "Audio/model-rotate")
	{
	}

	public void SoundScale(float _scale, float _value)
	{
	}

	public void RemoveObjects(List<GameObject> _objects, bool _sound = true, bool _sparkle = true)
	{
	}

	public void RemoveObject(GameObject _object, bool _sound = true, bool _sparkle = true)
	{
	}

	public void ObjectLoad(DioramaChunk _chunk, bool _animate = false)
	{
	}

	public void ResetHolder(bool _resetAdditional = true)
	{
	}

	public void ResetHolder(DioramaChunk _chunk, bool _resetAdditional = true)
	{
	}

	public void SetLibraryModel(DioramaChunk _chunk)
	{
	}

	public void ResetMovementType()
	{
	}

	public void SetMovementType(MovementType _movementType)
	{
	}

	public void SetActive(bool _active)
	{
	}

	public bool GetActive()
	{
		return false;
	}

	public void SetAllowPlacement(bool _allowPlacement)
	{
	}

	public void SetDragging(bool _dragging)
	{
	}

	public void SetTool(DioramaTool _tool)
	{
	}

	public void SetOptionStickToSurface(bool _active)
	{
	}

	public void SetOptionDirectGizmo(bool _active)
	{
	}

	public void AlignGridToSelection(bool _active)
	{
	}
}
