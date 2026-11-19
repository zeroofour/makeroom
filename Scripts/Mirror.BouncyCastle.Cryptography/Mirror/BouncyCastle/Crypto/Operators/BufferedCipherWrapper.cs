using System.IO;
using Mirror.BouncyCastle.Crypto.IO;

namespace Mirror.BouncyCastle.Crypto.Operators;

public class BufferedCipherWrapper : ICipher
{
	private readonly IBufferedCipher bufferedCipher;

	private readonly CipherStream stream;

	public Stream Stream => null;

	public BufferedCipherWrapper(IBufferedCipher bufferedCipher, Stream source)
	{
	}

	public int GetMaxOutputSize(int inputLen)
	{
		return 0;
	}

	public int GetUpdateOutputSize(int inputLen)
	{
		return 0;
	}
}
