using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityVector3
{
	public class Multiply : Action
	{
		public SharedVector3 vector3Variable;
		public SharedFloat multiplyBy;
		public SharedVector3 storeResult;
	}
}
