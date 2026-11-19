using UnityEngine.Bindings;

namespace UnityEngine.SceneManagement;

[StaticAccessor("SceneManagerBindings", StaticAccessorType.DoubleColon)]
[NativeHeader("Runtime/SceneManager/SceneManager.h")]
[NativeHeader("Runtime/Export/SceneManager/SceneManager.bindings.h")]
internal static class SceneManagerAPIInternal
{
	[NativeThrows]
	public static AsyncOperation LoadSceneAsyncNameIndexInternal(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame)
	{
		return null;
	}

	[NativeThrows]
	public static AsyncOperation UnloadSceneNameIndexInternal(string sceneName, int sceneBuildIndex, bool immediately, UnloadSceneOptions options, out bool outSuccess)
	{
		outSuccess = default;
		return null;
	}

	private static AsyncOperation LoadSceneAsyncNameIndexInternal_Injected(string sceneName, int sceneBuildIndex, ref LoadSceneParameters parameters, bool mustCompleteNextFrame)
	{
		return null;
	}
}
