using HutongGames.PlayMaker;

public class CoreGameKitKillableAttackOrHitPointsMod : FsmStateAction
{
	public FsmOwnerDefault gameObject;
	public bool everyFrame;
	public FsmBool changeAttackPoints;
	public FsmInt newAttackPoints;
	public FsmBool changeHitPoints;
	public FsmInt newHitPoints;
}
