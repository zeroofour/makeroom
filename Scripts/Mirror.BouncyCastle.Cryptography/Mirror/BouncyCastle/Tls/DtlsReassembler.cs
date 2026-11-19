using System.Collections.Generic;

namespace Mirror.BouncyCastle.Tls;

internal sealed class DtlsReassembler
{
	private sealed class Range
	{
		private int m_start;

		private int m_end;

		public int Start
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int End
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		internal Range(int start, int end)
		{
		}
	}

	private readonly short m_msg_type;

	private readonly byte[] m_body;

	private readonly List<Range> m_missing;

	internal short MsgType => 0;

	internal DtlsReassembler(short msg_type, int length)
	{
	}

	internal byte[] GetBodyIfComplete()
	{
		return null;
	}

	internal void ContributeFragment(short msg_type, int length, byte[] buf, int off, int fragment_offset, int fragment_length)
	{
	}

	internal void Reset()
	{
	}
}
