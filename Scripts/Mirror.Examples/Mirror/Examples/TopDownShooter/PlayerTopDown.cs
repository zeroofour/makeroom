using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Mirror.Examples.TopDownShooter;

public class PlayerTopDown : NetworkBehaviour
{
	[CompilerGenerated]
	private sealed class _003CGunShotEffect_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerTopDown _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CGunShotEffect_003Ed__30(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	public static readonly List<PlayerTopDown> playerList;

	private Camera mainCamera;

	private CameraTopDown cameraTopDown;

	private CanvasTopDown canvasTopDown;

	public float moveSpeed;

	public CharacterController characterController;

	public GameObject leftFoot;

	public GameObject rightFoot;

	private Vector3 previousPosition;

	private Quaternion previousRotation;

	[SyncVar(hook = "OnFlashLightChanged")]
	public bool flashLightStatus;

	public Light flashLight;

	[SyncVar(hook = "OnKillsChanged")]
	public int kills;

	[SyncVar(hook = "OnPlayerStatusChanged")]
	public int playerStatus;

	public GameObject[] objectsToHideOnDeath;

	public float shootDistance;

	public LayerMask hitLayers;

	public GameObject muzzleFlash;

	public AudioSource soundGunShot;

	public AudioSource soundDeath;

	public AudioSource soundFlashLight;

	public AudioSource soundLeftFoot;

	public AudioSource soundRightFoot;

	public Action<bool, bool> _Mirror_SyncVarHookDelegate_flashLightStatus;

	public Action<int, int> _Mirror_SyncVarHookDelegate_kills;

	public Action<int, int> _Mirror_SyncVarHookDelegate_playerStatus;

	public bool NetworkflashLightStatus
	{
		get
		{
			return false;
		}
		[param: In]
		set
		{
		}
	}

	public int Networkkills
	{
		get
		{
			return 0;
		}
		[param: In]
		set
		{
		}
	}

	public int NetworkplayerStatus
	{
		get
		{
			return 0;
		}
		[param: In]
		set
		{
		}
	}

	public override void OnStartLocalPlayer()
	{
	}

	private void Awake()
	{
	}

	public void Start()
	{
	}

	public void OnDestroy()
	{
	}

	[ClientCallback]
	private void Update()
	{
	}

	[ClientCallback]
	private void RotatePlayerToMouse()
	{
	}

	[ClientCallback]
	private void Shoot()
	{
	}

	[IteratorStateMachine(typeof(_003CGunShotEffect_003Ed__30))]
	private IEnumerator GunShotEffect()
	{
		return null;
	}

	[Command]
	public void CmdFlashLight()
	{
	}

	private void OnFlashLightChanged(bool _Old, bool _New)
	{
	}

	[Command]
	public void CmdShoot(GameObject target)
	{
	}

	[ClientRpc]
	private void RpcShoot()
	{
	}

	private void OnKillsChanged(int _Old, int _New)
	{
	}

	[ClientCallback]
	private void AnimatePlayer()
	{
	}

	[Command]
	public void CmdRespawnPlayer()
	{
	}

	private void OnPlayerStatusChanged(int _Old, int _New)
	{
	}

	[ServerCallback]
	public void Kill()
	{
	}

	[ClientRpc]
	private void RpcKill()
	{
	}

	static PlayerTopDown()
	{
	}

	public override bool Weaved()
	{
		return false;
	}

	protected void UserCode_CmdFlashLight()
	{
	}

	protected static void InvokeUserCode_CmdFlashLight(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
	}

	protected void UserCode_CmdShoot__GameObject(GameObject target)
	{
	}

	protected static void InvokeUserCode_CmdShoot__GameObject(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
	}

	protected void UserCode_RpcShoot()
	{
	}

	protected static void InvokeUserCode_RpcShoot(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
	}

	protected void UserCode_CmdRespawnPlayer()
	{
	}

	protected static void InvokeUserCode_CmdRespawnPlayer(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
	}

	protected void UserCode_RpcKill()
	{
	}

	protected static void InvokeUserCode_RpcKill(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
	}

	public override void SerializeSyncVars(NetworkWriter writer, bool forceAll)
	{
	}

	public override void DeserializeSyncVars(NetworkReader reader, bool initialState)
	{
	}
}
