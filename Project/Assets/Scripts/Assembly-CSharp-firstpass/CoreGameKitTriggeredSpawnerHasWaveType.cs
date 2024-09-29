using HutongGames.PlayMaker;
using DarkTonic.CoreGameKit;

public class CoreGameKitTriggeredSpawnerHasWaveType : FsmStateAction
{
	public TriggeredSpawner.EventType eventType;
	public FsmString customEventName;
	public FsmOwnerDefault triggeredSpawner;
	public FsmBool boolVariable;
	public bool everyFrame;
}
