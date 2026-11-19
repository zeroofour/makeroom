namespace Mirror;

public class NetworkBandwidthGraph : BaseUIGraph
{
	private int dataIn;

	private int dataOut;

	private static readonly string[] Units;

	private const float UnitScale = 1024f;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnSend(NetworkDiagnostics.MessageInfo obj)
	{
	}

	private void OnReceive(NetworkDiagnostics.MessageInfo obj)
	{
	}

	protected override void CollectData(int category, out float value, out GraphAggregationMode mode)
	{
		value = default;
		mode = default;
	}

	protected override string FormatValue(float value)
	{
		return null;
	}

	protected override void OnValidate()
	{
	}
}
