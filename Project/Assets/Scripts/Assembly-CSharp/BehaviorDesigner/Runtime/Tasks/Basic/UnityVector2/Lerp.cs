using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityVector2
{
	public class Lerp : Action
	{
		public SharedVector2 fromVector2;
		public SharedVector2 toVector2;
		public SharedFloat lerpAmount;
		public SharedVector2 storeResult;
	}
}
