namespace Mirror.BouncyCastle.Bcpg.OpenPgp;

internal sealed class PgpKdfParameters
{
	private readonly HashAlgorithmTag m_hashAlgorithm;

	private readonly SymmetricKeyAlgorithmTag m_symmetricWrapAlgorithm;

	public HashAlgorithmTag HashAlgorithm => (HashAlgorithmTag)0;

	public SymmetricKeyAlgorithmTag SymmetricWrapAlgorithm => SymmetricKeyAlgorithmTag.Null;

	public PgpKdfParameters(HashAlgorithmTag hashAlgorithm, SymmetricKeyAlgorithmTag symmetricWrapAlgorithm)
	{
	}
}
