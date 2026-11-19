using System;

namespace Mirror;

public abstract class SyncObject
{
	public Action OnDirty;

	public Func<bool> IsRecording;

	public Func<bool> IsWritable;

	public abstract void ClearChanges();

	public abstract void OnSerializeAll(NetworkWriter writer);

	public abstract void OnSerializeDelta(NetworkWriter writer);

	public abstract void OnDeserializeAll(NetworkReader reader);

	public abstract void OnDeserializeDelta(NetworkReader reader);

	public abstract void Reset();
}
