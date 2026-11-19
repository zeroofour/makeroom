using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[NativeHeader("Runtime/Utilities/Argv.h")]
[NativeHeader("Runtime/Export/Application/Application.bindings.h")]
[NativeHeader("Runtime/Misc/BuildSettings.h")]
[NativeHeader("Runtime/File/ApplicationSpecificPersistentDataPath.h")]
[NativeHeader("Runtime/Utilities/URLUtility.h")]
[NativeHeader("Runtime/Application/AdsIdHandler.h")]
[NativeHeader("Runtime/Input/InputManager.h")]
[NativeHeader("Runtime/Misc/Player.h")]
[NativeHeader("Runtime/Logging/LogSystem.h")]
[NativeHeader("Runtime/Network/NetworkUtility.h")]
[NativeHeader("Runtime/Input/GetInput.h")]
[NativeHeader("Runtime/BaseClasses/IsPlaying.h")]
[NativeHeader("Runtime/PreloadManager/LoadSceneOperation.h")]
[NativeHeader("Runtime/Input/TargetFrameRate.h")]
[NativeHeader("Runtime/PreloadManager/PreloadManager.h")]
[NativeHeader("Runtime/Misc/PlayerSettings.h")]
[NativeHeader("Runtime/Application/ApplicationInfo.h")]
[NativeHeader("Runtime/Misc/SystemInfo.h")]
public class Application
{
	public delegate void LowMemoryCallback();

	public delegate void LogCallback(string condition, string stackTrace, LogType type);

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static LowMemoryCallback lowMemory;

	private static LogCallback s_LogCallbackHandler;

	private static LogCallback s_LogCallbackHandlerThreaded;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static Action<bool> m_focusChanged;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static Action<string> deepLinkActivated;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static Func<bool> wantsToQuit;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private static Action m_quitting;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private static Action unloading;

	public static bool isPlaying
	{
		[FreeFunction("IsWorldPlaying")]
		get
		{
			return false;
		}
	}

	public static bool isFocused
	{
		[FreeFunction("IsPlayerFocused")]
		get
		{
			return false;
		}
	}

	public static bool runInBackground
	{
		[FreeFunction("GetPlayerSettingsRunInBackground")]
		get
		{
			return false;
		}
		[FreeFunction("SetPlayerSettingsRunInBackground")]
		set
		{
		}
	}

	public static bool isBatchMode
	{
		[FreeFunction("::IsBatchmode")]
		get
		{
			return false;
		}
	}

	public static string dataPath
	{
		[FreeFunction("GetAppDataPath")]
		get
		{
			return null;
		}
	}

	public static string persistentDataPath
	{
		[FreeFunction("GetPersistentDataPathApplicationSpecific")]
		get
		{
			return null;
		}
	}

	public static string version
	{
		[FreeFunction("GetApplicationInfo().GetVersion")]
		get
		{
			return null;
		}
	}

	public static int targetFrameRate
	{
		[FreeFunction("SetTargetFrameRate")]
		set
		{
		}
	}

	public static RuntimePlatform platform
	{
		[FreeFunction("systeminfo::GetRuntimePlatform", IsThreadSafe = true)]
		get
		{
			return RuntimePlatform.OSXEditor;
		}
	}

	public static bool isMobilePlatform => false;

	public static SystemLanguage systemLanguage
	{
		[FreeFunction("(SystemLanguage)systeminfo::GetSystemLanguage")]
		get
		{
			return SystemLanguage.Afrikaans;
		}
	}

	public static bool isEditor => false;

	public static event LogCallback logMessageReceived
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event LogCallback logMessageReceivedThreaded
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<bool> focusChanged
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

	public static event Action quitting
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

	[FreeFunction("GetInputManager().QuitApplication")]
	public static void Quit(int exitCode)
	{
	}

	public static void Quit()
	{
	}

	[FreeFunction]
	public static bool IsPlaying([NotNull("NullExceptionObject")] Object obj)
	{
		return false;
	}

	[FreeFunction("OpenURL")]
	public static void OpenURL(string url)
	{
	}

	[FreeFunction("Application_Bindings::SetLogCallbackDefined")]
	private static void SetLogCallbackDefined(bool defined)
	{
	}

	[RequiredByNativeCode]
	internal static void CallLowMemory()
	{
	}

	[RequiredByNativeCode]
	private static void CallLogCallback(string logString, string stackTrace, LogType type, bool invokedOnMainThread)
	{
	}

	[RequiredByNativeCode]
	private static bool Internal_ApplicationWantsToQuit()
	{
		return false;
	}

	[RequiredByNativeCode]
	private static void Internal_ApplicationQuit()
	{
	}

	[RequiredByNativeCode]
	private static void Internal_ApplicationUnload()
	{
	}

	[RequiredByNativeCode]
	internal static void InvokeOnBeforeRender()
	{
	}

	[RequiredByNativeCode]
	internal static void InvokeFocusChanged(bool focus)
	{
	}

	[RequiredByNativeCode]
	internal static void InvokeDeepLinkActivated(string url)
	{
	}
}
