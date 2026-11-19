using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine.XR;

[NativeHeader("Modules/XR/XRPrefix.h")]
[NativeConditional("ENABLE_XR")]
[NativeType(Header = "Modules/XR/Subsystems/Display/XRDisplaySubsystem.h")]
[UsedByNativeCode]
public class XRDisplaySubsystem : IntegratedSubsystem<XRDisplaySubsystemDescriptor>
{
	[NativeHeader("Runtime/Graphics/CommandBuffer/RenderingCommandBuffer.h")]
	[NativeHeader("Modules/XR/Subsystems/Display/XRDisplaySubsystem.bindings.h")]
	[NativeHeader("Runtime/Graphics/RenderTextureDesc.h")]
	public struct XRRenderPass
	{
		private IntPtr displaySubsystemInstance;

		public int renderPassIndex;

		public RenderTargetIdentifier renderTarget;

		public RenderTextureDescriptor renderTargetDesc;

		public bool hasMotionVectorPass;

		public RenderTargetIdentifier motionVectorRenderTarget;

		public RenderTextureDescriptor motionVectorRenderTargetDesc;

		public bool shouldFillOutDepth;

		public int cullingPassIndex;
	}

	[NativeHeader("Modules/XR/Subsystems/Display/XRDisplaySubsystem.bindings.h")]
	public struct XRMirrorViewBlitDesc
	{
		private IntPtr displaySubsystemInstance;

		public bool nativeBlitAvailable;

		public bool nativeBlitInvalidStates;

		public int blitParamsCount;
	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Action<bool> displayFocusChanged;

	[RequiredByNativeCode]
	private void InvokeDisplayFocusChanged(bool focus)
	{
	}
}
