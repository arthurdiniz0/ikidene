using System;
using UnityEngine;
using System.Collections.Generic;

namespace BehaviorDesigner.Runtime
{
	[Serializable]
	public class NodeData
	{
		[SerializeField]
		private Vector2 offset;
		[SerializeField]
		private string friendlyName;
		[SerializeField]
		private string comment;
		[SerializeField]
		private bool isBreakpoint;
		[SerializeField]
		private Texture icon;
		[SerializeField]
		private bool collapsed;
		[SerializeField]
		private int colorIndex;
		[SerializeField]
		private List<string> watchedFieldNames;
	}
}
