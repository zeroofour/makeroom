namespace Steamworks.Data;

internal struct NumericalFilter
{
	public string Key { get; internal set; } = null;

	public int Value { get; internal set; } = 0;

	public LobbyComparison Comparer { get; internal set; } = LobbyComparison.Equal;

	internal NumericalFilter(string k, int v, LobbyComparison c)
	{
	}
}
