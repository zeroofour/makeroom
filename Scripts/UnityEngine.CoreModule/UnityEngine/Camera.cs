using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine;

[UsedByNativeCode]
[NativeHeader("Runtime/Camera/Camera.h")]
[RequireComponent(typeof(Transform))]
[NativeHeader("Runtime/Camera/RenderManager.h")]
[NativeHeader("Runtime/Graphics/CommandBuffer/RenderingCommandBuffer.h")]
[NativeHeader("Runtime/Graphics/RenderTexture.h")]
[NativeHeader("Runtime/Misc/GameObjectUtility.h")]
[NativeHeader("Runtime/GfxDevice/GfxDeviceTypes.h")]
[NativeHeader("Runtime/Shaders/Shader.h")]
public sealed class Camera : Behaviour
{
	public enum StereoscopicEye
	{
		Left = 0,
		Right = 1
	}

	public enum MonoOrStereoscopicEye
	{
		Left = 0,
		Right = 1,
		Mono = 2
	}

	public enum RenderRequestMode
	{
		None = 0,
		ObjectId = 1,
		Depth = 2,
		VertexNormal = 3,
		WorldPosition = 4,
		EntityId = 5,
		BaseColor = 6,
		SpecularColor = 7,
		Metallic = 8,
		Emission = 9,
		Normal = 10,
		Smoothness = 11,
		Occlusion = 12,
		DiffuseColor = 13
	}

	public enum RenderRequestOutputSpace
	{
		ScreenSpace = -1,
		UV0 = 0,
		UV1 = 1,
		UV2 = 2,
		UV3 = 3,
		UV4 = 4,
		UV5 = 5,
		UV6 = 6,
		UV7 = 7,
		UV8 = 8
	}

	public struct RenderRequest
	{
		private readonly RenderRequestMode m_CameraRenderMode;

		private readonly RenderTexture m_ResultRT;

		private readonly RenderRequestOutputSpace m_OutputSpace;
	}

	public delegate void CameraCallback(Camera cam);

	public static CameraCallback onPreCull;

	public static CameraCallback onPreRender;

	public static CameraCallback onPostRender;

	[NativeProperty("Near")]
	public float nearClipPlane => 0f;

	[NativeProperty("Far")]
	public float farClipPlane
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	[NativeProperty("VerticalFieldOfView")]
	public float fieldOfView
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public RenderingPath actualRenderingPath
	{
		[NativeName("CalculateRenderingPath")]
		get
		{
			return RenderingPath.VertexLit;
		}
	}

	public bool allowHDR
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool allowMSAA
	{
		set
		{
		}
	}

	public bool allowDynamicResolution => false;

	[NativeProperty("ForceIntoRT")]
	public bool forceIntoRenderTexture
	{
		set
		{
		}
	}

	public float orthographicSize
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public bool orthographic
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public float depth => 0f;

	public float aspect => 0f;

	public int cullingMask
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int eventMask => 0;

	public CameraType cameraType => (CameraType)0;

	public Color backgroundColor
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public CameraClearFlags clearFlags
	{
		get
		{
			return (CameraClearFlags)0;
		}
		set
		{
		}
	}

	public DepthTextureMode depthTextureMode
	{
		get
		{
			return DepthTextureMode.None;
		}
		set
		{
		}
	}

	public bool usePhysicalProperties
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	[NativeProperty("NormalizedViewportRect")]
	public Rect rect
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	[NativeProperty("ScreenViewportRect")]
	public Rect pixelRect => default;

	public int pixelWidth
	{
		[FreeFunction("CameraScripting::GetPixelWidth", HasExplicitThis = true)]
		get
		{
			return 0;
		}
	}

	public int pixelHeight
	{
		[FreeFunction("CameraScripting::GetPixelHeight", HasExplicitThis = true)]
		get
		{
			return 0;
		}
	}

	public int scaledPixelWidth
	{
		[FreeFunction("CameraScripting::GetScaledPixelWidth", HasExplicitThis = true)]
		get
		{
			return 0;
		}
	}

	public int scaledPixelHeight
	{
		[FreeFunction("CameraScripting::GetScaledPixelHeight", HasExplicitThis = true)]
		get
		{
			return 0;
		}
	}

	public RenderTexture targetTexture
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int targetDisplay => 0;

	public Matrix4x4 worldToCameraMatrix => default;

	public Matrix4x4 projectionMatrix
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public Matrix4x4 nonJitteredProjectionMatrix
	{
		set
		{
		}
	}

	[NativeProperty("UseJitteredProjectionMatrixForTransparent")]
	public bool useJitteredProjectionMatrixForTransparentRendering
	{
		set
		{
		}
	}

	public static Camera main
	{
		[FreeFunction("FindMainCamera")]
		get
		{
			return null;
		}
	}

	public static Camera current
	{
		[FreeFunction("GetCurrentCameraPPtr")]
		get
		{
			return null;
		}
	}

	public bool stereoEnabled
	{
		[NativeMethod("GetStereoEnabledForBuiltInOrSRP")]
		get
		{
			return false;
		}
	}

	public StereoTargetEyeMask stereoTargetEye => StereoTargetEyeMask.None;

	public MonoOrStereoscopicEye stereoActiveEye
	{
		[FreeFunction("CameraScripting::GetStereoActiveEye", HasExplicitThis = true)]
		get
		{
			return MonoOrStereoscopicEye.Left;
		}
	}

	public static int allCamerasCount => 0;

	public void ResetProjectionMatrix()
	{
	}

	public Vector3 WorldToScreenPoint(Vector3 position, MonoOrStereoscopicEye eye)
	{
		return default;
	}

	public Vector3 ScreenToWorldPoint(Vector3 position, MonoOrStereoscopicEye eye)
	{
		return default;
	}

	public Vector3 WorldToScreenPoint(Vector3 position)
	{
		return default;
	}

	public Vector3 ScreenToWorldPoint(Vector3 position)
	{
		return default;
	}

	public Vector3 ScreenToViewportPoint(Vector3 position)
	{
		return default;
	}

	private Ray ScreenPointToRay(Vector2 pos, MonoOrStereoscopicEye eye)
	{
		return default;
	}

	public Ray ScreenPointToRay(Vector3 pos, MonoOrStereoscopicEye eye)
	{
		return default;
	}

	public Ray ScreenPointToRay(Vector3 pos)
	{
		return default;
	}

	public Matrix4x4 GetStereoNonJitteredProjectionMatrix(StereoscopicEye eye)
	{
		return default;
	}

	public void CopyStereoDeviceProjectionMatrixToNonJittered(StereoscopicEye eye)
	{
	}

	[FreeFunction("CameraScripting::GetStereoProjectionMatrix", HasExplicitThis = true)]
	public Matrix4x4 GetStereoProjectionMatrix(StereoscopicEye eye)
	{
		return default;
	}

	public void SetStereoProjectionMatrix(StereoscopicEye eye, Matrix4x4 matrix)
	{
	}

	public void ResetStereoProjectionMatrices()
	{
	}

	[FreeFunction("CameraScripting::GetAllCamerasCount")]
	private static int GetAllCamerasCount()
	{
		return 0;
	}

	[FreeFunction("CameraScripting::GetAllCameras")]
	private static int GetAllCamerasImpl([Out][NotNull("ArgumentNullException")] Camera[] cam)
	{
		return 0;
	}

	public static int GetAllCameras(Camera[] cameras)
	{
		return 0;
	}

	[FreeFunction("CameraScripting::Render", HasExplicitThis = true)]
	public void Render()
	{
	}

	[FreeFunction("CameraScripting::RenderWithShader", HasExplicitThis = true)]
	public void RenderWithShader(Shader shader, string replacementTag)
	{
	}

	[FreeFunction("CameraScripting::SetupCurrent")]
	public static void SetupCurrent(Camera cur)
	{
	}

	[FreeFunction("CameraScripting::CopyFrom", HasExplicitThis = true)]
	public void CopyFrom(Camera other)
	{
	}

	[NativeName("AddCommandBuffer")]
	private void AddCommandBufferImpl(CameraEvent evt, [NotNull("ArgumentNullException")] CommandBuffer buffer)
	{
	}

	[NativeName("RemoveCommandBuffer")]
	private void RemoveCommandBufferImpl(CameraEvent evt, [NotNull("ArgumentNullException")] CommandBuffer buffer)
	{
	}

	public void AddCommandBuffer(CameraEvent evt, CommandBuffer buffer)
	{
	}

	public void RemoveCommandBuffer(CameraEvent evt, CommandBuffer buffer)
	{
	}

	[RequiredByNativeCode]
	private static void FireOnPreCull(Camera cam)
	{
	}

	[RequiredByNativeCode]
	private static void FireOnPreRender(Camera cam)
	{
	}

	[RequiredByNativeCode]
	private static void FireOnPostRender(Camera cam)
	{
	}

	[SpecialName]
	private void get_backgroundColor_Injected(out Color ret)
	{
		ret = default;
	}

	[SpecialName]
	private void set_backgroundColor_Injected(ref Color value)
	{
	}

	[SpecialName]
	private void get_rect_Injected(out Rect ret)
	{
		ret = default;
	}

	[SpecialName]
	private void set_rect_Injected(ref Rect value)
	{
	}

	[SpecialName]
	private void get_pixelRect_Injected(out Rect ret)
	{
		ret = default;
	}

	[SpecialName]
	private void get_worldToCameraMatrix_Injected(out Matrix4x4 ret)
	{
		ret = default;
	}

	[SpecialName]
	private void get_projectionMatrix_Injected(out Matrix4x4 ret)
	{
		ret = default;
	}

	[SpecialName]
	private void set_projectionMatrix_Injected(ref Matrix4x4 value)
	{
	}

	[SpecialName]
	private void set_nonJitteredProjectionMatrix_Injected(ref Matrix4x4 value)
	{
	}

	private void WorldToScreenPoint_Injected(ref Vector3 position, MonoOrStereoscopicEye eye, out Vector3 ret)
	{
		ret = default;
	}

	private void ScreenToWorldPoint_Injected(ref Vector3 position, MonoOrStereoscopicEye eye, out Vector3 ret)
	{
		ret = default;
	}

	private void ScreenToViewportPoint_Injected(ref Vector3 position, out Vector3 ret)
	{
		ret = default;
	}

	private void ScreenPointToRay_Injected(ref Vector2 pos, MonoOrStereoscopicEye eye, out Ray ret)
	{
		ret = default;
	}

	private void GetStereoNonJitteredProjectionMatrix_Injected(StereoscopicEye eye, out Matrix4x4 ret)
	{
		ret = default;
	}

	private void GetStereoProjectionMatrix_Injected(StereoscopicEye eye, out Matrix4x4 ret)
	{
		ret = default;
	}

	private void SetStereoProjectionMatrix_Injected(StereoscopicEye eye, ref Matrix4x4 matrix)
	{
	}
}
