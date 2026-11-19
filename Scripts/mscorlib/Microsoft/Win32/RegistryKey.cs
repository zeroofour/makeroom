using System;
using System.Text;
using Microsoft.Win32.SafeHandles;

namespace Microsoft.Win32;

public sealed class RegistryKey : MarshalByRefObject, IDisposable
{
	[Flags]
	private enum StateFlags
	{
		Dirty = 1,
		SystemKey = 2,
		WriteAccess = 4,
		PerfData = 8
	}

	internal static readonly IntPtr HKEY_CLASSES_ROOT;

	internal static readonly IntPtr HKEY_CURRENT_USER;

	internal static readonly IntPtr HKEY_LOCAL_MACHINE;

	internal static readonly IntPtr HKEY_USERS;

	internal static readonly IntPtr HKEY_PERFORMANCE_DATA;

	internal static readonly IntPtr HKEY_CURRENT_CONFIG;

	internal static readonly IntPtr HKEY_DYN_DATA;

	private static readonly string[] s_hkeyNames;

	private SafeRegistryHandle _hkey;

	private string _keyName;

	private bool _remoteKey;

	private StateFlags _state;

	private RegistryKeyPermissionCheck _checkMode;

	private RegistryView _regView;

	private void ClosePerfDataKey()
	{
	}

	private static RegistryKey OpenBaseKeyCore(RegistryHive hKeyHive, RegistryView view)
	{
		return null;
	}

	private RegistryKey InternalOpenSubKeyCore(string name, bool writable, bool throwOnPermissionFailure)
	{
		return null;
	}

	private int InternalSubKeyCountCore()
	{
		return 0;
	}

	private string[] InternalGetSubKeyNamesCore(int subkeys)
	{
		return null;
	}

	private object InternalGetValueCore(string name, object defaultValue, bool doNotExpand)
	{
		return null;
	}

	private void Win32Error(int errorCode, string str)
	{
	}

	private static int GetRegistryKeyAccess(bool isWritable)
	{
		return 0;
	}

	private RegistryKey(SafeRegistryHandle hkey, bool writable, bool systemkey, bool remoteKey, bool isPerfData, RegistryView view)
	{
	}

	public void Dispose()
	{
	}

	public static RegistryKey OpenBaseKey(RegistryHive hKey, RegistryView view)
	{
		return null;
	}

	public RegistryKey OpenSubKey(string name, bool writable)
	{
		return null;
	}

	private int InternalSubKeyCount()
	{
		return 0;
	}

	public string[] GetSubKeyNames()
	{
		return null;
	}

	private string[] InternalGetSubKeyNames()
	{
		return null;
	}

	public object GetValue(string name, object defaultValue, RegistryValueOptions options)
	{
		return null;
	}

	private object InternalGetValue(string name, object defaultValue, bool doNotExpand, bool checkSecurity)
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}

	private static string FixupName(string name)
	{
		return null;
	}

	private static void FixupPath(StringBuilder path)
	{
	}

	private void EnsureNotDisposed()
	{
	}

	private RegistryKeyPermissionCheck GetSubKeyPermissionCheck(bool subkeyWritable)
	{
		return RegistryKeyPermissionCheck.Default;
	}

	private static void ValidateKeyName(string name)
	{
	}

	private static void ValidateKeyView(RegistryView view)
	{
	}

	private bool IsSystemKey()
	{
		return false;
	}

	private bool IsPerfDataKey()
	{
		return false;
	}
}
