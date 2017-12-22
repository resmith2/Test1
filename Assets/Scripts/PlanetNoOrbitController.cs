using UnityEngine;

namespace Assets.Scripts
{
	public class PlanetNoOrbitController : MonoBehaviour
	{
		public TrailRenderer Trail;
		public Camera Camera;
		public float RotationPerDay;

		// Use this for initialization
		public void Start()
		{
			Trail.time = float.MaxValue;
		}

		// Update is called once per frame
		public void LateUpdate()
		{
			transform.RotateAround(Vector3.zero, Vector3.forward, RotationPerDay);
			var nameCanvas = GetComponentInChildren<Canvas>();
			nameCanvas.transform.rotation = Quaternion.LookRotation(Vector3.forward, Vector3.up);
		}

		public void OnMouseDown()
		{
			Camera.transform.position = new Vector3(transform.position.x, transform.position.y, Camera.transform.position.z);
		}
	}
}