using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Networking;

[StructLayout((LayoutKind)0)]
[NativeHeader("UnityWebRequestScriptingClasses.h")]
[NativeHeader("Modules/UnityWebRequest/Public/UnityWebRequestAsyncOperation.h")]
[UsedByNativeCode]
public class UnityWebRequestAsyncOperation : AsyncOperation
{
	internal UnityWebRequest webRequest { set; }
}
