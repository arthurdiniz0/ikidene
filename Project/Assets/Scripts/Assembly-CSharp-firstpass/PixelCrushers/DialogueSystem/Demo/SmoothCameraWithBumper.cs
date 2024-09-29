using UnityEngine;

namespace PixelCrushers.DialogueSystem.Demo
{
	public class SmoothCameraWithBumper : MonoBehaviour
	{
		public Transform target;
		[SerializeField]
		private float distance;
		[SerializeField]
		private float height;
		[SerializeField]
		private float damping;
		[SerializeField]
		private bool smoothRotation;
		[SerializeField]
		private float rotationDamping;
		[SerializeField]
		private Vector3 targetLookAtOffset;
		[SerializeField]
		private float bumperDistanceCheck;
		[SerializeField]
		private float bumperCameraHeight;
		[SerializeField]
		private Vector3 bumperRayOffset;
	}
}
