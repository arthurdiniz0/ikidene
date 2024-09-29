using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.Math
{
	public class IntComparison : Conditional
	{
		public enum Operation
		{
			LessThan = 0,
			LessThanOrEqualTo = 1,
			EqualTo = 2,
			NotEqualTo = 3,
			GreaterThanOrEqualTo = 4,
			GreaterThan = 5,
		}

		public Operation operation;
		public SharedInt integer1;
		public SharedInt integer2;
	}
}
