using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityVector2
{
	public class Operator : Action
	{
		public enum Operation
		{
			Add = 0,
			Subtract = 1,
			Scale = 2,
		}

		public Operation operation;
		public SharedVector2 firstVector2;
		public SharedVector2 secondVector2;
		public SharedVector2 storeResult;
	}
}
