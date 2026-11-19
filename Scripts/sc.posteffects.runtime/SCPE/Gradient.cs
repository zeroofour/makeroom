using System;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace SCPE;

[Serializable]
[PostProcess(typeof(GradientRenderer), PostProcessEvent.AfterStack, "SC Post Effects/Screen/Gradient", true)]
public sealed class Gradient : PostProcessEffectSettings
{
	public enum Mode
	{
		ColorFields = 0,
		Texture = 1
	}

	[Serializable]
	public sealed class GradientModeParameter : ParameterOverride<Mode>
	{
	}

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

	[Range(0f, 1f)]
	[DisplayName("Opacity")]
	public FloatParameter intensity;

	[Space]
	[Tooltip("Set the color either through 2 color fields, or a gradient texture")]
	public GradientModeParameter input;

	[Tooltip("The color's alpha channel controls its opacity")]
	public ColorParameter color1;

	[Tooltip("The color's alpha channel controls its opacity")]
	public ColorParameter color2;

	[Tooltip("Controls the rotation of the gradient")]
	[Space]
	[Range(0f, 1f)]
	public FloatParameter rotation;

	[DisplayName("Gradient")]
	[Tooltip(null)]
	public TextureParameter gradientTex;

	[Tooltip("Blends the gradient through various Photoshop-like blending modes")]
	public BlendModeParameter mode;

	private const int RESOLUTION = 64;

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
