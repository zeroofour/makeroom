namespace Mirror;

public class FpsMinMaxAvgGraph : BaseUIGraph
{
	protected override void CollectData(int category, out float value, out GraphAggregationMode mode)
	{
		value = default;
		mode = default;
	}

	protected override void OnValidate()
	{
	}
}
