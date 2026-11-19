using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Mirror.Examples.Common.Controllers.Tank;

[DisallowMultipleComponent]
[RequireComponent(typeof(NetworkIdentity))]
[AddComponentMenu(null)]
public class TankTurretBase : NetworkBehaviour
{
	[Serializable]
	public struct OptionsKeys
	{
		public KeyCode MouseLock;

		public KeyCode AutoLevel;

		public KeyCode ToggleUI;
	}

	[Serializable]
	public struct MoveKeys
	{
		public KeyCode PitchUp;

		public KeyCode PitchDown;

		public KeyCode TurnLeft;

		public KeyCode TurnRight;
	}

	[Serializable]
	public struct OtherKeys
	{
		public KeyCode Shoot;
	}

	[Flags]
	public enum ControlOptions : byte
	{
		None = 0,
		MouseLock = 1,
		AutoLevel = 2,
		ShowUI = 4
	}

	[Serializable]
	public struct RuntimeData
	{
		[SerializeField]
		[Range(-300f, 300f)]
		[ReadOnly]
		private float _turretSpeed;

		[Range(-180f, 180f)]
		[SerializeField]
		[ReadOnly]
		private float _pitchAngle;

		[ReadOnly]
		[SerializeField]
		[Range(-180f, 180f)]
		private float _pitchSpeed;

		[ReadOnly]
		[SerializeField]
		[Range(-1f, 1f)]
		private float _mouseInputX;

		[Range(0f, 30f)]
		[SerializeField]
		[ReadOnly]
		private float _mouseSensitivity;

		[SerializeField]
		[ReadOnly]
		private double _lastShotTime;

		[ReadOnly]
		[SerializeField]
		private GameObject _turretUI;

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

		public float turretSpeed
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

		public double lastShotTime
		{
			get
			{
				return 0.0;
			}
			internal set
			{
			}
		}

		public GameObject turretUI
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

	private Material cachedMaterial;

	[Header("Prefabs")]
	public GameObject turretUIPrefab;

	public GameObject projectilePrefab;

	[Header("Components")]
	public Animator animator;

	public Transform turret;

	public Transform barrel;

	public Transform projectileMount;

	public CapsuleCollider barrelCollider;

	[Header("Seated Player")]
	public GameObject playerObject;

	[SyncVar(hook = "OnPlayerColorChanged")]
	public Color32 playerColor;

	[Header("Configuration")]
	[SerializeField]
	public MoveKeys moveKeys;

	[SerializeField]
	public OtherKeys otherKeys;

	[SerializeField]
	public OptionsKeys optionsKeys;

	[Space(5f)]
	public ControlOptions controlOptions;

	[Range(0f, 10f)]
	[Tooltip("Cooldown time in seconds")]
	[Header("Shooting")]
	public byte cooldownTime;

	[Tooltip("Max Rotation in degrees per second")]
	[Range(0f, 300f)]
	[Header("Turret")]
	public float maxTurretSpeed;

	[Tooltip("Rotation acceleration in degrees per second squared")]
	[Range(0f, 30f)]
	public float turretAcceleration;

	[Header("Barrel")]
	[Tooltip("Max Pitch in degrees per second")]
	[Range(0f, 180f)]
	public float maxPitchSpeed;

	[Tooltip("Max Pitch in degrees")]
	[Range(0f, 40f)]
	public float maxPitchUpAngle;

	[Range(0f, 20f)]
	[Tooltip("Max Pitch in degrees")]
	public float maxPitchDownAngle;

	[Range(0f, 10f)]
	[Tooltip("Pitch acceleration in degrees per second squared")]
	public float pitchAcceleration;

	[Header("Diagnostics")]
	public RuntimeData runtimeData;

	public Action<Color32, Color32> _Mirror_SyncVarHookDelegate_playerColor;

	private bool CanShoot => false;

	public Color32 NetworkplayerColor
	{
		get
		{
			return default;
		}
		[param: In]
		set
		{
		}
	}

	protected override void OnValidate()
	{
	}

	protected virtual void Reset()
	{
	}

	public override void OnStartLocalPlayer()
	{
	}

	public override void OnStopLocalPlayer()
	{
	}

	public override void OnStartAuthority()
	{
	}

	public override void OnStopAuthority()
	{
	}

	private void Update()
	{
	}

	private void OnPlayerColorChanged(Color32 _, Color32 newColor)
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

	private void HandleMouseTurret(float deltaTime)
	{
	}

	private void HandlePitch(float deltaTime)
	{
	}

	private void HandleShooting()
	{
	}

	[Command]
	private void CmdShoot()
	{
	}

	[ClientRpc(includeOwner = false)]
	private void RpcShoot()
	{
	}

	private void DoShoot()
	{
	}

	public override bool Weaved()
	{
		return false;
	}

	protected void UserCode_CmdShoot()
	{
	}

	protected static void InvokeUserCode_CmdShoot(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
	}

	protected void UserCode_RpcShoot()
	{
	}

	protected static void InvokeUserCode_RpcShoot(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
	}

	static TankTurretBase()
	{
	}

	public override void SerializeSyncVars(NetworkWriter writer, bool forceAll)
	{
	}

	public override void DeserializeSyncVars(NetworkReader reader, bool initialState)
	{
	}
}
