namespace Mirror;

public struct NetworkPingMessage(double localTime, double predictedTimeAdjusted) : NetworkMessage
{
	public double localTime = 0.0;

	public double predictedTimeAdjusted = 0.0;
}
