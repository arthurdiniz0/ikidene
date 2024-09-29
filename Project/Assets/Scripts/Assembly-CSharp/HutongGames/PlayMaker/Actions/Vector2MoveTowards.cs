using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class Vector2MoveTowards : FsmStateAction
	{
		public FsmVector2 source;
		public FsmVector2 target;
		public FsmFloat maxSpeed;
		public FsmFloat finishDistance;
		public FsmEvent finishEvent;
	}
}
