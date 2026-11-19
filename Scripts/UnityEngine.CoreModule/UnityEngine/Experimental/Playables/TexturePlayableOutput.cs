using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.Playables;

[NativeHeader("Runtime/Graphics/Director/TexturePlayableOutput.h")]
[NativeHeader("Runtime/Graphics/RenderTexture.h")]
[StaticAccessor("TexturePlayableOutputBindings", StaticAccessorType.DoubleColon)]
[RequiredByNativeCode]
[NativeHeader("Runtime/Export/Director/TexturePlayableOutput.bindings.h")]
public struct TexturePlayableOutput
{
	private PlayableOutputHandle m_Handle;
}
