namespace Mirror.BouncyCastle.Pqc.Crypto.Picnic;

internal sealed class Tree
{
	private static int MAX_SEED_SIZE_BYTES;

	private uint MAX_AUX_BYTES;

	private uint depth;

	internal byte[][] nodes;

	private int dataSize;

	private bool[] haveNode;

	private byte[] exists;

	private uint numNodes;

	private uint numLeaves;

	private PicnicEngine engine;

	internal byte[][] GetLeaves()
	{
		return null;
	}

	internal uint GetLeavesOffset()
	{
		return 0u;
	}

	internal Tree(PicnicEngine engine, uint numLeaves, int dataSize)
	{
	}

	internal void BuildMerkleTree(byte[][] leafData, byte[] salt)
	{
	}

	internal int VerifyMerkleTree(byte[][] leafData, byte[] salt)
	{
		return 0;
	}

	internal int ReconstructSeeds(uint[] hideList, uint hideListSize, byte[] input, uint inputLen, byte[] salt, uint repIndex)
	{
		return 0;
	}

	internal byte[] OpenMerkleTree(uint[] missingLeaves, uint missingLeavesSize, int[] outputSizeBytes)
	{
		return null;
	}

	private uint[] GetRevealedNodes(uint[] hideList, uint hideListSize, uint[] outputSize)
	{
		return null;
	}

	private uint GetSibling(uint node)
	{
		return 0u;
	}

	private bool IsLeafNode(uint node)
	{
		return false;
	}

	private bool HasSibling(uint node)
	{
		return false;
	}

	internal uint RevealSeedsSize(uint[] hideList, uint hideListSize)
	{
		return 0u;
	}

	internal int RevealSeeds(uint[] hideList, uint hideListSize, byte[] output, int outputSize)
	{
		return 0;
	}

	internal uint OpenMerkleTreeSize(uint[] missingLeaves, uint missingLeavesSize)
	{
		return 0u;
	}

	private uint[] GetRevealedMerkleNodes(uint[] missingLeaves, uint missingLeavesSize, uint[] outputSize)
	{
		return null;
	}

	private bool Contains(uint[] list, uint len, uint value)
	{
		return false;
	}

	private void ComputeParentHash(uint child, byte[] salt)
	{
	}

	internal byte[] GetLeaf(uint leafIndex)
	{
		return null;
	}

	internal int AddMerkleNodes(uint[] missingLeaves, uint missingLeavesSize, byte[] input, uint inputSize)
	{
		return 0;
	}

	internal void GenerateSeeds(byte[] rootSeed, byte[] salt, uint repIndex)
	{
	}

	private void ExpandSeeds(byte[] salt, uint repIndex)
	{
	}

	private void HashSeed(byte[] digest_arr, byte[] inputSeed, byte[] salt, byte hashPrefix, uint repIndex, uint nodeIndex)
	{
	}

	private bool IsLeftChild(uint node)
	{
		return false;
	}

	private bool HasRightChild(uint node)
	{
		return false;
	}

	private uint GetParent(uint node)
	{
		return 0u;
	}

	private bool Exists(uint i)
	{
		return false;
	}
}
