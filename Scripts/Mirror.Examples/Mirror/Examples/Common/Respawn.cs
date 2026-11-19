using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Mirror.Examples.Common;

public class Respawn
{
	[CompilerGenerated]
	private sealed class _003CDoRespawn_003Ed__1 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public bool respawn;

		public NetworkConnectionToClient conn;

		public byte respawnTime;

		private GameObject _003CplayerObject_003E5__2;

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
		public _003CDoRespawn_003Ed__1(int _003C_003E1__state)
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

	public static void RespawnPlayer(bool respawn, byte respawnTime, NetworkConnectionToClient conn)
	{
	}

	[IteratorStateMachine(typeof(_003CDoRespawn_003Ed__1))]
	public static IEnumerator DoRespawn(bool respawn, byte respawnTime, NetworkConnectionToClient conn)
	{
		return null;
	}
}
