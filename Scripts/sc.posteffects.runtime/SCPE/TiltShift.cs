using System;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace SCPE;

[Serializable]
[PostProcess(typeof(TiltShiftRenderer), PostProcessEvent.AfterStack, "SC Post Effects/Blurring/Tilt Shift", true)]
public class TiltShift : PostProcessEffectSettings
{
	public enum TiltShiftMethod
	{
		Horizontal = 0,
		Radial = 1
	}

	[Serializable]
	public sealed class TiltShifMethodParameter : ParameterOverride<TiltShiftMethod>
	{
	}

	public enum Quality
	{
		Performance = 0,
		Appearance = 1
	}

	[Serializable]
	public sealed class TiltShiftQualityParameter : ParameterOverride<Quality>
	{
	}

	[Range(0f, 1f)]
	[Tooltip("The amount of blurring that must be performed")]
	public FloatParameter amount;

	[DisplayName("Method")]
	public TiltShifMethodParameter mode;

	[DisplayName("Quality")]
	[Tooltip("Choose to use more texture samples, for a smoother blur when using a high blur amout")]
	public TiltShiftQualityParameter quality;

	[Range(0f, 1f)]
	public FloatParameter areaSize;

	[Range(0f, 1f)]
	public FloatParameter areaFalloff;

	[Range(-1f, 1f)]
	public FloatParameter offset;

	[Range(0f, 360f)]
	public FloatParameter angle;

	public static bool debug;

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
