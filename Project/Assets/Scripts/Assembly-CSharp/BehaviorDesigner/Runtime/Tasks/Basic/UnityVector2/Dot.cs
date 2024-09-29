using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityVector2
{
	public class Dot : Action
	{
		public SharedVector2 leftHandSide;
		public SharedVector2 rightHandSide;
		public SharedFloat storeResult;
	}
}
