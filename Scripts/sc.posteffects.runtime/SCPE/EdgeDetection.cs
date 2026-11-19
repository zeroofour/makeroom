using System;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace SCPE;

[Serializable]
[PostProcess(typeof(EdgeDetectionRenderer), PostProcessEvent.BeforeStack, "SC Post Effects/Stylized/Edge Detection", true)]
public sealed class EdgeDetection : PostProcessEffectSettings
{
	public enum EdgeDetectMode
	{
		DepthNormals = 0,
		CrossDepthNormals = 1,
		SobelDepth = 2,
		LuminanceBased = 3
	}

	[Serializable]
	public sealed class EdgeDetectionMode : ParameterOverride<EdgeDetectMode>
	{
	}

	[DisplayName("Edges Only")]
	[Range(0f, 1f)]
	[Tooltip("Shows only the effect, to allow for finetuning")]
	public BoolParameter debug;

	[Tooltip("Choose one of the different edge solvers")]
	public EdgeDetectionMode mode;

	public BoolParameter invertFadeDistance;

	[Tooltip("Fades out the effect between the cameras near and far clipping plane")]
	public BoolParameter distanceFade;

	public FloatParameter startFadeDistance;

	public FloatParameter endFadeDistance;

	[DisplayName("Depth sensitivity")]
	[Range(0f, 1f)]
	[Tooltip("Sets how much difference in depth between pixels contribute to drawing an edge")]
	public FloatParameter sensitivityDepth;

	[Tooltip("Sets how much difference in normals between pixels contribute to drawing an edge")]
	[Range(0f, 1f)]
	[DisplayName("Normals sensitivity")]
	public FloatParameter sensitivityNormals;

	[Tooltip("Luminance threshold, pixels above this threshold will contribute to the effect")]
	[Range(0.01f, 1f)]
	[DisplayName("Luminance Threshold")]
	public FloatParameter lumThreshold;

	[DisplayName("Color")]
	[Tooltip(null)]
	public ColorParameter edgeColor;

	[Tooltip("Edge Exponent")]
	[Range(1f, 50f)]
	public FloatParameter edgeExp;

	[Range(1f, 4f)]
	[DisplayName("Size")]
	[Tooltip("Edge Distance")]
	public IntParameter edgeSize;

	[Range(0f, 1f)]
	[Tooltip("Opacity")]
	[DisplayName("Opacity")]
	public FloatParameter edgeOpacity;

	[Tooltip("Limit the effect to inward edges only")]
	[DisplayName("Thin")]
	public BoolParameter sobelThin;

	[SerializeField]
	public Shader shader;

	public override bool IsEnabledAndSupported(PostProcessRenderContext context)
	{
		return false;
	}

	private void Reset()
	{
	}

	private bool SerializeShader()
	{
		return false;
	}
}
