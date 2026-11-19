using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Events;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine.SceneManagement;

[RequiredByNativeCode]
[NativeHeader("Runtime/Export/SceneManager/SceneManager.bindings.h")]
public class SceneManager
{
	internal static bool s_AllowLoadScene;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private static UnityAction<Scene, LoadSceneMode> m_sceneLoaded;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private static UnityAction<Scene> sceneUnloaded;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static UnityAction<Scene, Scene> activeSceneChanged;

	public static int sceneCount
	{
		[NativeHeader("Runtime/SceneManager/SceneManager.h")]
		[StaticAccessor("GetSceneManager()", StaticAccessorType.Dot)]
		[NativeMethod("GetSceneCount")]
		get
		{
			return 0;
		}
	}

	public static event UnityAction<Scene, LoadSceneMode> sceneLoaded
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	[StaticAccessor("SceneManagerBindings", StaticAccessorType.DoubleColon)]
	public static Scene GetActiveScene()
	{
		return default;
	}

	[StaticAccessor("SceneManagerBindings", StaticAccessorType.DoubleColon)]
	public static Scene GetSceneByPath(string scenePath)
	{
		return default;
	}

	[StaticAccessor("SceneManagerBindings", StaticAccessorType.DoubleColon)]
	public static Scene GetSceneByName(string name)
	{
		return default;
	}

	[StaticAccessor("SceneManagerBindings", StaticAccessorType.DoubleColon)]
	[NativeThrows]
	public static Scene GetSceneAt(int index)
	{
		return default;
	}

	[StaticAccessor("SceneManagerBindings", StaticAccessorType.DoubleColon)]
	[NativeThrows]
	private static AsyncOperation UnloadSceneAsyncInternal(Scene scene, UnloadSceneOptions options)
	{
		return null;
	}

	private static AsyncOperation LoadSceneAsyncNameIndexInternal(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame)
	{
		return null;
	}

	private static AsyncOperation UnloadSceneNameIndexInternal(string sceneName, int sceneBuildIndex, bool immediately, UnloadSceneOptions options, out bool outSuccess)
	{
		outSuccess = default;
		return null;
	}

	[StaticAccessor("SceneManagerBindings", StaticAccessorType.DoubleColon)]
	[NativeThrows]
	public static void MoveGameObjectToScene([NotNull("ArgumentNullException")] GameObject go, Scene scene)
	{
	}

	[RequiredByNativeCode]
	internal static AsyncOperation LoadFirstScene_Internal(bool async)
	{
		return null;
	}

	[ExcludeFromDocs]
	public static void LoadScene(string sceneName)
	{
	}

	public static Scene LoadScene(string sceneName, LoadSceneParameters parameters)
	{
		return default;
	}

	public static AsyncOperation LoadSceneAsync(string sceneName, [DefaultValue("LoadSceneMode.Single")] LoadSceneMode mode)
	{
		return null;
	}

	[ExcludeFromDocs]
	public static AsyncOperation LoadSceneAsync(string sceneName)
	{
		return null;
	}

	public static AsyncOperation LoadSceneAsync(string sceneName, LoadSceneParameters parameters)
	{
		return null;
	}

	public static AsyncOperation UnloadSceneAsync(string sceneName)
	{
		return null;
	}

	public static AsyncOperation UnloadSceneAsync(Scene scene)
	{
		return null;
	}

	public static AsyncOperation UnloadSceneAsync(string sceneName, UnloadSceneOptions options)
	{
		return null;
	}

	[RequiredByNativeCode]
	private static void Internal_SceneLoaded(Scene scene, LoadSceneMode mode)
	{
	}

	[RequiredByNativeCode]
	private static void Internal_SceneUnloaded(Scene scene)
	{
	}

	[RequiredByNativeCode]
	private static void Internal_ActiveSceneChanged(Scene previousActiveScene, Scene newActiveScene)
	{
	}

	private static void GetActiveScene_Injected(out Scene ret)
	{
		ret = default;
	}

	private static void GetSceneByPath_Injected(string scenePath, out Scene ret)
	{
		ret = default;
	}

	private static void GetSceneByName_Injected(string name, out Scene ret)
	{
		ret = default;
	}

	private static void GetSceneAt_Injected(int index, out Scene ret)
	{
		ret = default;
	}

	private static AsyncOperation UnloadSceneAsyncInternal_Injected(ref Scene scene, UnloadSceneOptions options)
	{
		return null;
	}

	private static void MoveGameObjectToScene_Injected(GameObject go, ref Scene scene)
	{
	}
}
