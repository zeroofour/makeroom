using System.Collections.Generic;
using Mirror.BouncyCastle.Math;

namespace Mirror.BouncyCastle.Crypto.Parameters;

public class NaccacheSternPrivateKeyParameters : NaccacheSternKeyParameters
{
	private readonly BigInteger phiN;

	private readonly IList<BigInteger> smallPrimes;

	public BigInteger PhiN => null;

	public IList<BigInteger> SmallPrimesList => null;

	public NaccacheSternPrivateKeyParameters(BigInteger g, BigInteger n, int lowerSigmaBound, IList<BigInteger> smallPrimes, BigInteger phiN)
		: base(privateKey: false, null, null, 0)
	{
	}
}
