using System;
using System.Collections.Generic;
using System.IO;
using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Crypto.IO;
using Mirror.BouncyCastle.Crypto.Parameters;
using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Bcpg.OpenPgp;

public class PgpEncryptedDataGenerator : IStreamGenerator
{
	private abstract class EncMethod : ContainedPacket
	{
		protected byte[] sessionInfo;

		protected SymmetricKeyAlgorithmTag encAlgorithm;

		protected KeyParameter key;

		public abstract void AddSessionInfo(byte[] si, SecureRandom random);
	}

	private class PbeMethod : EncMethod
	{
		private S2k s2k;

		internal PbeMethod(SymmetricKeyAlgorithmTag encAlgorithm, S2k s2k, KeyParameter key)
		{
		}

		public KeyParameter GetKey()
		{
			return null;
		}

		public override void AddSessionInfo(byte[] si, SecureRandom random)
		{
		}

		public override void Encode(BcpgOutputStream pOut)
		{
		}
	}

	private class PubMethod : EncMethod
	{
		internal PgpPublicKey pubKey;

		internal bool sessionKeyObfuscation;

		internal byte[][] data;

		internal PubMethod(PgpPublicKey pubKey, bool sessionKeyObfuscation)
		{
		}

		public override void AddSessionInfo(byte[] sessionInfo, SecureRandom random)
		{
		}

		private byte[] EncryptSessionInfo(byte[] sessionInfo, SecureRandom random)
		{
			return null;
		}

		private byte[] EncryptSessionInfo(ECDHPublicBcpgKey ecPubKey, byte[] sessionInfo, byte[] secret, byte[] ephPubEncoding, SecureRandom random)
		{
			return null;
		}

		private byte[][] ProcessSessionInfo(byte[] encryptedSessionInfo)
		{
			return null;
		}

		private byte[] ConvertToEncodedMpi(byte[] encryptedSessionInfo)
		{
			return null;
		}

		public override void Encode(BcpgOutputStream pOut)
		{
		}
	}

	private BcpgOutputStream pOut;

	private CipherStream cOut;

	private IBufferedCipher c;

	private bool withIntegrityPacket;

	private bool oldFormat;

	private DigestStream digestOut;

	private readonly List<EncMethod> methods;

	private readonly SymmetricKeyAlgorithmTag defAlgorithm;

	private readonly SecureRandom rand;

	public PgpEncryptedDataGenerator(SymmetricKeyAlgorithmTag encAlgorithm)
	{
	}

	public PgpEncryptedDataGenerator(SymmetricKeyAlgorithmTag encAlgorithm, bool withIntegrityPacket)
	{
	}

	public PgpEncryptedDataGenerator(SymmetricKeyAlgorithmTag encAlgorithm, SecureRandom random)
	{
	}

	public PgpEncryptedDataGenerator(SymmetricKeyAlgorithmTag encAlgorithm, bool withIntegrityPacket, SecureRandom random)
	{
	}

	public PgpEncryptedDataGenerator(SymmetricKeyAlgorithmTag encAlgorithm, SecureRandom random, bool oldFormat)
	{
	}

	public void AddMethod(char[] passPhrase, HashAlgorithmTag s2kDigest)
	{
	}

	public void AddMethodUtf8(char[] passPhrase, HashAlgorithmTag s2kDigest)
	{
	}

	public void AddMethodRaw(byte[] rawPassPhrase, HashAlgorithmTag s2kDigest)
	{
	}

	internal void DoAddMethod(byte[] rawPassPhrase, bool clearPassPhrase, HashAlgorithmTag s2kDigest)
	{
	}

	public void AddMethod(PgpPublicKey key)
	{
	}

	public void AddMethod(PgpPublicKey key, bool sessionKeyObfuscation)
	{
	}

	private void AddCheckSum(byte[] sessionInfo)
	{
	}

	private byte[] CreateSessionInfo(SymmetricKeyAlgorithmTag algorithm, KeyParameter key)
	{
		return null;
	}

	private Stream Open(Stream outStr, long length, byte[] buffer)
	{
		return null;
	}

	public Stream Open(Stream outStr, long length)
	{
		return null;
	}

	public Stream Open(Stream outStr, byte[] buffer)
	{
		return null;
	}

	[Obsolete("Dispose any opened Stream directly")]
	public void Close()
	{
	}
}
