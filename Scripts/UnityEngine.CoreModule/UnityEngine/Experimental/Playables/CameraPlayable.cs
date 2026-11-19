using System;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.Playables;

[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[RequiredByNativeCode]
[NativeHeader("Runtime/Export/Director/CameraPlayable.bindings.h")]
[NativeHeader("Runtime/Camera//Director/CameraPlayable.h")]
[StaticAccessor("CameraPlayableBindings", StaticAccessorType.DoubleColon)]
public struct CameraPlayable : IEquatable<CameraPlayable>
{
	private PlayableHandle m_Handle;

	public PlayableHandle GetHandle()
	{
		return default;
	}

	public bool Equals(CameraPlayable other)
	{
		return false;
	}
}
