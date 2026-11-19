Shader "LazyEti/BIRP/FakePointLight" {
	Properties {
		[SingleLineTexture] [NoScaleOffset] _GradientTexture ("Gradient Texture", 2D) = "white" {}
		[HDR] _LightTint ("Light Tint", Vector) = (1,1,1,1)
		[Space(5)] _LightSoftness ("Light Softness", Range(0, 1)) = 1
		[IntRange] _LightPosterize ("Light Posterize", Range(0, 128)) = 1
		[Space(5)] _ShadingBlend ("Shading Blend", Range(0, 1)) = 0.5
		_ShadingSoftness ("Shading Softness", Range(0.01, 1)) = 0.01
		[Toggle(___HALO____ON)] ___Halo___ ("___Halo___", Float) = 1
		[HDR] _HaloTint ("Halo Tint", Vector) = (1,1,1,1)
		_HaloSize ("Halo Size", Range(0, 5)) = 0
		[IntRange] _HaloPosterize ("Halo Posterize", Range(0, 128)) = 0
		_HaloDepthFade ("Halo Depth Fade", Range(0.1, 2)) = 0.5
		[Space(25)] [Toggle] DistanceFade ("___Distance Fade___", Float) = 0
		[Tooltip(Starts fading away at this distance from the camera)] _FarFade ("Far Fade", Range(0, 400)) = 200
		_FarTransition ("Far Transition", Range(1, 100)) = 50
		_CloseFade ("Close Fade", Range(0, 50)) = 0
		_CloseTransition ("Close Transition", Range(0, 50)) = 0
		[Space(25)] [Toggle(___FLICKERING____ON)] ___Flickering___ ("___Flickering___", Float) = 0
		_FlickerIntensity ("Flicker Intensity", Range(0, 1)) = 0.5
		_FlickerHue ("Flicker Hue", Vector) = (1,1,1,1)
		_FlickerSpeed ("Flicker Speed", Range(0.01, 5)) = 1
		_FlickerSoftness ("Flicker Softness", Range(0, 1)) = 0.5
		_SizeFlickering ("Size Flickering", Range(0, 0.5)) = 0.1
		[Space(25)] [Toggle(___NOISE____ON)] ___Noise___ ("___Noise___", Float) = 0
		[SingleLineTexture] [NoScaleOffset] _NoiseTexture ("Noise Texture", 2D) = "white" {}
		[KeywordEnum(Red,RedxGreen,Alpha)] _TexturePacking ("Texture Packing", Float) = 0
		_Noisiness ("Noisiness", Range(0, 2)) = 1
		_NoiseScale ("Noise Scale", Range(0.1, 5)) = 0.1
		_NoiseMovement ("Noise Movement", Range(0, 1)) = 0
		[Space(20)] [Toggle(_SPECULARHIGHLIGHT_ON)] _SpecularHighlight ("Specular Highlight", Float) = 0
		_SpecIntensity ("Spec Intensity", Range(0, 1)) = 0.5
		[Space(20)] [Toggle(_DITHERINGPATTERN_ON)] _DitheringPattern ("Dithering Pattern", Float) = 0
		_DitherIntensity ("Dither Intensity", Range(0.01, 1)) = 0.5
		[Space(20)] [KeywordEnum(OFF,Low,Medium,High,Insane)] _ScreenShadows ("Screen Shadows (HEAVY)", Float) = 0
		[space(25)] _ShadowThreshold ("Shadow Threshold", Range(0.05, 1)) = 0.5
		[Toggle(_PARTICLEMODE_ON)] _ParticleMode ("Particle Mode", Float) = 0
		[Space(15)] [Toggle(_DAYFADING_ON)] _DayFading ("Day Fading", Float) = 0
		[Space(15)] [KeywordEnum(Additive,Contrast,Negative)] _Blendmode ("Blendmode", Float) = 0
		[Enum(Default,0,Off,1,On,2)] [Space(5)] _DepthWrite ("Depth Write", Float) = 0
		[IntRange] [HideInInspector] _SrcBlend ("SrcBlend", Range(0, 12)) = 1
		[IntRange] [HideInInspector] _DstBlend ("DstBlend", Range(0, 12)) = 1
		[HideInInspector] _RandomOffset ("RandomOffset", Range(0, 1)) = 0
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType" = "Opaque" }
		LOD 200

		Pass
		{
			HLSLPROGRAM
			#pragma vertex vert
			#pragma fragment frag

			float4x4 unity_ObjectToWorld;
			float4x4 unity_MatrixVP;

			struct Vertex_Stage_Input
			{
				float4 pos : POSITION;
			};

			struct Vertex_Stage_Output
			{
				float4 pos : SV_POSITION;
			};

			Vertex_Stage_Output vert(Vertex_Stage_Input input)
			{
				Vertex_Stage_Output output;
				output.pos = mul(unity_MatrixVP, mul(unity_ObjectToWorld, input.pos));
				return output;
			}

			float4 frag(Vertex_Stage_Output input) : SV_TARGET
			{
				return float4(1.0, 1.0, 1.0, 1.0); // RGBA
			}

			ENDHLSL
		}
	}
	//CustomEditor "FPL.CustomMaterialEditor"
}