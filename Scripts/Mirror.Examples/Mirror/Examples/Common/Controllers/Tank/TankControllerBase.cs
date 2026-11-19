using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace Mirror.Examples.Common.Controllers.Tank;

[RequireComponent(typeof(TankHealth))]
[DisallowMultipleComponent]
[RequireComponent(typeof(CharacterController))]
[RequireComponent(typeof(Rigidbody))]
[AddComponentMenu(null)]
[RequireComponent(typeof(NetworkIdentity))]
public class TankControllerBase : NetworkBehaviour
{
	public enum GroundState : byte
	{
		Grounded = 0,
		Falling = 1
	}

	[Serializable]
	public struct MoveKeys
	{
		public KeyCode Forward;

		public KeyCode Back;

		public KeyCode TurnLeft;

		public KeyCode TurnRight;
	}

	[Serializable]
	public struct OptionsKeys
	{
		public KeyCode AutoRun;

		public KeyCode ToggleUI;
	}

	[Flags]
	public enum ControlOptions : byte
	{
		None = 0,
		AutoRun = 1,
		ShowUI = 2
	}

	[Serializable]
	public struct RuntimeData
	{
		[SerializeField]
		[ReadOnly]
		[Range(-1f, 1f)]
		private float _vertical;

		[SerializeField]
		[ReadOnly]
		[Range(-300f, 300f)]
		private float _turnSpeed;

		[ReadOnly]
		[SerializeField]
		[Range(-1.5f, 1.5f)]
		private float _animVelocity;

		[SerializeField]
		[ReadOnly]
		[Range(-1.5f, 1.5f)]
		private float _animRotation;

		[SerializeField]
		[ReadOnly]
		private GroundState _groundState;

		[SerializeField]
		[ReadOnly]
		private Vector3 _direction;

		[ReadOnly]
		[SerializeField]
		private Vector3Int _velocity;

		[ReadOnly]
		[SerializeField]
		private GameObject _controllerUI;

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
	}

	[Header("Components")]
	public BoxCollider boxCollider;

	public CharacterController characterController;

	[Header("User Interface")]
	public GameObject ControllerUIPrefab;

	[Header("Configuration")]
	[SerializeField]
	public MoveKeys moveKeys;

	[SerializeField]
	public OptionsKeys optionsKeys;

	[Space(5f)]
	public ControlOptions controlOptions;

	[FormerlySerializedAs("moveSpeedMultiplier")]
	[Header("Movement")]
	[Tooltip("Speed in meters per second")]
	[Range(0f, 20f)]
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

	[Header("Diagnostics")]
	public RuntimeData runtimeData;

	protected override void OnValidate()
	{
	}

	protected virtual void Reset()
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

	private void HandleOptions()
	{
	}

	private void HandleTurning(float deltaTime)
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
