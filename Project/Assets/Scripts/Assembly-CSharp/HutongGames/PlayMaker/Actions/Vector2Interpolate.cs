using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class Vector2Interpolate : FsmStateAction
	{
		public InterpolationType mode;
		public FsmVector2 fromVector;
		public FsmVector2 toVector;
		public FsmFloat time;
		public FsmVector2 storeResult;
		public FsmEvent finishEvent;
		public bool realTime;
	}
}
