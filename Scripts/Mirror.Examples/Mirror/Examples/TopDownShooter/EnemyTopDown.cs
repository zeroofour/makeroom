using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AI;

namespace Mirror.Examples.TopDownShooter;

public class EnemyTopDown : NetworkBehaviour
{
	[CompilerGenerated]
	private sealed class _003CKillCoroutine_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EnemyTopDown _003C_003E4__this;

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
		public _003CKillCoroutine_003Ed__19(int _003C_003E1__state)
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

	private CanvasTopDown canvasTopDown;

	public float followDistance;

	public float findPlayersTime;

	public float distanceToKillAt;

	private NavMeshAgent agent;

	private Transform closestTarget;

	public Vector3 previousPosition;

	public GameObject enemyArt;

	public GameObject idleSprite;

	public GameObject aggroSprite;

	public AudioSource soundDeath;

	public AudioSource soundAggro;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	[ServerCallback]
	private void Update()
	{
	}

	[ServerCallback]
	private void FindClosestTarget()
	{
	}

	[ServerCallback]
	private void FollowTarget()
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

	[IteratorStateMachine(typeof(_003CKillCoroutine_003Ed__19))]
	private IEnumerator KillCoroutine()
	{
		return null;
	}

	[ClientCallback]
	private void SetSprite()
	{
	}

	public override bool Weaved()
	{
		return false;
	}

	protected void UserCode_RpcKill()
	{
	}

	protected static void InvokeUserCode_RpcKill(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
	}

	static EnemyTopDown()
	{
	}
}
