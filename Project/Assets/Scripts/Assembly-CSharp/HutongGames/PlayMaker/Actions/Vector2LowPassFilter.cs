using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class Vector2LowPassFilter : FsmStateAction
	{
		public FsmVector2 vector2Variable;
		public FsmFloat filteringFactor;
	}
}
