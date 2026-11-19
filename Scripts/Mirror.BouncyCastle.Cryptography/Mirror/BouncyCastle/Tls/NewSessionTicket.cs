using System.IO;

namespace Mirror.BouncyCastle.Tls;

public sealed class NewSessionTicket
{
	private readonly long m_ticketLifetimeHint;

	private readonly byte[] m_ticket;

	public long TicketLifetimeHint => 0L;

	public byte[] Ticket => null;

	public NewSessionTicket(long ticketLifetimeHint, byte[] ticket)
	{
	}

	public void Encode(Stream output)
	{
	}

	public static NewSessionTicket Parse(Stream input)
	{
		return null;
	}
}
