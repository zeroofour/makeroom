using System.Runtime.InteropServices;

namespace System.Security.Cryptography;

[ComVisible(true)]
public abstract class RC2 : SymmetricAlgorithm
{
	protected int EffectiveKeySizeValue;

	private static KeySizes[] s_legalBlockSizes;

	private static KeySizes[] s_legalKeySizes;

	public virtual int EffectiveKeySize => 0;

	public override int KeySize
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}
}
