using System;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace SCPE;

[Serializable]
[PostProcess(typeof(FogRenderer), PostProcessEvent.BeforeTransparent, "SC Post Effects/Environment/Screen-Space Fog", true)]
public sealed class Fog : PostProcessEffectSettings
{
	[Serializable]
	public sealed class FogModeParameter : ParameterOverride<FogMode>
	{
	}

	public enum FogColorSource
	{
		UniformColor = 0,
		GradientTexture = 1,
		SkyboxColor = 2
	}

	[Serializable]
	public sealed class FogColorSourceParameter : ParameterOverride<FogColorSource>
	{
	}

	[Tooltip("Use the settings of the current active scene found under the Lighting tab\n\nThis is also advisable for third-party scripts that modify fog settings\n\nThis will force the effect to use the scene's fog color")]
	[DisplayName("Use scene's settings")]
	public BoolParameter useSceneSettings;

	[DisplayName("Mode")]
	[Tooltip("Sets how the fog distance is calculated")]
	public FogModeParameter fogMode;

	[Range(0f, 1f)]
	public FloatParameter globalDensity;

	[DisplayName("Start")]
	public FloatParameter fogStartDistance;

	[DisplayName("End")]
	public FloatParameter fogEndDistance;

	[Tooltip("Color: use a uniform color for the fog\n\nGradient: sample a gradient texture to control the fog color over distance, the alpha channel controls the density\n\nSkybox: Sample the skybox's color for the fog, only works well with low detail skies")]
	[Space]
	public FogColorSourceParameter colorSource;

	[DisplayName("Color")]
	[ColorUsage(true, true)]
	public ColorParameter fogColor;

	[DisplayName("Texture")]
	public TextureParameter fogColorGradient;

	[Tooltip("Automatic mode uses the current camera's far clipping plane to set the max distance\n\nOtherwise, a fixed value may be used instead")]
	public FloatParameter gradientDistance;

	public BoolParameter gradientUseFarClipPlane;

	[Header("Distance")]
	[DisplayName("Enable")]
	public BoolParameter distanceFog;

	[UnityEngine.Rendering.PostProcessing.Min(0f)]
	[DisplayName("Density")]
	public FloatParameter distanceDensity;

	[Tooltip("Distance based on radial distance from viewer, rather than parrallel")]
	public BoolParameter useRadialDistance;

	[Header("Skybox")]
	public Vector2Parameter horizonMinMax;

	[Tooltip("Determines how much the fog influences the skybox")]
	[Range(0f, 1f)]
	public FloatParameter skyboxInfluence;

	[Tooltip("Translates the a Directional Light's direction and color into the fog. Creates a faux-atmospheric scattering effect.")]
	[Header("Directional Light")]
	public BoolParameter enableDirectionalLight;

	[Tooltip("Use the intensity of the Directional Light that's set as the caster")]
	public BoolParameter useLightDirection;

	[Tooltip("Use the color of the Directional Light that's set as the caster")]
	public BoolParameter useLightColor;

	[Tooltip("Use the intensity of the Directional Light that's set as the caster")]
	public BoolParameter useLightIntensity;

	[ColorUsage(true, true)]
	[DisplayName("Color")]
	public ColorParameter lightColor;

	[Max(1f)]
	public Vector3Parameter lightDirection;

	[UnityEngine.Rendering.PostProcessing.Min(0f)]
	public FloatParameter lightIntensity;

	[Range(1f, 100f)]
	public FloatParameter lightExponent;

	[Header("Height")]
	[Tooltip("Enable vertical height fog")]
	[DisplayName("Enable")]
	public BoolParameter heightFog;

	[Tooltip("Height relative to 0 world height position")]
	public FloatParameter height;

	[Range(0.001f, 1f)]
	[DisplayName("Density")]
	public FloatParameter heightDensity;

	[DisplayName("Enable")]
	[Tooltip("Enables height fog density variation through the use of a texture")]
	[Header("Height noise (2D)")]
	public BoolParameter heightFogNoise;

	[DisplayName("Texture (R)")]
	[Tooltip("The density is read from this texture's red color channel")]
	public TextureParameter heightNoiseTex;

	[Range(0f, 1f)]
	[DisplayName("Size")]
	public FloatParameter heightNoiseSize;

	[Range(0f, 1f)]
	[DisplayName("Strength")]
	public FloatParameter heightNoiseStrength;

	[DisplayName("Speed")]
	[Range(0f, 10f)]
	public FloatParameter heightNoiseSpeed;

	[Tooltip("Execute a bloom pass to diffuse light in dense fog")]
	[Header("Light scattering")]
	[DisplayName("Enable")]
	public BoolParameter lightScattering;

	[UnityEngine.Rendering.PostProcessing.Min(0f)]
	[Space]
	[DisplayName("Intensity")]
	public FloatParameter scatterIntensity;

	[Tooltip("Filters out pixels under this level of brightness. Value is in gamma-space.")]
	[DisplayName("Threshold")]
	[UnityEngine.Rendering.PostProcessing.Min(0f)]
	public FloatParameter scatterThreshold;

	[DisplayName("Diffusion")]
	[Range(1f, 10f)]
	public FloatParameter scatterDiffusion;

	[Range(0f, 1f)]
	[Tooltip("Makes transitions between under/over-threshold gradual. 0 for a hard threshold, 1 for a soft threshold).")]
	[DisplayName("Smoothness")]
	public FloatParameter scatterSoftKnee;

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
