using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityQuaternion
{
	public class AngleAxis : Action
	{
		public SharedFloat degrees;
		public SharedVector3 axis;
		public SharedQuaternion storeResult;
	}
}
