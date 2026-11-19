namespace Mirror.BouncyCastle.Bcpg.OpenPgp;

public class PgpSignatureList : PgpObject
{
	private readonly PgpSignature[] sigs;

	public PgpSignature this[int index] => null;

	public int Count => 0;

	public bool IsEmpty => false;

	public PgpSignatureList(PgpSignature[] sigs)
	{
	}

	public PgpSignatureList(PgpSignature sig)
	{
	}
}
