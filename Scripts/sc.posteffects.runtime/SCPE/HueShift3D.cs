using System;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace SCPE;

[Serializable]
[PostProcess(typeof(HueShift3DRenderer), PostProcessEvent.AfterStack, "SC Post Effects/Image/3D Hue Shift", true)]
public sealed class HueShift3D : PostProcessEffectSettings
{
	public enum ColorSource
	{
		RGBSpectrum = 0,
		GradientTexture = 1
	}

	[Serializable]
	public sealed class ColorSourceParameter : ParameterOverride<ColorSource>
	{
	}

	[Tooltip("Box blurring uses fewer texture samples but has a limited blur range")]
	[DisplayName("Method")]
	public ColorSourceParameter colorSource;

	[DisplayName("Gradient Texture")]
	public TextureParameter gradientTex;

	[DisplayName("Opacity")]
	[Range(0f, 1f)]
	public FloatParameter intensity;

	[Range(0f, 1f)]
	[Tooltip("Speed")]
	public FloatParameter speed;

	[Tooltip("Size")]
	[Range(0f, 3f)]
	public FloatParameter size;

	[Tooltip("Bends the effect over the scene's geometry normals\n\nHigh values may induce banding artifacts")]
	[DisplayName("Geometry normal influence")]
	[Range(0f, 10f)]
	public FloatParameter geoInfluence;

	public static bool isOrtho;

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
