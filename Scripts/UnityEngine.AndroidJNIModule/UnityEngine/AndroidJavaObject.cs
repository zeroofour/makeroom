using System;

namespace UnityEngine;

public class AndroidJavaObject : IDisposable
{
	private static bool enableDebugPrints;

	internal GlobalJavaObjectRef m_jobject;

	internal GlobalJavaObjectRef m_jclass;

	public AndroidJavaObject(string className, params object[] args)
	{
	}

	public void Dispose()
	{
	}

	public FieldType Get<FieldType>(string fieldName)
	{
		return default;
	}

	public FieldType GetStatic<FieldType>(string fieldName)
	{
		return default;
	}

	public IntPtr GetRawObject()
	{
		return (IntPtr)0;
	}

	public IntPtr GetRawClass()
	{
		return (IntPtr)0;
	}

	public ReturnType Call<ReturnType>(string methodName, params object[] args)
	{
		return default;
	}

	public ReturnType CallStatic<ReturnType>(string methodName, params object[] args)
	{
		return default;
	}

	protected void DebugPrint(string msg)
	{
	}

	private void _AndroidJavaObject(string className, params object[] args)
	{
	}

	internal AndroidJavaObject(IntPtr jobject)
	{
	}

	internal AndroidJavaObject()
	{
	}

	~AndroidJavaObject()
	{
	}

	protected virtual void Dispose(bool disposing)
	{
	}

	protected ReturnType _Call<ReturnType>(string methodName, params object[] args)
	{
		return default;
	}

	protected FieldType _Get<FieldType>(string fieldName)
	{
		return default;
	}

	protected ReturnType _CallStatic<ReturnType>(string methodName, params object[] args)
	{
		return default;
	}

	protected FieldType _GetStatic<FieldType>(string fieldName)
	{
		return default;
	}

	internal static AndroidJavaObject AndroidJavaObjectDeleteLocalRef(IntPtr jobject)
	{
		return null;
	}

	internal static AndroidJavaClass AndroidJavaClassDeleteLocalRef(IntPtr jclass)
	{
		return null;
	}

	internal static ReturnType FromJavaArrayDeleteLocalRef<ReturnType>(IntPtr jobject)
	{
		return default;
	}

	protected IntPtr _GetRawObject()
	{
		return (IntPtr)0;
	}

	protected IntPtr _GetRawClass()
	{
		return (IntPtr)0;
	}
}
