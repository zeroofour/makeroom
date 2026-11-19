using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace SCPE;

public sealed class FogRenderer : PostProcessEffectRenderer<Fog>
{
	private struct MipLevel
	{
		internal int down;

		internal int up;
	}

	private enum Pass
	{
		Prefilter = 0,
		Downsample = 1,
		Upsample = 2,
		Blend = 3,
		BlendScattering = 4
	}

	private Shader shader;

	private int skyboxTexID;

	private MipLevel[] m_Pyramid;

	private const int k_MaxPyramidSize = 16;

	private static readonly Vector3[] skySphereVertices;

	private static readonly int[] skySphereTriangles;

	private static Mesh _SkySphere;

	private static Mesh SkySphere => null;

	public override void Init()
	{
	}

	public override void Render(PostProcessRenderContext context)
	{
	}

	public override DepthTextureMode GetCameraFlags()
	{
		return DepthTextureMode.None;
	}
}
