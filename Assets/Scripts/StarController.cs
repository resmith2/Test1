using UnityEngine;
using UnityEngine.UI;

public class StarController : MonoBehaviour
{
	public Camera MainCamera;

	private Vector3 _labelStartingPosition;

	// Use this for initialization
	public void Start()
	{
		_labelStartingPosition = new Vector3(10, 10, 0);
	}

	// Update is called once per frame
	public void LateUpdate()
	{
		var starName = GetComponentInChildren<Text>();
		var newPosition = new Vector3(starName.transform.position.x, starName.transform.position.y, MainCamera.orthographicSize + 100);

		starName.transform.position = newPosition;

		if (MainCamera.orthographicSize <= 100)
			starName.fontSize = 10;
		else
			starName.fontSize = (int)MainCamera.orthographicSize / 10;
	}

	public void OnMouseDown()
	{
		MainCamera.transform.position = new Vector3(transform.position.x, transform.position.y, MainCamera.transform.position.z);
	}
}
