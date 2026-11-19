using System;
using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Asn1.Crmf;
using Mirror.BouncyCastle.Cms;

namespace Mirror.BouncyCastle.Crmf;

public class PkiArchiveControl : IControl
{
	public static readonly int encryptedPrivKey;

	public static readonly int keyGenParameters;

	public static readonly int archiveRemGenPrivKey;

	private readonly PkiArchiveOptions m_pkiArchiveOptions;

	public DerObjectIdentifier Type => null;

	public Asn1Encodable Value => null;

	public int ArchiveType => 0;

	[Obsolete("Use 'IsEnvelopedData' instead")]
	public bool EnvelopedData => false;

	public PkiArchiveControl(PkiArchiveOptions pkiArchiveOptions)
	{
	}

	public bool IsEnvelopedData()
	{
		return false;
	}

	public CmsEnvelopedData GetEnvelopedData()
	{
		return null;
	}
}
