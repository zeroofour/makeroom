namespace System.Reflection;

[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true, Inherited = false)]
public sealed class AssemblyMetadataAttribute : Attribute
{
	private readonly string Key;

	private readonly string Value;

	public AssemblyMetadataAttribute(string key, string value)
	{
	}
}
