using UnityEngine;

public class CameraController : MonoBehaviour
{
	public Camera MainCamera;

	// Update is called once per frame
	public void LateUpdate()
	{

		var horizontal = Input.GetAxis("Horizontal") * 50;
		var vertical = Input.GetAxis("Vertical") * 50;
		var height = Input.GetAxis("Mouse ScrollWheel") * -500;

		var movement = new Vector3(horizontal, vertical, 0f);
		MainCamera.orthographicSize += height;

		transform.position += movement;

		if (MainCamera.orthographicSize < 10)
		{
			MainCamera.orthographicSize = 10;
		}
	}

	public void ResetPosition()
	{
		transform.position = new Vector3(0, 0, -10f);
	}
}
