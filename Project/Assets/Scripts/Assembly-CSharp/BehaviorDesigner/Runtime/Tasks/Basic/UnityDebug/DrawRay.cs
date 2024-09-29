using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityDebug
{
	public class DrawRay : Action
	{
		public SharedVector3 start;
		public SharedVector3 direction;
		public SharedColor color;
	}
}
