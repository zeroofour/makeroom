namespace Mirror.BouncyCastle.Tls;

public sealed class RecordPreview
{
	private readonly int recordSize;

	private readonly int contentLimit;

	public int ContentLimit => 0;

	public int RecordSize => 0;

	internal static RecordPreview CombineAppData(RecordPreview a, RecordPreview b)
	{
		return null;
	}

	internal static RecordPreview ExtendRecordSize(RecordPreview a, int recordSize)
	{
		return null;
	}

	internal RecordPreview(int recordSize, int contentLimit)
	{
	}
}
