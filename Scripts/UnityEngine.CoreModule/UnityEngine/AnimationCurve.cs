using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[StructLayout((LayoutKind)0)]
[RequiredByNativeCode]
[NativeHeader("Runtime/Math/AnimationCurve.bindings.h")]
public class AnimationCurve : IEquatable<AnimationCurve>
{
	internal IntPtr m_Ptr;

	public Keyframe[] keys
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Keyframe this[int index] => default;

	public int length
	{
		[NativeMethod("GetKeyCount", IsThreadSafe = true)]
		get
		{
			return 0;
		}
	}

	[FreeFunction("AnimationCurveBindings::Internal_Destroy", IsThreadSafe = true)]
	private static void Internal_Destroy(IntPtr ptr)
	{
	}

	[FreeFunction("AnimationCurveBindings::Internal_Create", IsThreadSafe = true)]
	private static IntPtr Internal_Create(Keyframe[] keys)
	{
		return (IntPtr)0;
	}

	[FreeFunction("AnimationCurveBindings::Internal_Equals", HasExplicitThis = true, IsThreadSafe = true)]
	private bool Internal_Equals(IntPtr other)
	{
		return false;
	}

	~AnimationCurve()
	{
	}

	[ThreadSafe]
	public float Evaluate(float time)
	{
		return 0f;
	}

	public int AddKey(Keyframe key)
	{
		return 0;
	}

	[NativeMethod("AddKey", IsThreadSafe = true)]
	private int AddKey_Internal(Keyframe key)
	{
		return 0;
	}

	[FreeFunction("AnimationCurveBindings::SetKeys", HasExplicitThis = true, IsThreadSafe = true)]
	private void SetKeys(Keyframe[] keys)
	{
	}

	[NativeThrows]
	[FreeFunction("AnimationCurveBindings::GetKey", HasExplicitThis = true, IsThreadSafe = true)]
	private Keyframe GetKey(int index)
	{
		return default;
	}

	[FreeFunction("AnimationCurveBindings::GetKeys", HasExplicitThis = true, IsThreadSafe = true)]
	private Keyframe[] GetKeys()
	{
		return null;
	}

	public static AnimationCurve EaseInOut(float timeStart, float valueStart, float timeEnd, float valueEnd)
	{
		return null;
	}

	public AnimationCurve(params Keyframe[] keys)
	{
	}

	[RequiredByNativeCode]
	public AnimationCurve()
	{
	}

	public override bool Equals(object o)
	{
		return false;
	}

	public bool Equals(AnimationCurve other)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	private int AddKey_Internal_Injected(ref Keyframe key)
	{
		return 0;
	}

	private void GetKey_Injected(int index, out Keyframe ret)
	{
		ret = default;
	}
}
