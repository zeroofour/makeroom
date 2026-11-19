using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Mirror.Examples.AdditiveLevels;

[AddComponentMenu(null)]
public class AdditiveLevelsNetworkManager : NetworkManager
{
	[CompilerGenerated]
	private sealed class _003CServerLoadSubScenes_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AdditiveLevelsNetworkManager _003C_003E4__this;

		private string[] _003C_003E7__wrap1;

		private int _003C_003E7__wrap2;

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
		public _003CServerLoadSubScenes_003Ed__7(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CLoadAdditive_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AdditiveLevelsNetworkManager _003C_003E4__this;

		public string sceneName;

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
		public _003CLoadAdditive_003Ed__9(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CUnloadAdditive_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AdditiveLevelsNetworkManager _003C_003E4__this;

		public string sceneName;

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
		public _003CUnloadAdditive_003Ed__10(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CAddPlayerDelayed_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AdditiveLevelsNetworkManager _003C_003E4__this;

		public NetworkConnectionToClient conn;

		private GameObject _003Cplayer_003E5__2;

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
		public _003CAddPlayerDelayed_003Ed__13(int _003C_003E1__state)
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

	[Header("Additive Scenes - First is start scene")]
	[Scene]
	[Tooltip("Add additive scenes here.\nFirst entry will be players' start scene")]
	public string[] additiveScenes;

	[Header("Fade Control - See child FadeCanvas")]
	[Tooltip("Reference to FadeInOut script on child FadeCanvas")]
	public FadeInOut fadeInOut;

	private bool subscenesLoaded;

	private bool isInTransition;

	public new static AdditiveLevelsNetworkManager singleton => null;

	public override void OnServerSceneChanged(string sceneName)
	{
	}

	[IteratorStateMachine(typeof(_003CServerLoadSubScenes_003Ed__7))]
	private IEnumerator ServerLoadSubScenes()
	{
		return null;
	}

	public override void OnClientChangeScene(string sceneName, SceneOperation sceneOperation, bool customHandling)
	{
	}

	[IteratorStateMachine(typeof(_003CLoadAdditive_003Ed__9))]
	private IEnumerator LoadAdditive(string sceneName)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CUnloadAdditive_003Ed__10))]
	private IEnumerator UnloadAdditive(string sceneName)
	{
		return null;
	}

	public override void OnClientSceneChanged()
	{
	}

	public override void OnServerReady(NetworkConnectionToClient conn)
	{
	}

	[IteratorStateMachine(typeof(_003CAddPlayerDelayed_003Ed__13))]
	private IEnumerator AddPlayerDelayed(NetworkConnectionToClient conn)
	{
		return null;
	}
}
