using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class Vector2Operator : FsmStateAction
	{
		public enum Vector2Operation
		{
			DotProduct = 0,
			Distance = 1,
			Angle = 2,
			Add = 3,
			Subtract = 4,
			Multiply = 5,
			Divide = 6,
			Min = 7,
			Max = 8,
		}

		public FsmVector2 vector1;
		public FsmVector2 vector2;
		public Vector2Operation operation;
		public FsmVector2 storeVector2Result;
		public FsmFloat storeFloatResult;
		public bool everyFrame;
	}
}
