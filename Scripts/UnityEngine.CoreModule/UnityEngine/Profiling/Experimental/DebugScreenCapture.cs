using Unity.Collections;

namespace UnityEngine.Profiling.Experimental;

public struct DebugScreenCapture
{
	public NativeArray<byte> rawImageDataReference { set; }

	public TextureFormat imageFormat { set; }

	public int width { set; }

	public int height { set; }
}
