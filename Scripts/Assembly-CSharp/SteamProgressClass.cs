using System;

public class SteamProgressClass : IProgress<float>
{
	private float lastValue;

	private PromptLoading promptLoading;

	public void Report(float _value)
	{
	}
}
