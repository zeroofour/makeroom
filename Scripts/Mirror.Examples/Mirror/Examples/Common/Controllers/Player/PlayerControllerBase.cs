using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace Mirror.Examples.Common.Controllers.Player;

[DisallowMultipleComponent]
[RequireComponent(typeof(NetworkIdentity))]
[RequireComponent(typeof(CharacterController))]
[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(CapsuleCollider))]
[AddComponentMenu(null)]
public class PlayerControllerBase : NetworkBehaviour
{
	public enum GroundState : byte
	{
		Grounded = 0,
		Jumping = 1,
		Falling = 2
	}

	[Serializable]
	public struct MoveKeys
	{
		public KeyCode Forward;

		public KeyCode Back;

		public KeyCode StrafeLeft;

		public KeyCode StrafeRight;

		public KeyCode TurnLeft;

		public KeyCode TurnRight;

		public KeyCode Jump;
	}

	[Serializable]
	public struct OptionsKeys
	{
		public KeyCode MouseSteer;

		public KeyCode AutoRun;

		public KeyCode ToggleUI;
	}

	[Flags]
	public enum ControlOptions : byte
	{
		None = 0,
		MouseSteer = 1,
		AutoRun = 2,
		ShowUI = 4
	}

	[Serializable]
	public struct RuntimeData
	{
		[Range(-1f, 1f)]
		[ReadOnly]
		[SerializeField]
		private float _horizontal;

		[ReadOnly]
		[SerializeField]
		[Range(-1f, 1f)]
		private float _vertical;

		[ReadOnly]
		[SerializeField]
		[Range(-300f, 300f)]
		private float _turnSpeed;

		[SerializeField]
		[ReadOnly]
		[Range(-10f, 10f)]
		private float _jumpSpeed;

		[Range(-1.5f, 1.5f)]
		[ReadOnly]
		[SerializeField]
		private float _animVelocity;

		[Range(-1.5f, 1.5f)]
		[ReadOnly]
		[SerializeField]
		private float _animRotation;

		[ReadOnly]
		[SerializeField]
		[Range(-1f, 1f)]
		private float _mouseInputX;

		[Range(0f, 30f)]
		[SerializeField]
		[ReadOnly]
		private float _mouseSensitivity;

		[ReadOnly]
		[SerializeField]
		private GroundState _groundState;

		[ReadOnly]
		[SerializeField]
		private Vector3 _direction;

		[ReadOnly]
		[SerializeField]
		private Vector3Int _velocity;

		[SerializeField]
		[ReadOnly]
		private GameObject _controllerUI;

		public float horizontal
		{
			get
			{
				return 0f;
			}
			internal set
			{
			}
		}

		public float vertical
		{
			get
			{
				return 0f;
			}
			internal set
			{
			}
		}

		public float turnSpeed
		{
			get
			{
				return 0f;
			}
			internal set
			{
			}
		}

		public float jumpSpeed
		{
			get
			{
				return 0f;
			}
			internal set
			{
			}
		}

		public float animVelocity
		{
			get
			{
				return 0f;
			}
			internal set
			{
			}
		}

		public float animRotation
		{
			get
			{
				return 0f;
			}
			internal set
			{
			}
		}

		public float mouseInputX
		{
			get
			{
				return 0f;
			}
			internal set
			{
			}
		}

		public float mouseSensitivity
		{
			get
			{
				return 0f;
			}
			internal set
			{
			}
		}

		public GroundState groundState
		{
			get
			{
				return GroundState.Grounded;
			}
			internal set
			{
			}
		}

		public Vector3 direction
		{
			get
			{
				return default;
			}
			internal set
			{
			}
		}

		public Vector3Int velocity
		{
			get
			{
				return default;
			}
			internal set
			{
			}
		}

		public GameObject controllerUI
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}
	}

	private const float BASE_DPI = 96f;

	[Header("Avatar Components")]
	public CharacterController characterController;

	[Header("User Interface")]
	public GameObject ControllerUIPrefab;

	[SerializeField]
	[Header("Configuration")]
	public MoveKeys moveKeys;

	[SerializeField]
	public OptionsKeys optionsKeys;

	[Space(5f)]
	public ControlOptions controlOptions;

	[Header("Movement")]
	[Range(0f, 20f)]
	[FormerlySerializedAs("moveSpeedMultiplier")]
	[Tooltip("Speed in meters per second")]
	public float maxMoveSpeed;

	[Range(0f, 10f)]
	[Tooltip("Sensitivity factors into accelleration")]
	public float inputSensitivity;

	[Range(0f, 10f)]
	[Tooltip("Gravity factors into decelleration")]
	public float inputGravity;

	[Header("Turning")]
	[Range(0f, 300f)]
	[Tooltip("Max Rotation in degrees per second")]
	public float maxTurnSpeed;

	[Range(0f, 10f)]
	[FormerlySerializedAs("turnDelta")]
	[Tooltip("Rotation acceleration in degrees per second squared")]
	public float turnAcceleration;

	[Header("Jumping")]
	[Range(0f, 10f)]
	[Tooltip("Initial jump speed in meters per second")]
	public float initialJumpSpeed;

	[Tooltip("Maximum jump speed in meters per second")]
	[Range(0f, 10f)]
	public float maxJumpSpeed;

	[FormerlySerializedAs("jumpDelta")]
	[Range(0f, 10f)]
	[Tooltip("Jump acceleration in meters per second squared")]
	public float jumpAcceleration;

	[Header("Diagnostics")]
	public RuntimeData runtimeData;

	protected override void OnValidate()
	{
	}

	private void Reset()
	{
	}

	private void OnDisable()
	{
	}

	public override void OnStartAuthority()
	{
	}

	public override void OnStopAuthority()
	{
	}

	public override void OnStartLocalPlayer()
	{
	}

	public override void OnStopLocalPlayer()
	{
	}

	private void Update()
	{
	}

	private void SetCursor(bool locked)
	{
	}

	private void HandleOptions()
	{
	}

	private void HandleTurning(float deltaTime)
	{
	}

	private void HandleMouseSteer(float deltaTime)
	{
	}

	private void HandleJumping(float deltaTime)
	{
	}

	private void HandleMove(float deltaTime)
	{
	}

	private void ApplyMove(float deltaTime)
	{
	}

	public override bool Weaved()
	{
		return false;
	}
}
