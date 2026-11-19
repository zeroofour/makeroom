using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[RequireComponent(typeof(Transform))]
[NativeHeader("Modules/Physics2D/Public/Collider2D.h")]
[RequiredByNativeCode(Optional = true)]
public class Collider2D : Behaviour
{
	public Bounds bounds => default;

	[SpecialName]
	private void get_bounds_Injected(out Bounds ret)
	{
		ret = default;
	}
}
