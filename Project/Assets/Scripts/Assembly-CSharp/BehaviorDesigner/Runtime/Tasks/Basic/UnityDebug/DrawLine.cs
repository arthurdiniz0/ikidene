using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityDebug
{
	public class DrawLine : Action
	{
		public SharedVector3 start;
		public SharedVector3 end;
		public SharedColor color;
		public SharedFloat duration;
		public SharedBool depthTest;
	}
}
