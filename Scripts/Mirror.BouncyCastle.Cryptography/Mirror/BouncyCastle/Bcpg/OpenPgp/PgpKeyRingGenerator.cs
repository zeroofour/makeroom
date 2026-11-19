using System.Collections.Generic;
using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Bcpg.OpenPgp;

public class PgpKeyRingGenerator
{
	private IList<PgpSecretKey> keys;

	private string id;

	private SymmetricKeyAlgorithmTag encAlgorithm;

	private HashAlgorithmTag hashAlgorithm;

	private int certificationLevel;

	private byte[] rawPassPhrase;

	private bool useSha1;

	private PgpKeyPair masterKey;

	private PgpSignatureSubpacketVector hashedPacketVector;

	private PgpSignatureSubpacketVector unhashedPacketVector;

	private SecureRandom rand;

	public PgpKeyRingGenerator(int certificationLevel, PgpKeyPair masterKey, string id, SymmetricKeyAlgorithmTag encAlgorithm, char[] passPhrase, bool useSha1, PgpSignatureSubpacketVector hashedPackets, PgpSignatureSubpacketVector unhashedPackets, SecureRandom rand)
	{
	}

	public PgpKeyRingGenerator(int certificationLevel, PgpKeyPair masterKey, string id, SymmetricKeyAlgorithmTag encAlgorithm, bool utf8PassPhrase, char[] passPhrase, bool useSha1, PgpSignatureSubpacketVector hashedPackets, PgpSignatureSubpacketVector unhashedPackets, SecureRandom rand)
	{
	}

	public PgpKeyRingGenerator(int certificationLevel, PgpKeyPair masterKey, string id, SymmetricKeyAlgorithmTag encAlgorithm, byte[] rawPassPhrase, bool useSha1, PgpSignatureSubpacketVector hashedPackets, PgpSignatureSubpacketVector unhashedPackets, SecureRandom rand)
	{
	}

	public PgpKeyRingGenerator(int certificationLevel, PgpKeyPair masterKey, string id, SymmetricKeyAlgorithmTag encAlgorithm, HashAlgorithmTag hashAlgorithm, char[] passPhrase, bool useSha1, PgpSignatureSubpacketVector hashedPackets, PgpSignatureSubpacketVector unhashedPackets, SecureRandom rand)
	{
	}

	public PgpKeyRingGenerator(int certificationLevel, PgpKeyPair masterKey, string id, SymmetricKeyAlgorithmTag encAlgorithm, HashAlgorithmTag hashAlgorithm, bool utf8PassPhrase, char[] passPhrase, bool useSha1, PgpSignatureSubpacketVector hashedPackets, PgpSignatureSubpacketVector unhashedPackets, SecureRandom rand)
	{
	}

	public PgpKeyRingGenerator(int certificationLevel, PgpKeyPair masterKey, string id, SymmetricKeyAlgorithmTag encAlgorithm, HashAlgorithmTag hashAlgorithm, byte[] rawPassPhrase, bool useSha1, PgpSignatureSubpacketVector hashedPackets, PgpSignatureSubpacketVector unhashedPackets, SecureRandom rand)
	{
	}

	public void AddSubKey(PgpKeyPair keyPair)
	{
	}

	public void AddSubKey(PgpKeyPair keyPair, HashAlgorithmTag hashAlgorithm)
	{
	}

	public void AddSubKey(PgpKeyPair keyPair, HashAlgorithmTag hashAlgorithm, HashAlgorithmTag primaryKeyBindingHashAlgorithm)
	{
	}

	public void AddSubKey(PgpKeyPair keyPair, PgpSignatureSubpacketVector hashedPackets, PgpSignatureSubpacketVector unhashedPackets)
	{
	}

	public void AddSubKey(PgpKeyPair keyPair, PgpSignatureSubpacketVector hashedPackets, PgpSignatureSubpacketVector unhashedPackets, HashAlgorithmTag hashAlgorithm)
	{
	}

	public void AddSubKey(PgpKeyPair keyPair, PgpSignatureSubpacketVector hashedPackets, PgpSignatureSubpacketVector unhashedPackets, HashAlgorithmTag hashAlgorithm, HashAlgorithmTag primaryKeyBindingHashAlgorithm)
	{
	}

	public PgpSecretKeyRing GenerateSecretKeyRing()
	{
		return null;
	}

	public PgpPublicKeyRing GeneratePublicKeyRing()
	{
		return null;
	}
}
