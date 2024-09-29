using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class Vector2Lerp : FsmStateAction
	{
		public FsmVector2 fromVector;
		public FsmVector2 toVector;
		public FsmFloat amount;
		public FsmVector2 storeResult;
		public bool everyFrame;
	}
}
