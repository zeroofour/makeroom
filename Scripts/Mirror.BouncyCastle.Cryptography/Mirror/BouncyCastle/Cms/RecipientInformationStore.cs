using System.Collections;
using System.Collections.Generic;

namespace Mirror.BouncyCastle.Cms;

public class RecipientInformationStore : IEnumerable<RecipientInformation>, IEnumerable
{
	private readonly IList<RecipientInformation> m_all;

	private readonly IDictionary<RecipientID, IList<RecipientInformation>> m_table;

	public RecipientInformation this[RecipientID selector] => null;

	public int Count => 0;

	public RecipientInformationStore(IEnumerable<RecipientInformation> recipientInfos)
	{
	}

	public RecipientInformation GetFirstRecipient(RecipientID selector)
	{
		return null;
	}

	public IList<RecipientInformation> GetRecipients()
	{
		return null;
	}

	public IList<RecipientInformation> GetRecipients(RecipientID selector)
	{
		return null;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	public IEnumerator<RecipientInformation> GetEnumerator()
	{
		return null;
	}
}
