using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine.XR;

[NativeHeader("Modules/VR/ScriptBindings/XR.bindings.h")]
[NativeHeader("Runtime/GfxDevice/GfxDeviceTypes.h")]
[NativeHeader("Runtime/Interfaces/IVRDevice.h")]
[NativeConditional("ENABLE_VR")]
[NativeHeader("Modules/VR/VRModule.h")]
public static class XRSettings
{
	public enum StereoRenderingMode
	{
		MultiPass = 0,
		SinglePass = 1,
		SinglePassInstanced = 2,
		SinglePassMultiview = 3
	}

	public static bool enabled
	{
		[StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType.ArrowWithDefaultReturnIfNull)]
		get
		{
			return false;
		}
	}

	[NativeName("Active")]
	[StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType.ArrowWithDefaultReturnIfNull)]
	public static bool isDeviceActive => false;

	[StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType.ArrowWithDefaultReturnIfNull)]
	public static int eyeTextureWidth => 0;

	[StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType.ArrowWithDefaultReturnIfNull)]
	public static int eyeTextureHeight => 0;

	[NativeConditional("ENABLE_VR", "RenderTextureDesc()")]
	[StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType.ArrowWithDefaultReturnIfNull)]
	[NativeName("IntermediateEyeTextureDesc")]
	public static RenderTextureDescriptor eyeTextureDesc => default;

	public static float renderViewportScale => 0f;

	[StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType.ArrowWithDefaultReturnIfNull)]
	[NativeName("RenderViewportScale")]
	internal static float renderViewportScaleInternal => 0f;

	[StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType.ArrowWithDefaultReturnIfNull)]
	public static StereoRenderingMode stereoRenderingMode => StereoRenderingMode.MultiPass;

	[SpecialName]
	private static void get_eyeTextureDesc_Injected(out RenderTextureDescriptor ret)
	{
		ret = default;
	}
}
