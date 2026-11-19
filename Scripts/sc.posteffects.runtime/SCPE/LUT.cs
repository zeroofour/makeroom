using System;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace SCPE;

[Serializable]
[PostProcess(typeof(LUTRenderer), PostProcessEvent.AfterStack, "SC Post Effects/Image/Color Grading LUT", true)]
public sealed class LUT : PostProcessEffectSettings
{
	public enum Mode
	{
		Single = 0,
		DistanceBased = 1
	}

	[Serializable]
	public sealed class ModeParam : ParameterOverride<Mode>
	{
	}

	[Tooltip("Distance-based mode blends two LUTs over a distance")]
	[DisplayName("Mode")]
	public ModeParam mode;

	public FloatParameter startFadeDistance;

	public FloatParameter endFadeDistance;

	[Tooltip("Fades the effect in or out")]
	[Range(0f, 1f)]
	public FloatParameter intensity;

	[Tooltip("Supply a LUT strip texture.")]
	public TextureParameter lutNear;

	[DisplayName("Far")]
	public TextureParameter lutFar;

	[Range(0f, 1f)]
	public FloatParameter invert;

	[Tooltip("Increases the saturation of muted colors")]
	[Range(0f, 1f)]
	public FloatParameter vibrance;

	[Tooltip("Controls the effect of vibrancy for each color channel (RGB)")]
	[ColorUsage(false, false)]
	public ColorParameter vibranceRGBBalance;

	public static bool Bypass;

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
