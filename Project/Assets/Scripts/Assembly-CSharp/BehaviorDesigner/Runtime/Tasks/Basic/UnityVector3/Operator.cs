using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime.Tasks.Basic.UnityVector2;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityVector3
{
	public class Operator : Action
	{
		public Operator.Operation operation;
		public SharedVector3 firstVector3;
		public SharedVector3 secondVector3;
		public SharedVector3 storeResult;
	}
}
