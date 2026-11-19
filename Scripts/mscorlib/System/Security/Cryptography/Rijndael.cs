using System.Runtime.InteropServices;

namespace System.Security.Cryptography;

[ComVisible(true)]
public abstract class Rijndael : SymmetricAlgorithm
{
	private static KeySizes[] s_legalBlockSizes;

	private static KeySizes[] s_legalKeySizes;
}
