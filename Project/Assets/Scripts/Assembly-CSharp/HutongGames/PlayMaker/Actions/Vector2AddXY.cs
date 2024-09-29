using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class Vector2AddXY : FsmStateAction
	{
		public FsmVector2 vector2Variable;
		public FsmFloat addX;
		public FsmFloat addY;
		public bool everyFrame;
		public bool perSecond;
	}
}
