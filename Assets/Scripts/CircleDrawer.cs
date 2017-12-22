using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleDrawer : MonoBehaviour
{
	public float ThetaScale = 0.01f;
	public float Radius = 3f;

	private int _size;
	private LineRenderer _lineDrawer;
	private float _theta = 0f;

	void Start()
	{
		_lineDrawer = GetComponent<LineRenderer>();
	}

	void Update()
	{
		_theta = 0f;
		_size = (int)((1f / ThetaScale) + 2f);
		_lineDrawer.positionCount = _size;

		for (int i = 0; i < _size; i++)
		{
			_theta += (2.0f * Mathf.PI * ThetaScale);
			float x = Radius * Mathf.Cos(_theta);
			float y = Radius * Mathf.Sin(_theta);
			_lineDrawer.SetPosition(i, new Vector3(x, y, 0));
		}
	}
}
