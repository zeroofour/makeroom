using System;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[NativeClass("Matrix4x4f")]
[Il2CppEagerStaticClassConstruction]
[NativeType(Header = "Runtime/Math/Matrix4x4.h")]
[NativeHeader("Runtime/Math/MathScripting.h")]
[RequiredByNativeCode(Optional = true, GenerateProxy = true)]
public struct Matrix4x4 : IEquatable<Matrix4x4>, IFormattable
{
	[NativeName("m_Data[0]")]
	public float m00 = 0f;

	[NativeName("m_Data[1]")]
	public float m10 = 0f;

	[NativeName("m_Data[2]")]
	public float m20 = 0f;

	[NativeName("m_Data[3]")]
	public float m30 = 0f;

	[NativeName("m_Data[4]")]
	public float m01 = 0f;

	[NativeName("m_Data[5]")]
	public float m11 = 0f;

	[NativeName("m_Data[6]")]
	public float m21 = 0f;

	[NativeName("m_Data[7]")]
	public float m31 = 0f;

	[NativeName("m_Data[8]")]
	public float m02 = 0f;

	[NativeName("m_Data[9]")]
	public float m12 = 0f;

	[NativeName("m_Data[10]")]
	public float m22 = 0f;

	[NativeName("m_Data[11]")]
	public float m32 = 0f;

	[NativeName("m_Data[12]")]
	public float m03 = 0f;

	[NativeName("m_Data[13]")]
	public float m13 = 0f;

	[NativeName("m_Data[14]")]
	public float m23 = 0f;

	[NativeName("m_Data[15]")]
	public float m33 = 0f;

	private static readonly Matrix4x4 zeroMatrix;

	private static readonly Matrix4x4 identityMatrix;

	public FrustumPlanes decomposeProjection => default;

	public Matrix4x4 inverse => default;

	public float this[int row, int column]
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return 0f;
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		set
		{
		}
	}

	public float this[int index]
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public static Matrix4x4 identity
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default;
		}
	}

	[ThreadSafe]
	private FrustumPlanes DecomposeProjection()
	{
		return default;
	}

	[FreeFunction("MatrixScripting::TRS", IsThreadSafe = true)]
	public static Matrix4x4 TRS(Vector3 pos, Quaternion q, Vector3 s)
	{
		return default;
	}

	[FreeFunction("MatrixScripting::Inverse3DAffine", IsThreadSafe = true)]
	public static bool Inverse3DAffine(Matrix4x4 input, ref Matrix4x4 result)
	{
		return false;
	}

	[FreeFunction("MatrixScripting::Inverse", IsThreadSafe = true)]
	public static Matrix4x4 Inverse(Matrix4x4 m)
	{
		return default;
	}

	[FreeFunction("MatrixScripting::Ortho", IsThreadSafe = true)]
	public static Matrix4x4 Ortho(float left, float right, float bottom, float top, float zNear, float zFar)
	{
		return default;
	}

	[FreeFunction("MatrixScripting::Frustum", IsThreadSafe = true)]
	public static Matrix4x4 Frustum(float left, float right, float bottom, float top, float zNear, float zFar)
	{
		return default;
	}

	public static Matrix4x4 Frustum(FrustumPlanes fp)
	{
		return default;
	}

	public Matrix4x4(Vector4 column0, Vector4 column1, Vector4 column2, Vector4 column3)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public override int GetHashCode()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public override bool Equals(object other)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool Equals(Matrix4x4 other)
	{
		return false;
	}

	public static Matrix4x4 operator *(Matrix4x4 lhs, Matrix4x4 rhs)
	{
		return default;
	}

	public Vector4 GetColumn(int index)
	{
		return default;
	}

	public Vector4 GetRow(int index)
	{
		return default;
	}

	public void SetRow(int index, Vector4 row)
	{
	}

	public Vector3 MultiplyPoint(Vector3 point)
	{
		return default;
	}

	public Vector3 MultiplyPoint3x4(Vector3 point)
	{
		return default;
	}

	public Vector3 MultiplyVector(Vector3 vector)
	{
		return default;
	}

	public override string ToString()
	{
		return null;
	}

	public string ToString(string format, IFormatProvider formatProvider)
	{
		return null;
	}

	private static void DecomposeProjection_Injected(ref Matrix4x4 _unity_self, out FrustumPlanes ret)
	{
		ret = default;
	}

	private static void TRS_Injected(ref Vector3 pos, ref Quaternion q, ref Vector3 s, out Matrix4x4 ret)
	{
		ret = default;
	}

	private static bool Inverse3DAffine_Injected(ref Matrix4x4 input, ref Matrix4x4 result)
	{
		return false;
	}

	private static void Inverse_Injected(ref Matrix4x4 m, out Matrix4x4 ret)
	{
		ret = default;
	}

	private static void Ortho_Injected(float left, float right, float bottom, float top, float zNear, float zFar, out Matrix4x4 ret)
	{
		ret = default;
	}

	private static void Frustum_Injected(float left, float right, float bottom, float top, float zNear, float zFar, out Matrix4x4 ret)
	{
		ret = default;
	}
}
