namespace Mirror.BouncyCastle.Bcpg.OpenPgp;

public class PgpOnePassSignatureList : PgpObject
{
	private readonly PgpOnePassSignature[] sigs;

	public PgpOnePassSignature this[int index] => null;

	public int Count => 0;

	public bool IsEmpty => false;

	public PgpOnePassSignatureList(PgpOnePassSignature[] sigs)
	{
	}

	public PgpOnePassSignatureList(PgpOnePassSignature sig)
	{
	}
}
