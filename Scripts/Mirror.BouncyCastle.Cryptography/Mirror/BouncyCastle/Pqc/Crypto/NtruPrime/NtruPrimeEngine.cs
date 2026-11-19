using System.Collections.Generic;
using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Pqc.Crypto.NtruPrime;

internal class NtruPrimeEngine
{
	private readonly int _skBytes;

	private readonly int _pkBytes;

	private readonly int _ctBytes;

	private readonly int _secretKeyBytes;

	private readonly int _publicKeyBytes;

	private readonly int _ciphertextsBytes;

	private readonly int _confirmBytes;

	private readonly int _inputsBytes;

	private readonly int _topBytes;

	private readonly int _seedBytes;

	private readonly int _smallBytes;

	private readonly int _hashBytes;

	private readonly int SessionKeyBytes;

	private readonly int _p;

	private readonly int _q;

	private readonly int _roundedBytes;

	private readonly bool _lpr;

	private readonly int _w;

	private readonly int _tau0;

	private readonly int _tau1;

	private readonly int _tau2;

	private readonly int _tau3;

	private readonly int _I;

	private readonly int _q12;

	public int PrivateKeySize => 0;

	public int PublicKeySize => 0;

	public int CipherTextSize => 0;

	public int SessionKeySize => 0;

	public NtruPrimeEngine(int p, int q, bool lpr, int w, int tau0, int tau1, int tau2, int tau3, int skBytes, int pkBytes, int ctBytes, int roundedBytes, int rqBytes, int defaultKeyLen)
	{
	}

	public void kem_keypair(byte[] pk, byte[] sk, SecureRandom random)
	{
	}

	public void kem_enc(byte[] ct, byte[] ss, byte[] pk, SecureRandom random)
	{
	}

	public void kem_dec(byte[] ss, byte[] ct, byte[] sk)
	{
	}

	private void KeyGen(SecureRandom random, byte[] pk, byte[] sk)
	{
	}

	private void ByteRandom(sbyte[] output, SecureRandom random)
	{
	}

	private int R3Recip(sbyte[] output, sbyte[] input)
	{
		return 0;
	}

	private int RqRecip3(short[] output, sbyte[] input)
	{
		return 0;
	}

	private short FqRecip(short a1)
	{
		return 0;
	}

	private void RqMult(ref short[] output, short[] f, sbyte[] g)
	{
	}

	private void RqEncode(byte[] output, short[] r)
	{
	}

	private void RqDecode(short[] output, byte[] s)
	{
	}

	private void RqMult3(short[] output, short[] f)
	{
	}

	private void R3FromRq(sbyte[] output, short[] r)
	{
	}

	private void R3Mult(sbyte[] output, sbyte[] f, sbyte[] g)
	{
	}

	private int WeightMask(sbyte[] r)
	{
		return 0;
	}

	private int NonZeroMask(short x)
	{
		return 0;
	}

	private List<ushort> Decode(List<byte> S, List<ushort> M)
	{
		return null;
	}

	private int Encode(byte[] output, int outputPos, ushort[] R, ushort[] M, long len)
	{
		return 0;
	}

	private void Encrypt(byte[] output, sbyte[] r, byte[] pk)
	{
	}

	private void Decrypt(sbyte[] output, byte[] c, byte[] sk)
	{
	}

	private void Hide(byte[] output, byte[] r_enc, sbyte[] r, byte[] pk, byte[] cache)
	{
	}

	private void Generator(short[] output, byte[] seed)
	{
	}

	private uint[] Expand(byte[] k)
	{
		return null;
	}

	private void ShortRandom(sbyte[] output, SecureRandom random)
	{
	}

	private void ShortFromList(sbyte[] output, uint[] L_in)
	{
	}

	private void RqMult(ref short[] output, short[] G, ref sbyte[] a)
	{
	}

	private void Round(short[] output, short[] aG)
	{
	}

	private void InputsRandom(sbyte[] output, SecureRandom random)
	{
	}

	private void InputsEncode(byte[] output, sbyte[] r)
	{
	}

	private void RoundedEncode(byte[] output, short[] A)
	{
	}

	private void RoundedDecode(short[] output, byte[] s)
	{
	}

	private void ByteEncode(byte[] output, sbyte[] a)
	{
	}

	private void ByteDecode(sbyte[] output, byte[] s)
	{
	}

	private void TopEncode(byte[] output, sbyte[] T)
	{
	}

	private void TopDecode(sbyte[] output, byte[] s)
	{
	}

	private void HashShort(sbyte[] output, sbyte[] r)
	{
	}

	private void HashPrefix(byte[] output, int b, byte[] input, int inlen)
	{
	}

	private void HashConfirm(byte[] output, byte[] r, byte[] pk, byte[] cache)
	{
	}

	private void HashSession(byte[] output, int b, byte[] y, byte[] z)
	{
	}

	private int NegativeMask(short x)
	{
		return 0;
	}

	private int ctDiffMask(byte[] c, byte[] c2)
	{
		return 0;
	}

	private double Mod(double a, double b)
	{
		return 0.0;
	}

	private short ArithmeticMod_q(int x)
	{
		return 0;
	}

	private short ArithmeticMod_3(int x)
	{
		return 0;
	}

	private sbyte Top(int C)
	{
		return 0;
	}

	private short Right(sbyte T)
	{
		return 0;
	}
}
