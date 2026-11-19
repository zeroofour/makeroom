using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.VFX;

[RequiredByNativeCode]
[NativeHeader("Modules/VFX/Public/VFXManager.h")]
[StaticAccessor("GetVFXManager()", StaticAccessorType.Dot)]
public static class VFXManager
{
	private static readonly VFXCameraXRSettings kDefaultCameraXRSettings;
}
