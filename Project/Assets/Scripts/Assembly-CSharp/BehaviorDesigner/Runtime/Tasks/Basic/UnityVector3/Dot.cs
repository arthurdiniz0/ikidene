using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityVector3
{
	public class Dot : Action
	{
		public SharedVector3 leftHandSide;
		public SharedVector3 rightHandSide;
		public SharedFloat storeResult;
	}
}
