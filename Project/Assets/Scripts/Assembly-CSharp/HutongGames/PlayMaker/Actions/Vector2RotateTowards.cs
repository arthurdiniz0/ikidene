using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class Vector2RotateTowards : FsmStateAction
	{
		public FsmVector2 currentDirection;
		public FsmVector2 targetDirection;
		public FsmFloat rotateSpeed;
	}
}
