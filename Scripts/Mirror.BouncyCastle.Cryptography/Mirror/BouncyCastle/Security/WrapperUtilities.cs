using System.Collections.Generic;
using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Crypto;

namespace Mirror.BouncyCastle.Security;

public static class WrapperUtilities
{
	private enum WrapAlgorithm
	{
		AESRFC3211WRAP = 0,
		AESWRAP = 1,
		AESWRAPPAD = 2,
		ARIARFC3211WRAP = 3,
		ARIAWRAP = 4,
		ARIAWRAPPAD = 5,
		CAMELLIARFC3211WRAP = 6,
		CAMELLIAWRAP = 7,
		DESRFC3211WRAP = 8,
		DESEDERFC3211WRAP = 9,
		DESEDEWRAP = 10,
		RC2WRAP = 11,
		SEEDWRAP = 12
	}

	private class BufferedCipherWrapper : IWrapper
	{
		private readonly IBufferedCipher cipher;

		private bool forWrapping;

		public string AlgorithmName => null;

		public BufferedCipherWrapper(IBufferedCipher cipher)
		{
		}

		public void Init(bool forWrapping, ICipherParameters parameters)
		{
		}

		public byte[] Wrap(byte[] input, int inOff, int length)
		{
			return null;
		}

		public byte[] Unwrap(byte[] input, int inOff, int length)
		{
			return null;
		}
	}

	private static readonly IDictionary<string, string> Algorithms;

	static WrapperUtilities()
	{
	}

	public static IWrapper GetWrapper(DerObjectIdentifier oid)
	{
		return null;
	}

	public static IWrapper GetWrapper(string algorithm)
	{
		return null;
	}

	public static string GetAlgorithmName(DerObjectIdentifier oid)
	{
		return null;
	}
}
