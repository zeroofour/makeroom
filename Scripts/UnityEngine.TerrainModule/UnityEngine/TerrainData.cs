using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[NativeHeader("TerrainScriptingClasses.h")]
[UsedByNativeCode]
[NativeHeader("Modules/Terrain/Public/TerrainDataScriptingInterface.h")]
public sealed class TerrainData : Object
{
	private enum BoundaryValueType
	{
		MaxHeightmapRes = 0,
		MinDetailResPerPatch = 1,
		MaxDetailResPerPatch = 2,
		MaxDetailPatchCount = 3,
		MaxDetailsPerRes = 4,
		MinAlphamapRes = 5,
		MaxAlphamapRes = 6,
		MinBaseMapRes = 7,
		MaxBaseMapRes = 8
	}

	internal static readonly int k_MaximumResolution;

	internal static readonly int k_MinimumDetailResolutionPerPatch;

	internal static readonly int k_MaximumDetailResolutionPerPatch;

	internal static readonly int k_MaximumDetailPatchCount;

	internal static readonly int k_MaximumDetailsPerRes;

	internal static readonly int k_MinimumAlphamapResolution;

	internal static readonly int k_MaximumAlphamapResolution;

	internal static readonly int k_MinimumBaseMapResolution;

	internal static readonly int k_MaximumBaseMapResolution;

	public int heightmapResolution => 0;

	private int internalHeightmapResolution
	{
		[NativeName("GetHeightmap().GetResolution")]
		get
		{
			return 0;
		}
	}

	public Vector3 size
	{
		[NativeName("GetHeightmap().GetSize")]
		get
		{
			return default;
		}
	}

	internal Terrain[] users => null;

	[ThreadSafe]
	[StaticAccessor("TerrainDataScriptingInterface", StaticAccessorType.DoubleColon)]
	private static int GetBoundaryValue(BoundaryValueType type)
	{
		return 0;
	}

	[FreeFunction("TerrainDataScriptingInterface::Create")]
	private static void Internal_Create([Writable] TerrainData terrainData)
	{
	}

	public void SetHeights(int xBase, int yBase, float[,] heights)
	{
	}

	[FreeFunction("TerrainDataScriptingInterface::SetHeights", HasExplicitThis = true)]
	private void Internal_SetHeights(int xBase, int yBase, int width, int height, float[,] heights)
	{
	}

	[NativeName("GetSplatDatabase().GetAlphamapResolution")]
	[RequiredByNativeCode]
	internal float GetAlphamapResolutionInternal()
	{
		return 0f;
	}

	[SpecialName]
	private void get_size_Injected(out Vector3 ret)
	{
		ret = default;
	}
}
