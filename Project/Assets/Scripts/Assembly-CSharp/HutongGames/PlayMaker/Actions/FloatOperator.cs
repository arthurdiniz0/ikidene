using HutongGames.PlayMaker;
using BehaviorDesigner.Runtime.Tasks.Basic.Math;

namespace HutongGames.PlayMaker.Actions
{
	public class FloatOperator : FsmStateAction
	{
		public FsmFloat float1;
		public FsmFloat float2;
		public FloatOperator.Operation operation;
		public FsmFloat storeResult;
		public bool everyFrame;
	}
}
