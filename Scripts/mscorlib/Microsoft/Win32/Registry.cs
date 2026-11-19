using System;

namespace Microsoft.Win32;

public static class Registry
{
	public static readonly RegistryKey CurrentUser;

	public static readonly RegistryKey LocalMachine;

	public static readonly RegistryKey ClassesRoot;

	public static readonly RegistryKey Users;

	public static readonly RegistryKey PerformanceData;

	public static readonly RegistryKey CurrentConfig;

	[Obsolete("Use PerformanceData instead")]
	public static readonly RegistryKey DynData;
}
