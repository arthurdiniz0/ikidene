using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityVector3
{
	public class ClampMagnitude : Action
	{
		public SharedVector3 vector3Variable;
		public SharedFloat maxLength;
		public SharedVector3 storeResult;
	}
}
