using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityAnimation
{
	public class PlayQueued : Action
	{
		public SharedGameObject targetGameObject;
		public SharedString animationName;
		public QueueMode queue;
		public PlayMode playMode;
	}
}
