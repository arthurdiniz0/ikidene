using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityVector3
{
	public class Lerp : Action
	{
		public SharedVector3 fromVector3;
		public SharedVector3 toVector3;
		public SharedFloat lerpAmount;
		public SharedVector3 storeResult;
	}
}
