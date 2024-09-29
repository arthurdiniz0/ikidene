using HutongGames.PlayMaker;

namespace PixelCrushers.DialogueSystem.PlayMaker
{
	public class DecRelationship : FsmStateAction
	{
		public FsmString actor1Name;
		public FsmString actor2Name;
		public FsmString relationshipType;
		public FsmFloat decrementAmount;
	}
}
