using System.Runtime.CompilerServices;

namespace Mirror.BouncyCastle.Crypto.Engines;

public class ChaCha7539Engine : Salsa20Engine
{
	public override string AlgorithmName => null;

	protected override int NonceSize => 0;

	protected override void AdvanceCounter()
	{
	}

	protected override void ResetCounter()
	{
	}

	protected override void SetKey(byte[] keyBytes, byte[] ivBytes)
	{
	}

	protected override void GenerateKeyStream(byte[] output)
	{
	}

	internal void DoFinal(byte[] inBuf, int inOff, int inLen, byte[] outBuf, int outOff)
	{
	}

	internal void ProcessBlock(byte[] inBytes, int inOff, byte[] outBytes, int outOff)
	{
	}

	internal void ProcessBlocks2(byte[] inBytes, int inOff, byte[] outBytes, int outOff)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal void ImplProcessBlock(byte[] inBuf, int inOff, byte[] outBuf, int outOff)
	{
	}
}
