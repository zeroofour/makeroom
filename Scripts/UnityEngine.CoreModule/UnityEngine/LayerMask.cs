using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[NativeClass("BitField", "struct BitField;")]
[NativeHeader("Runtime/BaseClasses/BitField.h")]
[RequiredByNativeCode(Optional = true, GenerateProxy = true)]
[NativeHeader("Runtime/BaseClasses/TagManager.h")]
public struct LayerMask
{
	[NativeName("m_Bits")]
	private int m_Mask;

	public int value
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static implicit operator int(LayerMask mask)
	{
		return 0;
	}

	public static implicit operator LayerMask(int intVal)
	{
		return default;
	}

	[StaticAccessor("GetTagManager()", StaticAccessorType.Dot)]
	[NativeMethod("StringToLayer")]
	public static int NameToLayer(string layerName)
	{
		return 0;
	}

	public static int GetMask(params string[] layerNames)
	{
		return 0;
	}
}
