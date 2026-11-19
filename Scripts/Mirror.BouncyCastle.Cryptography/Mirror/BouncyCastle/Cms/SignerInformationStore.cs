using System.Collections;
using System.Collections.Generic;

namespace Mirror.BouncyCastle.Cms;

public class SignerInformationStore : IEnumerable<SignerInformation>, IEnumerable
{
	private readonly IList<SignerInformation> m_all;

	private readonly IDictionary<SignerID, IList<SignerInformation>> m_table;

	public int Count => 0;

	public SignerInformationStore(SignerInformation signerInfo)
	{
	}

	public SignerInformationStore(IEnumerable<SignerInformation> signerInfos)
	{
	}

	public SignerInformation GetFirstSigner(SignerID selector)
	{
		return null;
	}

	public IList<SignerInformation> GetSigners()
	{
		return null;
	}

	public IList<SignerInformation> GetSigners(SignerID selector)
	{
		return null;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	public IEnumerator<SignerInformation> GetEnumerator()
	{
		return null;
	}
}
