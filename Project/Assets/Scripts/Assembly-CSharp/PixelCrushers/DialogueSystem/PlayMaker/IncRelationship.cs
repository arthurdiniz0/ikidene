using HutongGames.PlayMaker;

namespace PixelCrushers.DialogueSystem.PlayMaker
{
	public class IncRelationship : FsmStateAction
	{
		public FsmString actor1Name;
		public FsmString actor2Name;
		public FsmString relationshipType;
		public FsmFloat incrementAmount;
	}
}
