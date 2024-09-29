using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityGameObject
{
	public class SetTag : Action
	{
		public SharedGameObject targetGameObject;
		public SharedString tag;
	}
}
