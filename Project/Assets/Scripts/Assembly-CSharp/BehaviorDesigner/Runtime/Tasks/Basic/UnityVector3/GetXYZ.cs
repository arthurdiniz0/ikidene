using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityVector3
{
	public class GetXYZ : Action
	{
		public SharedVector3 vector3Variable;
		public SharedFloat storeX;
		public SharedFloat storeY;
		public SharedFloat storeZ;
	}
}
