using System;
using System.ComponentModel;
using UnityEngine.Bindings;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine;

[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
[NativeHeader("Runtime/Shaders/Material.h")]
public class Material : Object
{
	public Shader shader => null;

	public Color color
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public Texture mainTexture
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[NativeProperty("EnableInstancingVariants")]
	public bool enableInstancing => false;

	public string[] shaderKeywords
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[FreeFunction("MaterialScripting::CreateWithShader")]
	private static void CreateWithShader([Writable] Material self, [NotNull("ArgumentNullException")] Shader shader)
	{
	}

	[FreeFunction("MaterialScripting::CreateWithMaterial")]
	private static void CreateWithMaterial([Writable] Material self, [NotNull("ArgumentNullException")] Material source)
	{
	}

	[FreeFunction("MaterialScripting::CreateWithString")]
	private static void CreateWithString([Writable] Material self)
	{
	}

	public Material(Shader shader)
	{
	}

	[RequiredByNativeCode]
	public Material(Material source)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Obsolete("Creating materials from shader source string is no longer supported. Use Shader assets instead.", false)]
	public Material(string contents)
	{
	}

	[NativeName("GetFirstPropertyNameIdByAttributeFromScript")]
	private int GetFirstPropertyNameIdByAttribute(ShaderPropertyFlags attributeFlag)
	{
		return 0;
	}

	[NativeName("HasPropertyFromScript")]
	public bool HasProperty(int nameID)
	{
		return false;
	}

	public bool HasProperty(string name)
	{
		return false;
	}

	public void EnableKeyword(string keyword)
	{
	}

	public void DisableKeyword(string keyword)
	{
	}

	[NativeName("GetTag")]
	private string GetTagImpl(string tag, bool currentSubShaderOnly, string defaultValue)
	{
		return null;
	}

	public string GetTag(string tag, bool searchFallbacks)
	{
		return null;
	}

	[FreeFunction("MaterialScripting::SetPass", HasExplicitThis = true)]
	public bool SetPass(int pass)
	{
		return false;
	}

	[FreeFunction("MaterialScripting::GetShaderKeywords", HasExplicitThis = true)]
	private string[] GetShaderKeywords()
	{
		return null;
	}

	[FreeFunction("MaterialScripting::SetShaderKeywords", HasExplicitThis = true)]
	private void SetShaderKeywords(string[] names)
	{
	}

	[NativeName("SetFloatFromScript")]
	private void SetFloatImpl(int name, float value)
	{
	}

	[NativeName("SetColorFromScript")]
	private void SetColorImpl(int name, Color value)
	{
	}

	[NativeName("SetTextureFromScript")]
	private void SetTextureImpl(int name, Texture value)
	{
	}

	[NativeName("GetFloatFromScript")]
	private float GetFloatImpl(int name)
	{
		return 0f;
	}

	[NativeName("GetColorFromScript")]
	private Color GetColorImpl(int name)
	{
		return default;
	}

	[NativeName("GetTextureFromScript")]
	private Texture GetTextureImpl(int name)
	{
		return null;
	}

	[FreeFunction(Name = "MaterialScripting::SetFloatArray", HasExplicitThis = true)]
	private void SetFloatArrayImpl(int name, float[] values, int count)
	{
	}

	[FreeFunction(Name = "MaterialScripting::SetVectorArray", HasExplicitThis = true)]
	private void SetVectorArrayImpl(int name, Vector4[] values, int count)
	{
	}

	[FreeFunction(Name = "MaterialScripting::SetColorArray", HasExplicitThis = true)]
	private void SetColorArrayImpl(int name, Color[] values, int count)
	{
	}

	private void SetFloatArray(int name, float[] values, int count)
	{
	}

	private void SetVectorArray(int name, Vector4[] values, int count)
	{
	}

	private void SetColorArray(int name, Color[] values, int count)
	{
	}

	public void SetInt(string name, int value)
	{
	}

	public void SetInt(int nameID, int value)
	{
	}

	public void SetFloat(string name, float value)
	{
	}

	public void SetFloat(int nameID, float value)
	{
	}

	public void SetColor(string name, Color value)
	{
	}

	public void SetColor(int nameID, Color value)
	{
	}

	public void SetVector(string name, Vector4 value)
	{
	}

	public void SetVector(int nameID, Vector4 value)
	{
	}

	public void SetTexture(string name, Texture value)
	{
	}

	public void SetTexture(int nameID, Texture value)
	{
	}

	public void SetFloatArray(int nameID, float[] values)
	{
	}

	public void SetColorArray(int nameID, Color[] values)
	{
	}

	public void SetVectorArray(int nameID, Vector4[] values)
	{
	}

	public int GetInt(string name)
	{
		return 0;
	}

	public float GetFloat(string name)
	{
		return 0f;
	}

	public float GetFloat(int nameID)
	{
		return 0f;
	}

	public Color GetColor(string name)
	{
		return default;
	}

	public Color GetColor(int nameID)
	{
		return default;
	}

	public Vector4 GetVector(string name)
	{
		return default;
	}

	public Texture GetTexture(string name)
	{
		return null;
	}

	public Texture GetTexture(int nameID)
	{
		return null;
	}

	private void SetColorImpl_Injected(int name, ref Color value)
	{
	}

	private void GetColorImpl_Injected(int name, out Color ret)
	{
		ret = default;
	}
}
