using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[NativeHeader("TerrainScriptingClasses.h")]
[NativeHeader("Modules/Terrain/Public/Terrain.h")]
[UsedByNativeCode]
[StaticAccessor("GetITerrainManager()", StaticAccessorType.Arrow)]
[NativeHeader("Runtime/Interfaces/ITerrainManager.h")]
public sealed class Terrain : Behaviour
{
	public TerrainData terrainData
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool drawHeightmap
	{
		set
		{
		}
	}

	public bool allowAutoConnect => false;

	public int groupingID => 0;

	public bool drawTreesAndFoliage
	{
		set
		{
		}
	}

	[NativeProperty("ActiveTerrainsScriptingArray")]
	public static Terrain[] activeTerrains => null;

	public void SetNeighbors(Terrain left, Terrain top, Terrain right, Terrain bottom)
	{
	}
}
