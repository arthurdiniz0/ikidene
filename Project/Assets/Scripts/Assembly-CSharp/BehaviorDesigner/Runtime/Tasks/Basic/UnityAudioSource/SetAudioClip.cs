using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityAudioSource
{
	public class SetAudioClip : Action
	{
		public SharedGameObject targetGameObject;
		public AudioClip audioClip;
	}
}
