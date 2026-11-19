using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Windows.WebCam;

[MovedFrom("UnityEngine.XR.WSA.WebCam")]
[NativeHeader("PlatformDependent/Win/Webcam/PhotoCaptureFrame.h")]
[NativeConditional("(PLATFORM_WIN || PLATFORM_WINRT) && !PLATFORM_XBOXONE")]
public sealed class PhotoCaptureFrame : IDisposable
{
	private IntPtr m_NativePtr;

	public int dataLength { get; private set; }

	private bool hasLocationData { set; }

	private CapturePixelFormat pixelFormat { set; }

	[ThreadAndSerializationSafe]
	private int GetDataLength()
	{
		return 0;
	}

	[ThreadAndSerializationSafe]
	private bool GetHasLocationData()
	{
		return false;
	}

	[ThreadAndSerializationSafe]
	private CapturePixelFormat GetCapturePixelFormat()
	{
		return CapturePixelFormat.BGRA32;
	}

	internal PhotoCaptureFrame(IntPtr nativePtr)
	{
	}

	private void Cleanup()
	{
	}

	[ThreadAndSerializationSafe]
	[NativeName("Dispose")]
	[NativeConditional("(PLATFORM_WIN || PLATFORM_WINRT) && !PLATFORM_XBOXONE")]
	private void Dispose_Internal()
	{
	}

	public void Dispose()
	{
	}

	~PhotoCaptureFrame()
	{
	}
}
