using System;
using UnityEngine;

namespace Cinemachine
{
	[Serializable]
	public struct LensSettings
	{
		public LensSettings(float fov, float orthographicSize, float nearClip, float farClip, float dutch) : this()
		{
		}

		public float FieldOfView;
		public float OrthographicSize;
		public float NearClipPlane;
		public float FarClipPlane;
		public float Dutch;
		public Vector2 LensShift;
	}
}
