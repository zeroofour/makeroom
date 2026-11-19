using System;
using UnityEngine.Bindings;

namespace UnityEngine;

[NativeHeader("Runtime/Math/SphericalHarmonicsL2.h")]
[NativeHeader("Runtime/Shaders/ComputeShader.h")]
[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
[NativeHeader("Runtime/Shaders/ShaderPropertySheet.h")]
public sealed class MaterialPropertyBlock
{
	internal IntPtr m_Ptr;

	[NativeName("SetFloatFromScript")]
	[ThreadSafe]
	private void SetFloatImpl(int name, float value)
	{
	}

	[NativeName("SetVectorFromScript")]
	[ThreadSafe]
	private void SetVectorImpl(int name, Vector4 value)
	{
	}

	[ThreadSafe]
	[NativeName("SetColorFromScript")]
	private void SetColorImpl(int name, Color value)
	{
	}

	[ThreadSafe]
	[NativeName("SetMatrixFromScript")]
	private void SetMatrixImpl(int name, Matrix4x4 value)
	{
	}

	[NativeName("SetTextureFromScript")]
	[ThreadSafe]
	private void SetTextureImpl(int name, [NotNull("ArgumentNullException")] Texture value)
	{
	}

	[NativeName("SetBufferFromScript")]
	[ThreadSafe]
	private void SetBufferImpl(int name, ComputeBuffer value)
	{
	}

	[ThreadSafe]
	[NativeName("SetFloatArrayFromScript")]
	private void SetFloatArrayImpl(int name, float[] values, int count)
	{
	}

	[ThreadSafe]
	[NativeName("SetVectorArrayFromScript")]
	private void SetVectorArrayImpl(int name, Vector4[] values, int count)
	{
	}

	[NativeMethod(Name = "MaterialPropertyBlockScripting::Create", IsFreeFunction = true)]
	private static IntPtr CreateImpl()
	{
		return (IntPtr)0;
	}

	[NativeMethod(Name = "MaterialPropertyBlockScripting::Destroy", IsFreeFunction = true, IsThreadSafe = true)]
	private static void DestroyImpl(IntPtr mpb)
	{
	}

	[ThreadSafe]
	private void Clear(bool keepMemory)
	{
	}

	public void Clear()
	{
	}

	private void SetFloatArray(int name, float[] values, int count)
	{
	}

	private void SetVectorArray(int name, Vector4[] values, int count)
	{
	}

	~MaterialPropertyBlock()
	{
	}

	private void Dispose()
	{
	}

	public void SetFloat(string name, float value)
	{
	}

	public void SetFloat(int nameID, float value)
	{
	}

	public void SetVector(string name, Vector4 value)
	{
	}

	public void SetVector(int nameID, Vector4 value)
	{
	}

	public void SetColor(string name, Color value)
	{
	}

	public void SetColor(int nameID, Color value)
	{
	}

	public void SetMatrix(int nameID, Matrix4x4 value)
	{
	}

	public void SetBuffer(int nameID, ComputeBuffer value)
	{
	}

	public void SetTexture(string name, Texture value)
	{
	}

	public void SetTexture(int nameID, Texture value)
	{
	}

	public void SetFloatArray(string name, float[] values)
	{
	}

	public void SetVectorArray(int nameID, Vector4[] values)
	{
	}

	private void SetVectorImpl_Injected(int name, ref Vector4 value)
	{
	}

	private void SetColorImpl_Injected(int name, ref Color value)
	{
	}

	private void SetMatrixImpl_Injected(int name, ref Matrix4x4 value)
	{
	}
}
