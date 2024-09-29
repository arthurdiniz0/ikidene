using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Movement
{
	public class RotateTowards : Action
	{
		public bool usePhysics2D;
		public SharedFloat rotationEpsilon;
		public SharedFloat maxLookAtRotationDelta;
		public SharedBool onlyY;
		public SharedGameObject target;
		public SharedVector3 targetRotation;
	}
}
