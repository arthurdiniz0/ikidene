using BehaviorDesigner.Runtime;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks
{
	public class Task
	{
		[SerializeField]
		private NodeData nodeData;
		[SerializeField]
		private Behavior owner;
		[SerializeField]
		private int id;
		[SerializeField]
		private string friendlyName;
		[SerializeField]
		private bool instant;
	}
}
