using Unity.Collections;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering;

[UsedByNativeCode]
[NativeHeader("Runtime/Camera/BatchRendererGroup.h")]
public struct BatchCullingContext
{
	public readonly NativeArray<Plane> cullingPlanes = default;

	public NativeArray<BatchVisibility> batchVisibility = default;

	public NativeArray<int> visibleIndices = default;

	public NativeArray<int> visibleIndicesY = default;

	public readonly LODParameters lodParameters = default;

	public readonly Matrix4x4 cullingMatrix = default;

	public readonly float nearPlane = 0f;

	internal BatchCullingContext(NativeArray<Plane> inCullingPlanes, NativeArray<BatchVisibility> inOutBatchVisibility, NativeArray<int> outVisibleIndices, NativeArray<int> outVisibleIndicesY, LODParameters inLodParameters, Matrix4x4 inCullingMatrix, float inNearPlane)
	{
	}
}
