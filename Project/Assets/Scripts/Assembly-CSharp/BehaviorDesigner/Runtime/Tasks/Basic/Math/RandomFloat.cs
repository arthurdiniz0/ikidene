using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.Math
{
	public class RandomFloat : Action
	{
		public SharedFloat min;
		public SharedFloat max;
		public bool inclusive;
		public SharedFloat storeResult;
	}
}
