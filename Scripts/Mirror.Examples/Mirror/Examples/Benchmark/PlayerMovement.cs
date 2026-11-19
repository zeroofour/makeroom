namespace Mirror.Examples.Benchmark;

public class PlayerMovement : NetworkBehaviour
{
	public float speed;

	public override void OnStartClient()
	{
	}

	public override void OnStartServer()
	{
	}

	private void Update()
	{
	}

	public override bool Weaved()
	{
		return false;
	}
}
