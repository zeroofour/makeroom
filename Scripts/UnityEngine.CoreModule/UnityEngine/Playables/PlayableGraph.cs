using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Playables;

[NativeHeader("Runtime/Export/Director/PlayableGraph.bindings.h")]
[UsedByNativeCode]
[NativeHeader("Runtime/Director/Core/HPlayableGraph.h")]
[NativeHeader("Runtime/Director/Core/HPlayableOutput.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
public struct PlayableGraph
{
	internal IntPtr m_Handle;

	internal uint m_Version;
}
