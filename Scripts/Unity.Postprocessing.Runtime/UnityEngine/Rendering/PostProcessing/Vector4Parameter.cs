using System;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class Vector4Parameter : ParameterOverride<Vector4>
{
	public override void Interp(Vector4 from, Vector4 to, float t)
	{
	}

	public static implicit operator Vector2(Vector4Parameter prop)
	{
		return default;
	}

	public static implicit operator Vector3(Vector4Parameter prop)
	{
		return default;
	}
}
