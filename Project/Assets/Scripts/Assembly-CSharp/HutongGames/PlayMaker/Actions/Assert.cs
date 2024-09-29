using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class Assert : FsmStateAction
	{
		public enum AssertType
		{
			IsTrue = 0,
			IsFalse = 1,
		}

		public FsmString expression;
		public AssertType assert;
		public bool everyFrame;
	}
}
