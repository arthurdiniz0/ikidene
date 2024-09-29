using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityVector2
{
	public class Multiply : Action
	{
		public SharedVector2 vector2Variable;
		public SharedFloat multiplyBy;
		public SharedVector2 storeResult;
	}
}
