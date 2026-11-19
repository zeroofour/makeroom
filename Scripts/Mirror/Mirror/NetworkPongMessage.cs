namespace Mirror;

public struct NetworkPongMessage(double localTime, double predictionErrorUnadjusted, double predictionErrorAdjusted) : NetworkMessage
{
	public double localTime = 0.0;

	public double predictionErrorUnadjusted = 0.0;

	public double predictionErrorAdjusted = 0.0;
}
