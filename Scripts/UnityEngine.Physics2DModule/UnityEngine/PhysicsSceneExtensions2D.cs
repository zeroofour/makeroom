using UnityEngine.Bindings;
using UnityEngine.SceneManagement;

namespace UnityEngine;

public static class PhysicsSceneExtensions2D
{
	public static PhysicsScene2D GetPhysicsScene2D(this Scene scene)
	{
		return default;
	}

	[StaticAccessor("GetPhysicsManager2D()", StaticAccessorType.Arrow)]
	[NativeMethod("GetPhysicsSceneFromUnityScene")]
	private static PhysicsScene2D GetPhysicsScene_Internal(Scene scene)
	{
		return default;
	}

	private static void GetPhysicsScene_Internal_Injected(ref Scene scene, out PhysicsScene2D ret)
	{
		ret = default;
	}
}
