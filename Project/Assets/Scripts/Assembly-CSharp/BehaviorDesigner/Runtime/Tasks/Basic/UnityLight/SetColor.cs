using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityLight
{
	public class SetColor : Action
	{
		public SharedGameObject targetGameObject;
		public SharedColor color;
	}
}
