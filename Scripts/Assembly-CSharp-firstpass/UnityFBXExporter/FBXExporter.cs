using UnityEngine;

namespace UnityFBXExporter;

public class FBXExporter
{
	public static string VersionInformation => null;

	public static bool ExportGameObjToFBX(GameObject gameObj, string newPath, bool copyMaterials = false, bool copyTextures = false, bool combineMesh = false)
	{
		return false;
	}

	public static long GetRandomFBXId()
	{
		return 0L;
	}

	public static string MeshToString(GameObject gameObj, string newPath, bool copyMaterials = false, bool copyTextures = false, bool combineMesh = false)
	{
		return null;
	}

	public static void CopyComplexMaterialsToPath(GameObject gameObj, string path, bool copyTextures, string texturesFolder = "/Textures", string materialsFolder = "/Materials")
	{
	}

	public static bool CopyAndRenameAsset(Object obj, string newName, string newFolderPath)
	{
		return false;
	}

	private static string GetFileName(string path)
	{
		return null;
	}

	private static Material CopyTexturesAndAssignCopiesToMaterial(Material material, string newPath)
	{
		return null;
	}

	private static void GetTextureUpdateMaterialWithPath(Material material, string textureShaderName, string newPath)
	{
	}

	public static Object CopyAndRenameAssetReturnObject(Object obj, string newName, string newFolderPath)
	{
		return null;
	}
}
