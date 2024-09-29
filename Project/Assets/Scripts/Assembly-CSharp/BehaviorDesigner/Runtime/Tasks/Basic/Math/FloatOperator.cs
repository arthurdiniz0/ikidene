using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.Math
{
	public class FloatOperator : Action
	{
		public enum Operation
		{
			Add = 0,
			Subtract = 1,
			Multiply = 2,
			Divide = 3,
			Min = 4,
			Max = 5,
			Modulo = 6,
		}

		public Operation operation;
		public SharedFloat float1;
		public SharedFloat float2;
		public SharedFloat storeResult;
	}
}
