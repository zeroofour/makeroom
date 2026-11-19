using UnityEngine.Bindings;

namespace UnityEngine.Rendering;

[NativeHeader("Runtime/Camera/GraphicsSettings.h")]
[StaticAccessor("GetGraphicsSettings()", StaticAccessorType.Dot)]
public sealed class GraphicsSettings : Object
{
	public static bool lightsUseLinearIntensity => false;

	[NativeName("CurrentRenderPipeline")]
	private static ScriptableObject INTERNAL_currentRenderPipeline => null;

	public static RenderPipelineAsset currentRenderPipeline => null;

	[NativeName("GetShaderModeScript")]
	public static BuiltinShaderMode GetShaderMode(BuiltinShaderType type)
	{
		return BuiltinShaderMode.Disabled;
	}
}
