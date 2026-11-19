namespace Mirror;

public struct ChangeOwnerMessage : NetworkMessage
{
	public uint netId;

	public SpawnFlags spawnFlags;

	public bool isOwner
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool isLocalPlayer
	{
		get
		{
			return false;
		}
		set
		{
		}
	}
}
