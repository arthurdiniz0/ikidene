using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityVector2
{
	public class ClampMagnitude : Action
	{
		public SharedVector2 vector2Variable;
		public SharedFloat maxLength;
		public SharedVector2 storeResult;
	}
}
