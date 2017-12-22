using UnityEngine;
using UnityEngine.UI;

public class StarController : MonoBehaviour
{
	public Camera MainCamera;

	// Use this for initialization
	public void Start()
	{
	}
	
	// Update is called once per frame
	public void LateUpdate()
	{
		var starName = GetComponentInChildren<Text>();
		var newPosition = new Vector3(starName.transform.position.x, starName.transform.position.y, MainCamera.orthographicSize + 100);

		starName.transform.position = newPosition;
	}

	public void OnMouseDown()
	{
		MainCamera.transform.position = new Vector3(transform.position.x, transform.position.y, MainCamera.transform.position.z);
	}
}
