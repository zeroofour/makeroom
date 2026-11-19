namespace System.Security.Cryptography;

public readonly struct HashAlgorithmName : IEquatable<HashAlgorithmName>
{
	private readonly string _name;

	public override string ToString()
	{
		return null;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public bool Equals(HashAlgorithmName other)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
