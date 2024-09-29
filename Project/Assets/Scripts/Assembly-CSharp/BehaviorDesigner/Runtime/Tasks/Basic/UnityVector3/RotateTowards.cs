using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityVector3
{
	public class RotateTowards : Action
	{
		public SharedVector3 currentRotation;
		public SharedVector3 targetRotation;
		public SharedFloat maxDegreesDelta;
		public SharedFloat maxMagnitudeDelta;
		public SharedVector3 storeResult;
	}
}
