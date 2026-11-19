using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace Mirror.Examples.Common.Controllers.Flyer;

[RequireComponent(typeof(CharacterController))]
[RequireComponent(typeof(CapsuleCollider))]
[DisallowMultipleComponent]
[RequireComponent(typeof(NetworkIdentity))]
[AddComponentMenu(null)]
[RequireComponent(typeof(Rigidbody))]
public class FlyerControllerBase : NetworkBehaviour
{
	[Serializable]
	public struct OptionsKeys
	{
		public KeyCode MouseSteer;

		public KeyCode AutoRun;

		public KeyCode ToggleUI;
	}

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
	}

	[Serializable]
	public struct FlightKeys
	{
		public KeyCode PitchDown;

		public KeyCode PitchUp;

		public KeyCode RollLeft;

		public KeyCode RollRight;

		public KeyCode AutoLevel;
	}

	[Flags]
	public enum ControlOptions : byte
	{
		None = 0,
		MouseSteer = 1,
		AutoRun = 2,
		AutoLevel = 4,
		ShowUI = 8
	}

	[Serializable]
	public struct RuntimeData
	{
		[Range(-1f, 1f)]
		[ReadOnly]
		[SerializeField]
		private float _horizontal;

		[SerializeField]
		[Range(-1f, 1f)]
		[ReadOnly]
		private float _vertical;

		[ReadOnly]
		[SerializeField]
		[Range(-300f, 300f)]
		private float _turnSpeed;

		[ReadOnly]
		[Range(-180f, 180f)]
		[SerializeField]
		private float _pitchAngle;

		[ReadOnly]
		[Range(-180f, 180f)]
		[SerializeField]
		private float _pitchSpeed;

		[Range(-180f, 180f)]
		[SerializeField]
		[ReadOnly]
		private float _rollAngle;

		[ReadOnly]
		[SerializeField]
		[Range(-180f, 180f)]
		private float _rollSpeed;

		[Range(-1.5f, 1.5f)]
		[SerializeField]
		[ReadOnly]
		private float _animVelocity;

		[Range(-1.5f, 1.5f)]
		[SerializeField]
		[ReadOnly]
		private float _animRotation;

		[Range(-1f, 1f)]
		[SerializeField]
		[ReadOnly]
		private float _mouseInputX;

		[ReadOnly]
		[SerializeField]
		[Range(0f, 30f)]
		private float _mouseSensitivity;

		[ReadOnly]
		[SerializeField]
		private GroundState _groundState;

		[ReadOnly]
		[SerializeField]
		private Vector3 _direction;

		[SerializeField]
		[ReadOnly]
		private Vector3Int _velocity;

		[ReadOnly]
		[SerializeField]
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

		public float pitchAngle
		{
			get
			{
				return 0f;
			}
			internal set
			{
			}
		}

		public float pitchSpeed
		{
			get
			{
				return 0f;
			}
			internal set
			{
			}
		}

		public float rollAngle
		{
			get
			{
				return 0f;
			}
			internal set
			{
			}
		}

		public float rollSpeed
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
	public CapsuleCollider capsuleCollider;

	public CharacterController characterController;

	[Header("User Interface")]
	public GameObject ControllerUIPrefab;

	[SerializeField]
	[Header("Configuration")]
	public MoveKeys moveKeys;

	[SerializeField]
	public FlightKeys flightKeys;

	[SerializeField]
	public OptionsKeys optionsKeys;

	[Space(5f)]
	public ControlOptions controlOptions;

	[Range(0f, 20f)]
	[FormerlySerializedAs("moveSpeedMultiplier")]
	[Tooltip("Speed in meters per second")]
	[Header("Movement")]
	public float maxMoveSpeed;

	[Range(0f, 10f)]
	[Tooltip("Sensitivity factors into accelleration")]
	public float inputSensitivity;

	[Range(0f, 10f)]
	[Tooltip("Gravity factors into decelleration")]
	public float inputGravity;

	[Tooltip("Max Rotation in degrees per second")]
	[Header("Turning")]
	[Range(0f, 300f)]
	public float maxTurnSpeed;

	[Tooltip("Rotation acceleration in degrees per second squared")]
	[FormerlySerializedAs("turnDelta")]
	[Range(0f, 10f)]
	public float turnAcceleration;

	[Tooltip("Max Pitch in degrees per second")]
	[Range(0f, 180f)]
	[Header("Pitch")]
	public float maxPitchSpeed;

	[Tooltip("Max Pitch in degrees")]
	[Range(0f, 180f)]
	public float maxPitchUpAngle;

	[Tooltip("Max Pitch in degrees")]
	[Range(0f, 180f)]
	public float maxPitchDownAngle;

	[Tooltip("Pitch acceleration in degrees per second squared")]
	[Range(0f, 10f)]
	public float pitchAcceleration;

	[Tooltip("Max Roll in degrees per second")]
	[Range(0f, 180f)]
	[Header("Roll")]
	public float maxRollSpeed;

	[Range(0f, 180f)]
	[Tooltip("Max Roll in degrees")]
	public float maxRollAngle;

	[Range(0f, 10f)]
	[Tooltip("Roll acceleration in degrees per second squared")]
	public float rollAcceleration;

	[Header("Diagnostics")]
	public RuntimeData runtimeData;

	protected override void OnValidate()
	{
	}

	private void Reset()
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

	private void HandlePitch(float deltaTime)
	{
	}

	private void HandleRoll(float deltaTime)
	{
	}

	private void ApplyRotation()
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
