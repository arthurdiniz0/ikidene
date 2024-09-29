using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityLight
{
	public class SetRange : Action
	{
		public SharedGameObject targetGameObject;
		public SharedFloat range;
	}
}
