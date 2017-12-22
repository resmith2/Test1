using UnityEngine;

public class CameraController : MonoBehaviour
{
	public Camera MainCamera;

	// Update is called once per frame
	public void LateUpdate()
	{
		var horizontal = Input.GetAxis("Horizontal");
		var vertical = Input.GetAxis("Vertical");
		var height = Input.GetAxis("Mouse ScrollWheel");

		if (MainCamera.orthographicSize < 11)
		{
			horizontal *= .05f;
			vertical *= .05f;
			height *= -5f;
		}
		else if (MainCamera.orthographicSize < 101)
		{
			horizontal *= .5f;
			vertical *= .5f;
			height *= -50f;
		}
		else
		{
			horizontal *= 5f;
			vertical *= 5f;
			height *= -500f;
		}

		var movement = new Vector3(horizontal, vertical, 0f);
		MainCamera.orthographicSize += height;
		transform.position += movement;

		if (MainCamera.orthographicSize < 1)
		{
			MainCamera.orthographicSize = 1;
		}
	}

	public void ResetPosition()
	{
		transform.position = new Vector3(0, 0, -10f);
	}
}
