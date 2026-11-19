using UnityEngine.Scripting;

namespace UnityEngine;

[UsedByNativeCode]
public struct GradientColorKey(Color col, float time)
{
	public Color color = default;

	public float time = 0f;
}
