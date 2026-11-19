using System;

namespace Mirror.Examples.PickupsDropsChilds;

[Serializable]
public struct EquippedItemConfig : IEquatable<EquippedItemConfig>
{
	public byte usages = 0;

	public byte maxUsages = 0;

	public EquippedItemConfig(byte maxUsages)
	{
	}

	public EquippedItemConfig(byte usages, byte maxUsages)
	{
	}

	public void Use()
	{
	}

	public void AddUsages(byte usages)
	{
	}

	public void ResetUsages()
	{
	}

	public void ResetUsages(byte usages)
	{
	}

	public bool Equals(EquippedItemConfig other)
	{
		return false;
	}

	public override string ToString()
	{
		return null;
	}
}
