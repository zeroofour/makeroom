using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[StructLayout((LayoutKind)0)]
[NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadAssetOperation.h")]
[RequiredByNativeCode]
public class AssetBundleRequest : ResourceRequest
{
}
