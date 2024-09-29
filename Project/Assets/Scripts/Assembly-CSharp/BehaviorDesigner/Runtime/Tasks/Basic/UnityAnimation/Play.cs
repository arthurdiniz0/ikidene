using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityAnimation
{
	public class Play : Action
	{
		public SharedGameObject targetGameObject;
		public SharedString animationName;
		public PlayMode playMode;
	}
}
