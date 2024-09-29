using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks
{
	public class Wait : Action
	{
		public SharedFloat waitTime;
		public SharedBool randomWait;
		public SharedFloat randomWaitMin;
		public SharedFloat randomWaitMax;
	}
}
