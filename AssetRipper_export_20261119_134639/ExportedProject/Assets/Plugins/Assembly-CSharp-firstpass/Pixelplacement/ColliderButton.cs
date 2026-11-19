using System;
using System.Runtime.CompilerServices;
using Pixelplacement.TweenSystem;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Pixelplacement
{
	[ExecuteInEditMode]
	[RequireComponent(typeof(Rigidbody))]
	[RequireComponent(typeof(Collider))]
	public sealed class ColliderButton : MonoBehaviour
	{
		public enum EaseType
		{
			EaseOut = 0,
			EaseOutBack = 1
		}

		public ColliderButtonEvent OnSelected;

		public ColliderButtonEvent OnDeselected;

		public ColliderButtonEvent OnClick;

		public ColliderButtonEvent OnPressed;

		public ColliderButtonEvent OnReleased;

		[CompilerGenerated]
		private static Action<ColliderButton> m_OnSelectedGlobal;

		[CompilerGenerated]
		private static Action<ColliderButton> m_OnDeselectedGlobal;

		[CompilerGenerated]
		private static Action<ColliderButton> m_OnClickGlobal;

		[CompilerGenerated]
		private static Action<ColliderButton> m_OnPressedGlobal;

		[CompilerGenerated]
		private static Action<ColliderButton> m_OnReleasedGlobal;

		public KeyCode[] keyInput;

		public bool _unityEventsFolded;

		public bool _scaleResponseFolded;

		public bool _colorResponseFolded;

		public bool applyColor;

		public bool applyScale;

		public LayerMask collisionLayerMask;

		public Renderer colorRendererTarget;

		public Image colorImageTarget;

		public Color selectedColor;

		public Color pressedColor;

		public Color disabledColor;

		public float colorDuration;

		public Transform scaleTarget;

		public Vector3 normalScale;

		public Vector3 selectedScale;

		public Vector3 pressedScale;

		public float scaleDuration;

		public EaseType scaleEaseType;

		public bool resizeGUIBoxCollider;

		public bool centerGUIBoxCollider;

		public Vector2 guiBoxColliderPadding;

		public bool interactable;

		private bool _clicking;

		private int _selectedCount;

		private bool _colliderSelected;

		private bool _pressed;

		private bool _released;

		private bool _vrRunning;

		private RectTransform _rectTransform;

		private EventTrigger _eventTrigger;

		private EventTrigger.Entry _pressedEventTrigger;

		private EventTrigger.Entry _releasedEventTrigger;

		private EventTrigger.Entry _enterEventTrigger;

		private EventTrigger.Entry _exitEventTrigger;

		private int _colliderCount;

		private BoxCollider _boxCollider;

		private TweenBase _colorTweenImage;

		private TweenBase _colorTweenMaterial;

		private TweenBase _scaleTween;

		private Color _normalColorRenderer;

		private Color _normalColorImage;

		private bool _interactableStatus;

		public bool IsSelected { get; private set; }

		public static event Action<ColliderButton> OnSelectedGlobal
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<ColliderButton> OnDeselectedGlobal
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<ColliderButton> OnClickGlobal
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<ColliderButton> OnPressedGlobal
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<ColliderButton> OnReleasedGlobal
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private void Reset()
		{
		}

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Update()
		{
		}

		private void OnTriggerStay(Collider other)
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		private void OnTriggerExit(Collider other)
		{
		}

		private void OnPointerDownDelegate(PointerEventData data)
		{
		}

		private void OnPointerUpDelegate(PointerEventData data)
		{
		}

		private void OnPointerEnterDelegate(PointerEventData data)
		{
		}

		private void OnPointerExitDelegate(PointerEventData data)
		{
		}

		private void OnMouseDown()
		{
		}

		private void OnMouseUp()
		{
		}

		private void OnMouseEnter()
		{
		}

		private void OnMouseExit()
		{
		}

		public void Deselected()
		{
		}

		public void Selected()
		{
		}

		public void Pressed()
		{
		}

		public void Released()
		{
		}

		private void ResizeGUIBoxCollider(BoxCollider boxCollider)
		{
		}

		private void ColorReset()
		{
		}

		private void ColorNormal()
		{
		}

		private void ColorSelected()
		{
		}

		private void ColorPressed()
		{
		}

		private void ColorDisabled()
		{
		}

		private void ScaleReset()
		{
		}

		private void ScaleNormal()
		{
		}

		private void ScaleSelected()
		{
		}

		private void ScalePressed()
		{
		}
	}
}
