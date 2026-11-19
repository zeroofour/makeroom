using UnityEngine.Bindings;

namespace UnityEngine;

[NativeHeader("Runtime/Shaders/Keywords/KeywordSpaceScriptBindings.h")]
[NativeHeader("Runtime/Shaders/ComputeShader.h")]
[NativeHeader("Runtime/Misc/ResourceManager.h")]
[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
[NativeHeader("Runtime/Shaders/ShaderNameRegistry.h")]
[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
[NativeHeader("Runtime/Shaders/GpuPrograms/ShaderVariantCollection.h")]
[NativeHeader("Runtime/Shaders/Shader.h")]
public sealed class Shader : Object
{
	public bool isSupported
	{
		[NativeMethod("IsSupported")]
		get
		{
			return false;
		}
	}

	public static Shader Find(string name)
	{
		return null;
	}

	[FreeFunction("ShaderScripting::TagToID")]
	internal static int TagToID(string name)
	{
		return 0;
	}

	[FreeFunction(Name = "ShaderScripting::PropertyToID", IsThreadSafe = true)]
	public static int PropertyToID(string name)
	{
		return 0;
	}

	[FreeFunction("ShaderScripting::SetGlobalFloat")]
	private static void SetGlobalFloatImpl(int name, float value)
	{
	}

	[FreeFunction("ShaderScripting::SetGlobalVector")]
	private static void SetGlobalVectorImpl(int name, Vector4 value)
	{
	}

	[FreeFunction("ShaderScripting::SetGlobalTexture")]
	private static void SetGlobalTextureImpl(int name, Texture value)
	{
	}

	[FreeFunction("ShaderScripting::GetGlobalFloat")]
	private static float GetGlobalFloatImpl(int name)
	{
		return 0f;
	}

	public static void SetGlobalInt(string name, int value)
	{
	}

	public static void SetGlobalFloat(string name, float value)
	{
	}

	public static void SetGlobalFloat(int nameID, float value)
	{
	}

	public static void SetGlobalColor(string name, Color value)
	{
	}

	public static void SetGlobalTexture(string name, Texture value)
	{
	}

	public static float GetGlobalFloat(string name)
	{
		return 0f;
	}

	private Shader()
	{
	}

	private static void SetGlobalVectorImpl_Injected(int name, ref Vector4 value)
	{
	}
}
