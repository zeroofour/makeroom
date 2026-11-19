namespace Mirror;

internal struct Cell3D
{
	internal readonly int q = 0;

	internal readonly int r = 0;

	internal readonly int layer = 0;

	internal Cell3D(int q, int r, int layer)
	{
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
