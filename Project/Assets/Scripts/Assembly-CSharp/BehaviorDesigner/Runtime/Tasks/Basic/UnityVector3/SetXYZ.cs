using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityVector3
{
	public class SetXYZ : Action
	{
		public SharedVector3 vector3Variable;
		public SharedFloat xValue;
		public SharedFloat yValue;
		public SharedFloat zValue;
	}
}
