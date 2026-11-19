using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Pqc.Crypto.Picnic;

internal sealed class PicnicEngine
{
	internal static readonly int saltSizeBytes;

	private static readonly uint MAX_DIGEST_SIZE;

	private static readonly int WORD_SIZE_BITS;

	private static readonly uint LOWMC_MAX_STATE_SIZE;

	internal static readonly uint LOWMC_MAX_WORDS;

	internal static readonly uint LOWMC_MAX_KEY_BITS;

	internal static readonly uint LOWMC_MAX_AND_GATES;

	private static readonly uint MAX_AUX_BYTES;

	private static readonly uint PICNIC_MAX_LOWMC_BLOCK_SIZE;

	private static readonly uint PICNIC_MAX_PUBLICKEY_SIZE;

	private static readonly uint PICNIC_MAX_PRIVATEKEY_SIZE;

	private static readonly uint TRANSFORM_FS;

	private static readonly uint TRANSFORM_UR;

	private static readonly uint TRANSFORM_INVALID;

	private int CRYPTO_SECRETKEYBYTES;

	private int CRYPTO_PUBLICKEYBYTES;

	private int CRYPTO_BYTES;

	internal int numRounds;

	private int numSboxes;

	internal int stateSizeBits;

	internal int stateSizeBytes;

	internal int stateSizeWords;

	internal int andSizeBytes;

	private int UnruhGWithoutInputBytes;

	internal int UnruhGWithInputBytes;

	internal int numMPCRounds;

	internal int numOpenedRounds;

	internal int numMPCParties;

	internal int seedSizeBytes;

	internal int digestSizeBytes;

	internal int pqSecurityLevel;

	private uint transform;

	private int parameters;

	internal IXof digest;

	private int signatureLength;

	internal LowmcConstants _lowmcConstants;

	internal int GetSecretKeySize()
	{
		return 0;
	}

	internal int GetPublicKeySize()
	{
		return 0;
	}

	internal int GetSignatureSize(int messageLength)
	{
		return 0;
	}

	internal int GetTrueSignatureSize()
	{
		return 0;
	}

	internal PicnicEngine(int picnicParams, LowmcConstants lowmcConstants)
	{
	}

	internal bool crypto_sign_open(byte[] m, byte[] sm, byte[] pk)
	{
		return false;
	}

	private int picnic_verify(byte[] pk, byte[] message, byte[] signature, uint sigLen)
	{
		return 0;
	}

	private int Verify(Signature sig, uint[] pubKey, uint[] plaintext, byte[] message)
	{
		return 0;
	}

	private bool VerifyProof(Signature.Proof proof, View view1, View view2, int challenge, byte[] salt, uint roundNumber, byte[] tmp, uint[] plaintext, Tape tape)
	{
		return false;
	}

	private void mpc_LowMC_verify(View view1, View view2, Tape tapes, uint[] tmp, uint[] plaintext, int challenge)
	{
	}

	private void mpc_substitution_verify(uint[] state, Tape rand, View view1, View view2)
	{
	}

	private void mpc_AND_verify(uint[] in1, uint[] in2, uint[] output, Tape rand, View view1, View view2)
	{
	}

	private void mpc_xor_constant_verify(uint[] state, uint[] input, int inOffset, int length, int challenge)
	{
	}

	private int DeserializeSignature(Signature sig, byte[] sigBytes, uint sigBytesLen, int sigBytesOffset)
	{
		return 0;
	}

	private int CountNonZeroChallenges(byte[] challengeBits, int challengeBitsOffset)
	{
		return 0;
	}

	private void picnic_read_public_key(uint[] ciphertext, uint[] plaintext, byte[] pk)
	{
	}

	private int verify_picnic3(Signature2 sig, uint[] pubKey, uint[] plaintext, byte[] message)
	{
		return 0;
	}

	private int DeserializeSignature2(Signature2 sig, byte[] sigBytes, uint sigLen, int sigBytesOffset)
	{
		return 0;
	}

	private bool ArePaddingBitsZero(byte[] data, int bitLength)
	{
		return false;
	}

	private bool ArePaddingBitsZero(uint[] data, int bitLength)
	{
		return false;
	}

	internal void crypto_sign(byte[] sm, byte[] m, byte[] sk)
	{
	}

	private bool picnic_sign(byte[] sk, byte[] message, byte[] signature)
	{
		return false;
	}

	private int SerializeSignature(Signature sig, byte[] sigBytes, int sigOffset)
	{
		return 0;
	}

	private static int GetChallenge(byte[] challenge, int round)
	{
		return 0;
	}

	private int SerializeSignature2(Signature2 sig, byte[] sigBytes, int sigOffset)
	{
		return 0;
	}

	private int sign_picnic1(uint[] privateKey, uint[] pubKey, uint[] plaintext, byte[] message, Signature sig)
	{
		return 0;
	}

	private void Prove(Signature.Proof proof, int challenge, byte[] seeds, int seedsOffset, View[] views, byte[][] commitments, byte[][] gs)
	{
	}

	private void H3(uint[] circuitOutput, uint[] plaintext, View[][] views, byte[][][] AS, byte[] challengeBits, byte[] salt, byte[] message, byte[][][] gs)
	{
	}

	private void H3(uint[] circuitOutput, uint[] plaintext, uint[][][] viewOutputs, byte[][][] AS, byte[] challengeBits, byte[] salt, byte[] message, byte[][][] gs)
	{
	}

	private void ImplH3(uint[] circuitOutput, uint[] plaintext, byte[][][] AS, byte[] challengeBits, byte[] salt, byte[] message, byte[][][] gs)
	{
	}

	private void SetChallenge(byte[] challenge, int round, uint trit)
	{
	}

	private void G(int viewNumber, byte[] seed, int seedOffset, View view, byte[] output)
	{
	}

	private void mpc_LowMC(Tape tapes, View[] views, uint[] plaintext, uint[] slab)
	{
	}

	private void Commit(byte[] seed, int seedOffset, View view, byte[] hash)
	{
	}

	private void mpc_substitution(uint[] state, Tape rand, View[] views)
	{
	}

	private void mpc_AND(uint[] in1, uint[] in2, uint[] output, Tape rand, View[] views)
	{
	}

	private void mpc_xor(uint[] state, uint[] input, int players)
	{
	}

	private void mpc_matrix_mul(uint[] output, int outputOffset, uint[] state, int stateOffset, uint[] matrix, int matrixOffset, int players)
	{
	}

	private void mpc_xor_constant(uint[] state, int stateOffset, uint[] input, int inOffset, int len)
	{
	}

	private bool CreateRandomTape(byte[] seed, int seedOffset, byte[] salt, uint roundNumber, uint playerNumber, byte[] tape, int tapeLen)
	{
		return false;
	}

	private byte[] ComputeSeeds(uint[] privateKey, uint[] publicKey, uint[] plaintext, byte[] message)
	{
		return null;
	}

	private bool sign_picnic3(uint[] privateKey, uint[] pubKey, uint[] plaintext, byte[] message, Signature2 sig)
	{
		return false;
	}

	private static int IndexOf(uint[] list, int len, uint value)
	{
		return 0;
	}

	private uint[] GetMissingLeavesList(uint[] challengeC)
	{
		return null;
	}

	private void HCP(byte[] challengeHash, uint[] challengeC, uint[] challengeP, byte[][] Ch, byte[] hCv, byte[] salt, uint[] pubKey, uint[] plaintext, byte[] message)
	{
	}

	private static int BitsToChunks(int chunkLenBits, byte[] input, int inputLen, uint[] chunks)
	{
		return 0;
	}

	private static uint AppendUnique(uint[] list, uint value, uint position)
	{
		return 0u;
	}

	private void ExpandChallengeHash(byte[] challengeHash, uint[] challengeC, uint[] challengeP)
	{
	}

	private void commit_h(byte[] digest_arr, byte[][] C)
	{
	}

	private void commit_v(byte[] digest_arr, byte[] input, Msg msg)
	{
	}

	private int SimulateOnline(uint[] maskedKey, Tape tape, uint[] tmp_shares, Msg msg, uint[] plaintext, uint[] pubKey)
	{
		return 0;
	}

	private void CreateRandomTapes(Tape tape, byte[][] seeds, uint seedsOffset, byte[] salt, uint t)
	{
	}

	private static bool SubarrayEquals(byte[] a, byte[] b, int length)
	{
		return false;
	}

	private static bool SubarrayEquals(uint[] a, uint[] b, int length)
	{
		return false;
	}

	private static uint Extend(uint bit)
	{
		return 0u;
	}

	private void WordToMsgs(uint w, Msg msg)
	{
	}

	private uint mpc_AND(uint a, uint b, uint mask_a, uint mask_b, Tape tape, Msg msg)
	{
		return 0u;
	}

	private void mpc_sbox(uint[] state, uint[] state_masks, Tape tape, Msg msg)
	{
	}

	internal void aux_mpc_sbox(uint[] input, uint[] output, Tape tape)
	{
	}

	private void aux_mpc_AND(uint mask_a, uint mask_b, uint fresh_output_mask, Tape tape)
	{
	}

	private bool Contains(uint[] list, int len, uint value)
	{
		return false;
	}

	private void TapesToWords(uint[] shares, Tape tape)
	{
	}

	private void GetAuxBits(byte[] output, Tape tape)
	{
	}

	private void commit(byte[] digest_arr, byte[] seed, byte[] aux, byte[] salt, uint t, uint j)
	{
	}

	private void ComputeSaltAndRootSeed(byte[] saltAndRoot, uint[] privateKey, uint[] pubKey, uint[] plaintext, byte[] message)
	{
	}

	private void UpdateDigest(uint[] block, byte[] temp)
	{
	}

	private static bool is_picnic3(int parameters)
	{
		return false;
	}

	internal void crypto_sign_keypair(byte[] pk, byte[] sk, SecureRandom random)
	{
	}

	private int picnic_write_private_key(byte[] data, byte[] ciphertext, byte[] plaintext, byte[] buf)
	{
		return 0;
	}

	private int picnic_write_public_key(byte[] ciphertext, byte[] plaintext, byte[] buf)
	{
		return 0;
	}

	private void picnic_keygen(byte[] plaintext_bytes, byte[] ciphertext_bytes, byte[] data_bytes, SecureRandom random)
	{
	}

	private void LowMCEnc(uint[] plaintext, uint[] output, uint[] key)
	{
	}

	private void Substitution(uint[] state)
	{
	}

	private void xor_three(uint[] output, uint[] in1, uint[] in2, uint[] in3)
	{
	}

	internal void xor_array(uint[] output, uint[] in1, uint[] in2, int in2_offset)
	{
	}

	internal void matrix_mul(uint[] output, uint[] state, uint[] matrix, int matrixOffset)
	{
	}

	internal void matrix_mul_offset(uint[] output, int outputOffset, uint[] state, int stateOffset, uint[] matrix, int matrixOffset)
	{
	}
}
