using System.Linq;
using UnityEngine;

public class PlanetController : MonoBehaviour
{
	// Use this for initialization
	void Start ()
	{
	}

	// Update is called once per frame
	void LateUpdate()
	{
		float degPerSec = 1f;
		transform.RotateAround(Vector3.zero, Vector3.forward, degPerSec);
		var nameCanvas = GetComponentsInChildren<Canvas>().First();
		nameCanvas.transform.rotation = Quaternion.LookRotation(Vector3.forward, Vector3.up);
	}
}
