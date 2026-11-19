using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[NativeHeader("Runtime/Graphics/DisplayManager.h")]
[UsedByNativeCode]
public class Display
{
	public delegate void DisplaysUpdatedDelegate();

	internal IntPtr nativeDisplay;

	public static Display[] displays;

	private static Display _mainDisplay;

	private static int m_ActiveEditorGameViewTarget;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static DisplaysUpdatedDelegate onDisplaysUpdated;

	public int renderingWidth => 0;

	public int renderingHeight => 0;

	public int systemWidth => 0;

	public int systemHeight => 0;

	public RenderBuffer colorBuffer => default;

	public static Display main => null;

	internal Display()
	{
	}

	internal Display(IntPtr nativeDisplay)
	{
	}

	public static Vector3 RelativeMouseAt(Vector3 inputMouseCoordinates)
	{
		return default;
	}

	[RequiredByNativeCode]
	private static void RecreateDisplayList(IntPtr[] nativeDisplay)
	{
	}

	[RequiredByNativeCode]
	private static void FireDisplaysUpdated()
	{
	}

	[FreeFunction("UnityDisplayManager_DisplaySystemResolution")]
	private static void GetSystemExtImpl(IntPtr nativeDisplay, out int w, out int h)
	{
		w = default;
		h = default;
	}

	[FreeFunction("UnityDisplayManager_DisplayRenderingResolution")]
	private static void GetRenderingExtImpl(IntPtr nativeDisplay, out int w, out int h)
	{
		w = default;
		h = default;
	}

	[FreeFunction("UnityDisplayManager_GetRenderingBuffersWrapper")]
	private static void GetRenderingBuffersImpl(IntPtr nativeDisplay, out RenderBuffer color, out RenderBuffer depth)
	{
		color = default;
		depth = default;
	}

	[FreeFunction("UnityDisplayManager_RelativeMouseAt")]
	private static int RelativeMouseAtImpl(int x, int y, out int rx, out int ry)
	{
		rx = default;
		ry = default;
		return 0;
	}
}
