using System;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace SCPE;

[Serializable]
[PostProcess(typeof(OverlayRenderer), PostProcessEvent.AfterStack, "SC Post Effects/Screen/Overlay", true)]
public sealed class Overlay : PostProcessEffectSettings
{
	public enum BlendMode
	{
		Linear = 0,
		Additive = 1,
		Multiply = 2,
		Screen = 3
	}

	[Serializable]
	public sealed class BlendModeParameter : ParameterOverride<BlendMode>
	{
	}

	[Tooltip("The texture's alpha channel controls its opacity")]
	public TextureParameter overlayTex;

	[Range(0f, 1f)]
	public FloatParameter intensity;

	[Range(0f, 1f)]
	[Tooltip("The screen's luminance values control the opacity of the image")]
	public FloatParameter luminanceThreshold;

	[Tooltip("Maintains the image aspect ratio, regardless of the screen width")]
	public BoolParameter autoAspect;

	[Tooltip("Blends the gradient through various Photoshop-like blending modes")]
	public BlendModeParameter blendMode;

	[Range(0f, 1f)]
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
