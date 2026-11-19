using System.Runtime.CompilerServices;
using UnityEngine;

namespace Mirror;

public static class Utils
{
	public const bool IsWebGL = false;

	public const bool IsDebug = false;

	public static bool IsHeadless()
	{
		return false;
	}

	public static uint GetTrueRandomUInt()
	{
		return 0u;
	}

	public static bool IsPrefab(GameObject obj)
	{
		return false;
	}

	public static bool IsSceneObject(NetworkIdentity identity)
	{
		return false;
	}

	public static bool IsSceneObjectWithPrefabParent(GameObject gameObject, out GameObject prefab)
	{
		prefab = null;
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool IsPointInScreen(Vector2 point)
	{
		return false;
	}

	public static string PrettyBytes(long bytes)
	{
		return null;
	}

	public static string PrettySeconds(double seconds)
	{
		return null;
	}

	public static NetworkIdentity GetSpawnedInServerOrClient(uint netId)
	{
		return null;
	}

	public static Rect KeepInScreen(Rect rect)
	{
		return default;
	}

	public static void CreateLocalConnections(out LocalConnectionToClient connectionToClient, out LocalConnectionToServer connectionToServer)
	{
		connectionToClient = null;
		connectionToServer = null;
	}

	public static bool IsSceneActive(string scene)
	{
		return false;
	}
}
