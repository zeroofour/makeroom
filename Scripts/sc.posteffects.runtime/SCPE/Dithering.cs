using System;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace SCPE;

[Serializable]
[PostProcess(typeof(DitheringRenderer), PostProcessEvent.AfterStack, "SC Post Effects/Retro/Dithering", true)]
public sealed class Dithering : PostProcessEffectSettings
{
	[DisplayName("Pattern")]
	[Tooltip("Note that the texture's filter mode (Point or Bilinear) greatly affects the behavior of the pattern")]
	public TextureParameter lut;

	[Range(0f, 1f)]
	[Tooltip("Fades the effect in or out")]
	public FloatParameter intensity;

	[Tooltip("The screen's luminance values control the density of the dithering matrix")]
	[Range(0f, 1f)]
	public FloatParameter luminanceThreshold;

	[Range(0f, 2f)]
	[DisplayName("Tiling")]
	public FloatParameter tiling;

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
