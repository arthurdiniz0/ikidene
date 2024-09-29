using BehaviorDesigner.Runtime.Tasks;
using HutongGames.PlayMaker.Actions;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.Math
{
	public class IntOperator : Action
	{
		public IntOperator.Operation operation;
		public SharedInt integer1;
		public SharedInt integer2;
		public SharedInt storeResult;
	}
}
