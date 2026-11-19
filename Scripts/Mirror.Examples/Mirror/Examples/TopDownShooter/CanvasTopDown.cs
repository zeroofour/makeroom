using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Mirror.Examples.TopDownShooter;

public class CanvasTopDown : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CBGSound_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CanvasTopDown _003C_003E4__this;

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
		public _003CBGSound_003Ed__17(int _003C_003E1__state)
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

	public NetworkTopDown networkTopDown;

	public PlayerTopDown playerTopDown;

	public Button buttonSpawnEnemy;

	public Button buttonRespawnPlayer;

	public Text textEnemies;

	public Text textKills;

	public GameObject shotMarker;

	public GameObject deathSplatter;

	public AudioSource soundGameIntro;

	public AudioSource soundGameLoop;

	public AudioSource soundButtonUI;

	private void Start()
	{
	}

	private void ButtonSpawnEnemy()
	{
	}

	private void ButtonRespawnPlayer()
	{
	}

	public void UpdateEnemyUI(int value)
	{
	}

	public void UpdateKillsUI(int value)
	{
	}

	public void ResetUI()
	{
	}

	[IteratorStateMachine(typeof(_003CBGSound_003Ed__17))]
	private IEnumerator BGSound()
	{
		return null;
	}

	public void PlaySoundButtonUI()
	{
	}
}
