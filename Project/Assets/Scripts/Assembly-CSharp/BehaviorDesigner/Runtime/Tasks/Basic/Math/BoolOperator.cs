using BehaviorDesigner.Runtime.Tasks;
using HutongGames.PlayMaker.Actions;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.Math
{
	public class BoolOperator : Action
	{
		public BoolOperator.Operation operation;
		public SharedBool bool1;
		public SharedBool bool2;
		public SharedBool storeResult;
	}
}
