using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityVector2
{
	public class GetXY : Action
	{
		public SharedVector2 vector2Variable;
		public SharedFloat storeX;
		public SharedFloat storeY;
	}
}
