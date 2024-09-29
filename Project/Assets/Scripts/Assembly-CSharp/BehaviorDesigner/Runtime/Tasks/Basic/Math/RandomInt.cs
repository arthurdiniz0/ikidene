using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.Math
{
	public class RandomInt : Action
	{
		public SharedInt min;
		public SharedInt max;
		public bool inclusive;
		public SharedInt storeResult;
	}
}
