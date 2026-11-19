namespace Mirror.BouncyCastle.Pqc.Crypto.SphincsPlus;

internal class Adrs
{
	internal static uint WOTS_HASH;

	internal static uint WOTS_PK;

	internal static uint TREE;

	internal static uint FORS_TREE;

	internal static uint FORS_PK;

	internal static uint WOTS_PRF;

	internal static uint FORS_PRF;

	internal static int OFFSET_LAYER;

	internal static int OFFSET_TREE;

	internal static int OFFSET_TREE_HGT;

	internal static int OFFSET_TREE_INDEX;

	internal static int OFFSET_TYPE;

	internal static int OFFSET_KP_ADDR;

	internal static int OFFSET_CHAIN_ADDR;

	internal static int OFFSET_HASH_ADDR;

	internal readonly byte[] value;

	internal Adrs()
	{
	}

	internal Adrs(Adrs adrs)
	{
	}

	internal void SetLayerAddress(uint layer)
	{
	}

	internal uint GetLayerAddress()
	{
		return 0u;
	}

	internal void SetTreeAddress(ulong tree)
	{
	}

	internal ulong GetTreeAddress()
	{
		return 0uL;
	}

	internal void SetTreeHeight(uint height)
	{
	}

	internal uint GetTreeHeight()
	{
		return 0u;
	}

	internal void SetTreeIndex(uint index)
	{
	}

	internal uint GetTreeIndex()
	{
		return 0u;
	}

	internal void SetAdrsType(uint adrsType)
	{
	}

	internal void ChangeAdrsType(uint adrsType)
	{
	}

	internal uint GetAdrsType()
	{
		return 0u;
	}

	internal void SetKeyPairAddress(uint keyPairAddr)
	{
	}

	internal uint GetKeyPairAddress()
	{
		return 0u;
	}

	internal void SetHashAddress(uint hashAddr)
	{
	}

	public void SetChainAddress(uint chainAddr)
	{
	}
}
