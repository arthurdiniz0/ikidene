using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.Math
{
	public class LerpAngle : Action
	{
		public SharedFloat fromValue;
		public SharedFloat toValue;
		public SharedFloat lerpAmount;
		public SharedFloat storeResult;
	}
}
