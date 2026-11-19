using System;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace SCPE;

[Serializable]
[PostProcess(typeof(CloudShadowsRenderer), PostProcessEvent.BeforeStack, "SC Post Effects/Environment/Cloud Shadows", true)]
public sealed class CloudShadows : PostProcessEffectSettings
{
	[Tooltip("The red channel of this texture is used to sample the clouds")]
	[DisplayName("Texture (R)")]
	public TextureParameter texture;

	[DisplayName("Density")]
	[Range(0f, 1f)]
	public FloatParameter density;

	[DisplayName("Size")]
	[Range(0f, 1f)]
	[Space]
	public FloatParameter size;

	[DisplayName("Speed")]
	[Range(0f, 1f)]
	public FloatParameter speed;

	[Tooltip("Set the X and Z world-space direction the clouds should move in")]
	[DisplayName("Direction")]
	public Vector2Parameter direction;

	public BoolParameter projectFromSun;

	public FloatParameter startFadeDistance;

	public FloatParameter endFadeDistance;

	[SerializeField]
	public Shader shader;

	public override bool IsEnabledAndSupported(PostProcessRenderContext context)
	{
		return false;
	}

	private bool SerializeShader()
	{
		return false;
	}
}
