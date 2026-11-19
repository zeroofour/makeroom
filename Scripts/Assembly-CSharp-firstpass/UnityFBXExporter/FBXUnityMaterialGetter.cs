using UnityEngine;

namespace UnityFBXExporter;

public class FBXUnityMaterialGetter
{
	public static void GetAllMaterialsToString(GameObject gameObj, string newPath, bool copyMaterials, bool copyTextures, out Material[] materials, out string matObjects, out string connections)
	{
		materials = null;
		matObjects = null;
		connections = null;
	}

	private static void SerializedTextures(GameObject gameObj, string newPath, Material material, string materialName, bool copyTextures, out string objects, out string connections)
	{
		objects = null;
		connections = null;
	}

	private static bool SerializeOneTexture(GameObject gameObj, string newPath, Material material, string materialName, int materialId, bool copyTextures, string unityExtension, string textureType, out string objects, out string connections)
	{
		objects = null;
		connections = null;
		return false;
	}
}
