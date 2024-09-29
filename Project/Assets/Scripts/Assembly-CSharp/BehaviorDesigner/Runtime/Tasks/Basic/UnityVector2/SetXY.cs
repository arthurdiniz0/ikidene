using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityVector2
{
	public class SetXY : Action
	{
		public SharedVector2 vector2Variable;
		public SharedFloat xValue;
		public SharedFloat yValue;
	}
}
