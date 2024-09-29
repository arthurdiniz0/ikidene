using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class Vector2ClampMagnitude : FsmStateAction
	{
		public FsmVector2 vector2Variable;
		public FsmFloat maxLength;
		public bool everyFrame;
	}
}
