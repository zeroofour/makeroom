using System;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace SCPE;

[Serializable]
[PostProcess(typeof(CausticsRenderer), PostProcessEvent.BeforeStack, "SC Post Effects/Environment/Caustics", true)]
public sealed class Caustics : PostProcessEffectSettings
{
	[Range(0f, 1f)]
	public FloatParameter intensity;

	public TextureParameter causticsTexture;

	public FloatParameter brightness;

	[Tooltip("Draws the caustics on pixels brighter than this threshold, useful to hide the caustics in shadows")]
	[Range(0f, 2f)]
	public FloatParameter luminanceThreshold;

	public BoolParameter projectFromSun;

	[Space]
	public FloatParameter minHeight;

	[Range(0f, 1f)]
	public FloatParameter minHeightFalloff;

	public FloatParameter maxHeight;

	[Range(0f, 1f)]
	public FloatParameter maxHeightFalloff;

	[Space]
	[Range(0.1f, 3f)]
	public FloatParameter size;

	[Range(0f, 1f)]
	public FloatParameter speed;

	[Space]
	public BoolParameter distanceFade;

	public FloatParameter startFadeDistance;

	public FloatParameter endFadeDistance;

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
