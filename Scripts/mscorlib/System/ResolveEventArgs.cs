using System.Reflection;

namespace System;

public class ResolveEventArgs : EventArgs
{
	private readonly string Name;

	private readonly Assembly RequestingAssembly;

	public ResolveEventArgs(string name)
	{
	}

	public ResolveEventArgs(string name, Assembly requestingAssembly)
	{
	}
}
