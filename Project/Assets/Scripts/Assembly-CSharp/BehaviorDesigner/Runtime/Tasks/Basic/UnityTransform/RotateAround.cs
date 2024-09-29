using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityTransform
{
	public class RotateAround : Action
	{
		public SharedGameObject targetGameObject;
		public SharedVector3 point;
		public SharedVector3 axis;
		public SharedFloat angle;
	}
}
