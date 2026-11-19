using UnityEngine.EventSystems;

namespace UnityEngine.InputSystem.UI;

internal struct PointerModel
{
	public struct ButtonState
	{
		private bool m_IsPressed;

		private PointerEventData.FramePressState m_FramePressState;

		private float m_PressTime;

		private RaycastResult m_PressRaycast;

		private GameObject m_PressObject;

		private GameObject m_RawPressObject;

		private GameObject m_LastPressObject;

		private GameObject m_DragObject;

		private Vector2 m_PressPosition;

		private float m_ClickTime;

		private int m_ClickCount;

		private bool m_Dragging;

		private bool m_ClickedOnSameGameObject;

		private bool m_IgnoreNextClick;

		public bool isPressed
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool ignoreNextClick
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float pressTime
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool clickedOnSameGameObject
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool wasPressedThisFrame => false;

		public bool wasReleasedThisFrame => false;

		public void CopyPressStateTo(PointerEventData eventData)
		{
		}

		public void CopyPressStateFrom(PointerEventData eventData)
		{
		}

		public void OnEndFrame()
		{
		}
	}

	public bool changedThisFrame = false;

	public ButtonState leftButton = default;

	public ButtonState rightButton = default;

	public ButtonState middleButton = default;

	public ExtendedPointerEventData eventData = null;

	private Vector2 m_ScreenPosition = default;

	private Vector2 m_ScrollDelta = default;

	private Vector3 m_WorldPosition = default;

	private Quaternion m_WorldOrientation = default;

	private float m_Pressure = 0f;

	private float m_AzimuthAngle = 0f;

	private float m_AltitudeAngle = 0f;

	private float m_Twist = 0f;

	private Vector2 m_Radius = default;

	public UIPointerType pointerType => UIPointerType.None;

	public Vector2 screenPosition
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public Vector3 worldPosition
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public Quaternion worldOrientation
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public Vector2 scrollDelta
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public float pressure
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float azimuthAngle
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float altitudeAngle
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float twist
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public Vector2 radius
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public PointerModel(ExtendedPointerEventData eventData)
	{
	}

	public void OnFrameFinished()
	{
	}

	public void CopyTouchOrPenStateFrom(PointerEventData eventData)
	{
	}
}
