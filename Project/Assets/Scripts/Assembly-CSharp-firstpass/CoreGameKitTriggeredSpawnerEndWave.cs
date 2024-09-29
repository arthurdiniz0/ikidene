using HutongGames.PlayMaker;
using DarkTonic.CoreGameKit;

public class CoreGameKitTriggeredSpawnerEndWave : FsmStateAction
{
	public TriggeredSpawner.EventType eventType;
	public FsmOwnerDefault triggeredSpawner;
	public FsmString customEventName;
}
