namespace Mirror.Examples.CharacterSelection;

public class PlayerEmpty : NetworkBehaviour
{
	private SceneReferencer sceneReferencer;

	public override void OnStartAuthority()
	{
	}

	public override bool Weaved()
	{
		return false;
	}
}
