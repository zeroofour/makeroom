namespace Mirror.BouncyCastle.Pqc.Crypto.Picnic;

internal class Tape
{
	internal byte[][] tapes;

	internal int pos;

	private int nTapes;

	private readonly PicnicEngine engine;

	internal Tape(PicnicEngine engine)
	{
	}

	internal void SetAuxBits(byte[] input)
	{
	}

	internal void ComputeAuxTape(byte[] inputs)
	{
	}

	private void TapesToParityBits(uint[] output, int outputBitLen)
	{
	}

	internal uint TapesToWord()
	{
		return 0u;
	}
}
