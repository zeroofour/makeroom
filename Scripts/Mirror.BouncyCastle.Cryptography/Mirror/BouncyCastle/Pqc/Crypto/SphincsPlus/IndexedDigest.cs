namespace Mirror.BouncyCastle.Pqc.Crypto.SphincsPlus;

internal class IndexedDigest
{
	internal ulong idx_tree;

	internal uint idx_leaf;

	internal byte[] digest;

	internal IndexedDigest(ulong idx_tree, uint idx_leaf, byte[] digest)
	{
	}
}
