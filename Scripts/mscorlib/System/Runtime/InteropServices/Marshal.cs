using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;

namespace System.Runtime.InteropServices;

public static class Marshal
{
	internal class MarshalerInstanceKeyComparer : IEqualityComparer<ValueTuple<Type, string>>
	{
		public bool Equals(ValueTuple<Type, string> lhs, ValueTuple<Type, string> rhs)
		{
			return false;
		}

		public int GetHashCode(ValueTuple<Type, string> key)
		{
			return 0;
		}
	}

	public static readonly int SystemMaxDBCSCharSize;

	public static readonly int SystemDefaultCharSize;

	internal static Dictionary<ValueTuple<Type, string>, ICustomMarshaler> MarshalerInstanceCache;

	internal static readonly object MarshalerInstanceCacheLock;

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	public static IntPtr AllocHGlobal(IntPtr cb)
	{
		return (IntPtr)0;
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	public static IntPtr AllocHGlobal(int cb)
	{
		return (IntPtr)0;
	}

	internal static void copy_to_unmanaged(Array source, int startIndex, IntPtr destination, int length)
	{
	}

	private unsafe static void copy_to_unmanaged_fixed(Array source, int startIndex, IntPtr destination, int length, void* fixed_source_element)
	{
	}

	private static bool skip_fixed(Array array, int startIndex)
	{
		return false;
	}

	internal static void copy_to_unmanaged(byte[] source, int startIndex, IntPtr destination, int length)
	{
	}

	public static void Copy(byte[] source, int startIndex, IntPtr destination, int length)
	{
	}

	public static void Copy(short[] source, int startIndex, IntPtr destination, int length)
	{
	}

	public static void Copy(int[] source, int startIndex, IntPtr destination, int length)
	{
	}

	public static void Copy(IntPtr[] source, int startIndex, IntPtr destination, int length)
	{
	}

	internal static void copy_from_unmanaged(IntPtr source, int startIndex, Array destination, int length)
	{
	}

	private unsafe static void copy_from_unmanaged_fixed(IntPtr source, int startIndex, Array destination, int length, void* fixed_destination_element)
	{
	}

	public static void Copy(IntPtr source, byte[] destination, int startIndex, int length)
	{
	}

	public static void Copy(IntPtr source, char[] destination, int startIndex, int length)
	{
	}

	public static void Copy(IntPtr source, int[] destination, int startIndex, int length)
	{
	}

	public static void Copy(IntPtr source, IntPtr[] destination, int startIndex, int length)
	{
	}

	public static void FreeBSTR(IntPtr ptr)
	{
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public static void FreeHGlobal(IntPtr hglobal)
	{
	}

	private static void ClearUnicode(IntPtr ptr)
	{
	}

	public static void ZeroFreeGlobalAllocUnicode(IntPtr s)
	{
	}

	public static int GetHRForException(Exception e)
	{
		return 0;
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public static int GetLastWin32Error()
	{
		return 0;
	}

	public static IntPtr OffsetOf(Type t, string fieldName)
	{
		return (IntPtr)0;
	}

	public static IntPtr OffsetOf<T>(string fieldName)
	{
		return (IntPtr)0;
	}

	public static string PtrToStringAnsi(IntPtr ptr)
	{
		return null;
	}

	public static string PtrToStringAnsi(IntPtr ptr, int len)
	{
		return null;
	}

	public static string PtrToStringUni(IntPtr ptr)
	{
		return null;
	}

	public static string PtrToStringUni(IntPtr ptr, int len)
	{
		return null;
	}

	[ComVisible(true)]
	public static object PtrToStructure(IntPtr ptr, Type structureType)
	{
		return null;
	}

	public static T PtrToStructure<T>(IntPtr ptr)
	{
		return default;
	}

	public static byte ReadByte(IntPtr ptr)
	{
		return 0;
	}

	public static short ReadInt16(IntPtr ptr, int ofs)
	{
		return 0;
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public static int ReadInt32(IntPtr ptr, int ofs)
	{
		return 0;
	}

	public static long ReadInt64(IntPtr ptr, int ofs)
	{
		return 0L;
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public static IntPtr ReadIntPtr(IntPtr ptr, int ofs)
	{
		return (IntPtr)0;
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	private static int ReleaseInternal(IntPtr pUnk)
	{
		return 0;
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public static int Release(IntPtr pUnk)
	{
		return 0;
	}

	public static int SizeOf(Type t)
	{
		return 0;
	}

	public static int SizeOf<T>()
	{
		return 0;
	}

	private unsafe static IntPtr StringToHGlobalAnsi(char* s, int length)
	{
		return (IntPtr)0;
	}

	public static IntPtr StringToHGlobalAnsi(string s)
	{
		return (IntPtr)0;
	}

	private unsafe static IntPtr StringToHGlobalUni(char* s, int length)
	{
		return (IntPtr)0;
	}

	public static IntPtr StringToHGlobalUni(string s)
	{
		return (IntPtr)0;
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	[ComVisible(true)]
	public static void StructureToPtr(object structure, IntPtr ptr, bool fDeleteOld)
	{
	}

	public static void StructureToPtr<T>(T structure, IntPtr ptr, bool fDeleteOld)
	{
	}

	public static IntPtr UnsafeAddrOfPinnedArrayElement(Array arr, int index)
	{
		return (IntPtr)0;
	}

	public static IntPtr UnsafeAddrOfPinnedArrayElement<T>(T[] arr, int index)
	{
		return (IntPtr)0;
	}

	public static void WriteInt16(IntPtr ptr, int ofs, short val)
	{
	}

	public static void WriteInt32(IntPtr ptr, int val)
	{
	}

	public static void WriteInt64(IntPtr ptr, long val)
	{
	}

	public static void WriteIntPtr(IntPtr ptr, IntPtr val)
	{
	}

	private static IntPtr GetFunctionPointerForDelegateInternal(Delegate d)
	{
		return (IntPtr)0;
	}

	public static IntPtr GetFunctionPointerForDelegate<TDelegate>(TDelegate d)
	{
		return (IntPtr)0;
	}

	internal static ICustomMarshaler GetCustomMarshalerInstance(Type type, string cookie)
	{
		return null;
	}
}
