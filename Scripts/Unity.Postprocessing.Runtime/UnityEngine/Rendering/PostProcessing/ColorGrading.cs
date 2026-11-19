using System;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
[PostProcess(typeof(ColorGradingRenderer), "Unity/Color Grading", true)]
public sealed class ColorGrading : PostProcessEffectSettings
{
	[Tooltip("Select a color grading mode that fits your dynamic range and workflow. Use HDR if your camera is set to render in HDR and your target platform supports it. Use LDR for low-end mobiles or devices that don't support HDR. Use External if you prefer authoring a Log LUT in an external software.")]
	[DisplayName("Mode")]
	public GradingModeParameter gradingMode;

	[Tooltip("A custom 3D log-encoded texture.")]
	[DisplayName("Lookup Texture")]
	public TextureParameter externalLut;

	[Tooltip("Select a tonemapping algorithm to use at the end of the color grading process.")]
	[DisplayName("Mode")]
	public TonemapperParameter tonemapper;

	[Tooltip("Affects the transition between the toe and the mid section of the curve. A value of 0 means no toe, a value of 1 means a very hard transition.")]
	[Range(0f, 1f)]
	[DisplayName("Toe Strength")]
	public FloatParameter toneCurveToeStrength;

	[Tooltip("Affects how much of the dynamic range is in the toe. With a small value, the toe will be very short and quickly transition into the linear section, with a larger value, the toe will be longer.")]
	[Range(0f, 1f)]
	[DisplayName("Toe Length")]
	public FloatParameter toneCurveToeLength;

	[Range(0f, 1f)]
	[DisplayName("Shoulder Strength")]
	[Tooltip("Affects the transition between the mid section and the shoulder of the curve. A value of 0 means no shoulder, a value of 1 means a very hard transition.")]
	public FloatParameter toneCurveShoulderStrength;

	[Tooltip("Affects how many F-stops (EV) to add to the dynamic range of the curve.")]
	[DisplayName("Shoulder Length")]
	[Min(0f)]
	public FloatParameter toneCurveShoulderLength;

	[DisplayName("Shoulder Angle")]
	[Range(0f, 1f)]
	[Tooltip("Affects how much overshoot to add to the shoulder.")]
	public FloatParameter toneCurveShoulderAngle;

	[Tooltip("Applies a gamma function to the curve.")]
	[DisplayName("Gamma")]
	[Min(0.001f)]
	public FloatParameter toneCurveGamma;

	[DisplayName("Lookup Texture")]
	[Tooltip("Custom lookup texture (strip format, for example 256x16) to apply before the rest of the color grading operators. If none is provided, a neutral one will be generated internally.")]
	public TextureParameter ldrLut;

	[Range(0f, 1f)]
	[Tooltip("How much of the lookup texture will contribute to the color grading effect.")]
	[DisplayName("Contribution")]
	public FloatParameter ldrLutContribution;

	[Tooltip("Sets the white balance to a custom color temperature.")]
	[Range(-100f, 100f)]
	[DisplayName("Temperature")]
	public FloatParameter temperature;

	[Range(-100f, 100f)]
	[Tooltip("Sets the white balance to compensate for a green or magenta tint.")]
	[DisplayName("Tint")]
	public FloatParameter tint;

	[ColorUsage(false, true)]
	[Tooltip("Tint the render by multiplying a color.")]
	[DisplayName("Color Filter")]
	public ColorParameter colorFilter;

	[Range(-180f, 180f)]
	[Tooltip("Shift the hue of all colors.")]
	[DisplayName("Hue Shift")]
	public FloatParameter hueShift;

	[DisplayName("Saturation")]
	[Tooltip("Pushes the intensity of all colors.")]
	[Range(-100f, 100f)]
	public FloatParameter saturation;

	[DisplayName("Brightness")]
	[Range(-100f, 100f)]
	[Tooltip("Makes the image brighter or darker.")]
	public FloatParameter brightness;

	[DisplayName("Post-exposure (EV)")]
	[Tooltip("Adjusts the overall exposure of the scene in EV units. This is applied after the HDR effect and right before tonemapping so it won't affect previous effects in the chain.")]
	public FloatParameter postExposure;

	[DisplayName("Contrast")]
	[Range(-100f, 100f)]
	[Tooltip("Expands or shrinks the overall range of tonal values.")]
	public FloatParameter contrast;

	[Tooltip("Modify influence of the red channel in the overall mix.")]
	[Range(-200f, 200f)]
	[DisplayName("Red")]
	public FloatParameter mixerRedOutRedIn;

	[DisplayName("Green")]
	[Tooltip("Modify influence of the green channel in the overall mix.")]
	[Range(-200f, 200f)]
	public FloatParameter mixerRedOutGreenIn;

	[Range(-200f, 200f)]
	[Tooltip("Modify influence of the blue channel in the overall mix.")]
	[DisplayName("Blue")]
	public FloatParameter mixerRedOutBlueIn;

	[DisplayName("Red")]
	[Range(-200f, 200f)]
	[Tooltip("Modify influence of the red channel in the overall mix.")]
	public FloatParameter mixerGreenOutRedIn;

	[Range(-200f, 200f)]
	[DisplayName("Green")]
	[Tooltip("Modify influence of the green channel in the overall mix.")]
	public FloatParameter mixerGreenOutGreenIn;

	[DisplayName("Blue")]
	[Range(-200f, 200f)]
	[Tooltip("Modify influence of the blue channel in the overall mix.")]
	public FloatParameter mixerGreenOutBlueIn;

	[DisplayName("Red")]
	[Tooltip("Modify influence of the red channel in the overall mix.")]
	[Range(-200f, 200f)]
	public FloatParameter mixerBlueOutRedIn;

	[Tooltip("Modify influence of the green channel in the overall mix.")]
	[Range(-200f, 200f)]
	[DisplayName("Green")]
	public FloatParameter mixerBlueOutGreenIn;

	[Range(-200f, 200f)]
	[DisplayName("Blue")]
	[Tooltip("Modify influence of the blue channel in the overall mix.")]
	public FloatParameter mixerBlueOutBlueIn;

	[DisplayName("Lift")]
	[Trackball(TrackballAttribute.Mode.Lift)]
	[Tooltip("Controls the darkest portions of the render.")]
	public Vector4Parameter lift;

	[DisplayName("Gamma")]
	[Trackball(TrackballAttribute.Mode.Gamma)]
	[Tooltip("Power function that controls mid-range tones.")]
	public Vector4Parameter gamma;

	[DisplayName("Gain")]
	[Trackball(TrackballAttribute.Mode.Gain)]
	[Tooltip("Controls the lightest portions of the render.")]
	public Vector4Parameter gain;

	public SplineParameter masterCurve;

	public SplineParameter redCurve;

	public SplineParameter greenCurve;

	public SplineParameter blueCurve;

	public SplineParameter hueVsHueCurve;

	public SplineParameter hueVsSatCurve;

	public SplineParameter satVsSatCurve;

	public SplineParameter lumVsSatCurve;

	public override bool IsEnabledAndSupported(PostProcessRenderContext context)
	{
		return false;
	}
}
