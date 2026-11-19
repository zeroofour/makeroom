using System;
using UnityEngine.Bindings;

namespace UnityEngine;

[NativeConditional("PLATFORM_ANDROID")]
[StaticAccessor("AndroidJNIBindingsHelpers", StaticAccessorType.DoubleColon)]
[NativeHeader("Modules/AndroidJNI/Public/AndroidJNIBindingsHelpers.h")]
public static class AndroidJNI
{
	[ThreadSafe]
	public static IntPtr FindClass(string name)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public static IntPtr FromReflectedMethod(IntPtr refMethod)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public static IntPtr ExceptionOccurred()
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public static void ExceptionClear()
	{
	}

	[ThreadSafe]
	public static int PushLocalFrame(int capacity)
	{
		return 0;
	}

	[ThreadSafe]
	public static IntPtr PopLocalFrame(IntPtr ptr)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public static IntPtr NewGlobalRef(IntPtr obj)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public static void DeleteGlobalRef(IntPtr obj)
	{
	}

	[ThreadSafe]
	public static IntPtr NewWeakGlobalRef(IntPtr obj)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public static void DeleteWeakGlobalRef(IntPtr obj)
	{
	}

	[ThreadSafe]
	public static IntPtr NewLocalRef(IntPtr obj)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public static void DeleteLocalRef(IntPtr obj)
	{
	}

	[ThreadSafe]
	public static bool IsSameObject(IntPtr obj1, IntPtr obj2)
	{
		return false;
	}

	[ThreadSafe]
	public static IntPtr NewObject(IntPtr clazz, IntPtr methodID, jvalue[] args)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public static IntPtr GetObjectClass(IntPtr obj)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public static IntPtr GetMethodID(IntPtr clazz, string name, string sig)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public static IntPtr GetFieldID(IntPtr clazz, string name, string sig)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public static IntPtr GetStaticMethodID(IntPtr clazz, string name, string sig)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public static IntPtr GetStaticFieldID(IntPtr clazz, string name, string sig)
	{
		return (IntPtr)0;
	}

	public static IntPtr NewString(string chars)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	private static IntPtr NewStringFromStr(string chars)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public static string GetStringChars(IntPtr str)
	{
		return null;
	}

	[ThreadSafe]
	public static string CallStringMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
	{
		return null;
	}

	[ThreadSafe]
	public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public static int CallIntMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
	{
		return 0;
	}

	[ThreadSafe]
	public static bool CallBooleanMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
	{
		return false;
	}

	[ThreadSafe]
	public static short CallShortMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
	{
		return 0;
	}

	[ThreadSafe]
	public static sbyte CallSByteMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
	{
		return 0;
	}

	[ThreadSafe]
	public static char CallCharMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
	{
		return '\0';
	}

	[ThreadSafe]
	public static float CallFloatMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
	{
		return 0f;
	}

	[ThreadSafe]
	public static double CallDoubleMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
	{
		return 0.0;
	}

	[ThreadSafe]
	public static long CallLongMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
	{
		return 0L;
	}

	[ThreadSafe]
	public static string GetStringField(IntPtr obj, IntPtr fieldID)
	{
		return null;
	}

	[ThreadSafe]
	public static IntPtr GetObjectField(IntPtr obj, IntPtr fieldID)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public static bool GetBooleanField(IntPtr obj, IntPtr fieldID)
	{
		return false;
	}

	[ThreadSafe]
	public static sbyte GetSByteField(IntPtr obj, IntPtr fieldID)
	{
		return 0;
	}

	[ThreadSafe]
	public static char GetCharField(IntPtr obj, IntPtr fieldID)
	{
		return '\0';
	}

	[ThreadSafe]
	public static short GetShortField(IntPtr obj, IntPtr fieldID)
	{
		return 0;
	}

	[ThreadSafe]
	public static int GetIntField(IntPtr obj, IntPtr fieldID)
	{
		return 0;
	}

	[ThreadSafe]
	public static long GetLongField(IntPtr obj, IntPtr fieldID)
	{
		return 0L;
	}

	[ThreadSafe]
	public static float GetFloatField(IntPtr obj, IntPtr fieldID)
	{
		return 0f;
	}

	[ThreadSafe]
	public static double GetDoubleField(IntPtr obj, IntPtr fieldID)
	{
		return 0.0;
	}

	[ThreadSafe]
	public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
	{
		return null;
	}

	[ThreadSafe]
	public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public static int CallStaticIntMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
	{
		return 0;
	}

	[ThreadSafe]
	public static bool CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
	{
		return false;
	}

	[ThreadSafe]
	public static short CallStaticShortMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
	{
		return 0;
	}

	[ThreadSafe]
	public static sbyte CallStaticSByteMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
	{
		return 0;
	}

	[ThreadSafe]
	public static char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
	{
		return '\0';
	}

	[ThreadSafe]
	public static float CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
	{
		return 0f;
	}

	[ThreadSafe]
	public static double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
	{
		return 0.0;
	}

	[ThreadSafe]
	public static long CallStaticLongMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
	{
		return 0L;
	}

	[ThreadSafe]
	public static string GetStaticStringField(IntPtr clazz, IntPtr fieldID)
	{
		return null;
	}

	[ThreadSafe]
	public static IntPtr GetStaticObjectField(IntPtr clazz, IntPtr fieldID)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public static bool GetStaticBooleanField(IntPtr clazz, IntPtr fieldID)
	{
		return false;
	}

	[ThreadSafe]
	public static sbyte GetStaticSByteField(IntPtr clazz, IntPtr fieldID)
	{
		return 0;
	}

	[ThreadSafe]
	public static char GetStaticCharField(IntPtr clazz, IntPtr fieldID)
	{
		return '\0';
	}

	[ThreadSafe]
	public static short GetStaticShortField(IntPtr clazz, IntPtr fieldID)
	{
		return 0;
	}

	[ThreadSafe]
	public static int GetStaticIntField(IntPtr clazz, IntPtr fieldID)
	{
		return 0;
	}

	[ThreadSafe]
	public static long GetStaticLongField(IntPtr clazz, IntPtr fieldID)
	{
		return 0L;
	}

	[ThreadSafe]
	public static float GetStaticFloatField(IntPtr clazz, IntPtr fieldID)
	{
		return 0f;
	}

	[ThreadSafe]
	public static double GetStaticDoubleField(IntPtr clazz, IntPtr fieldID)
	{
		return 0.0;
	}

	[ThreadSafe]
	public static IntPtr ToBooleanArray(bool[] array)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	[Obsolete("AndroidJNI.ToByteArray is obsolete. Use AndroidJNI.ToSByteArray method instead")]
	public static IntPtr ToByteArray(byte[] array)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public static IntPtr ToSByteArray([Unmarshalled] sbyte[] array)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public static IntPtr ToCharArray([Unmarshalled] char[] array)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public static IntPtr ToShortArray([Unmarshalled] short[] array)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public static IntPtr ToIntArray([Unmarshalled] int[] array)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public static IntPtr ToLongArray([Unmarshalled] long[] array)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public static IntPtr ToFloatArray([Unmarshalled] float[] array)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public static IntPtr ToDoubleArray([Unmarshalled] double[] array)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public static IntPtr ToObjectArray(IntPtr[] array, IntPtr arrayClass)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public static bool[] FromBooleanArray(IntPtr array)
	{
		return null;
	}

	[Obsolete("AndroidJNI.FromByteArray is obsolete. Use AndroidJNI.FromSByteArray method instead")]
	[ThreadSafe]
	public static byte[] FromByteArray(IntPtr array)
	{
		return null;
	}

	[ThreadSafe]
	public static sbyte[] FromSByteArray(IntPtr array)
	{
		return null;
	}

	[ThreadSafe]
	public static char[] FromCharArray(IntPtr array)
	{
		return null;
	}

	[ThreadSafe]
	public static short[] FromShortArray(IntPtr array)
	{
		return null;
	}

	[ThreadSafe]
	public static int[] FromIntArray(IntPtr array)
	{
		return null;
	}

	[ThreadSafe]
	public static long[] FromLongArray(IntPtr array)
	{
		return null;
	}

	[ThreadSafe]
	public static float[] FromFloatArray(IntPtr array)
	{
		return null;
	}

	[ThreadSafe]
	public static double[] FromDoubleArray(IntPtr array)
	{
		return null;
	}

	[ThreadSafe]
	public static int GetArrayLength(IntPtr array)
	{
		return 0;
	}

	[ThreadSafe]
	public static IntPtr NewObjectArray(int size, IntPtr clazz, IntPtr obj)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public static IntPtr GetObjectArrayElement(IntPtr array, int index)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public static void SetObjectArrayElement(IntPtr array, int index, IntPtr obj)
	{
	}
}
