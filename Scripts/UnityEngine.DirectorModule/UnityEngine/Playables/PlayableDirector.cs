using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Playables;

[RequiredByNativeCode]
[NativeHeader("Runtime/Mono/MonoBehaviour.h")]
[NativeHeader("Modules/Director/PlayableDirector.h")]
public class PlayableDirector : Behaviour
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Action<PlayableDirector> played;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Action<PlayableDirector> paused;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Action<PlayableDirector> stopped;

	[RequiredByNativeCode]
	private void SendOnPlayableDirectorPlay()
	{
	}

	[RequiredByNativeCode]
	private void SendOnPlayableDirectorPause()
	{
	}

	[RequiredByNativeCode]
	private void SendOnPlayableDirectorStop()
	{
	}
}
