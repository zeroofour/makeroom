namespace Mirror;

public class NetworkPingGraph : BaseUIGraph
{
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
