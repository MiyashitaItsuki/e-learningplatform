using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diffObjManager : MonoBehaviour {
	public GameObject diffText;
	public GameObject diff1;
	public GameObject diff2;
	public GameObject diff3;
	public GameObject diff4;
	public GameObject diff5;
	public GameObject back;
	public float width;
	public float height;
	// Use this for initialization
	void Start()
	{
		width = Screen.width;
		height = Screen.height;
		diffText.GetComponent<RectTransform>().sizeDelta = new Vector2(width * (float)0.3, height * (float)0.1);
		diffText.GetComponent<RectTransform>().position = new Vector2(width / 2, (height / 2) + 500);

		diff1.GetComponent<RectTransform>().sizeDelta = new Vector2(width * (float)0.5, height * (float)0.1);
		diff1.GetComponent<RectTransform>().position = new Vector2(width / 2, diffText.GetComponent<RectTransform>().position.y - diffText.GetComponent<RectTransform>().sizeDelta.y);

		diff2.GetComponent<RectTransform>().sizeDelta = new Vector2(diff1.GetComponent<RectTransform>().sizeDelta.x, diff1.GetComponent<RectTransform>().sizeDelta.y);
		diff2.GetComponent<RectTransform>().position = new Vector2(width / 2, diff1.GetComponent<RectTransform>().position.y - (diff1.GetComponent<RectTransform>().sizeDelta.y) * (float)1.5);

		diff3.GetComponent<RectTransform>().sizeDelta = new Vector2(diff2.GetComponent<RectTransform>().sizeDelta.x, diff2.GetComponent<RectTransform>().sizeDelta.y);
		diff3.GetComponent<RectTransform>().position = new Vector2(width / 2, diff2.GetComponent<RectTransform>().position.y - (diff2.GetComponent<RectTransform>().sizeDelta.y) * (float)1.5);

		diff4.GetComponent<RectTransform>().sizeDelta = new Vector2(diff3.GetComponent<RectTransform>().sizeDelta.x, diff3.GetComponent<RectTransform>().sizeDelta.y);
		diff4.GetComponent<RectTransform>().position = new Vector2(width / 2, diff3.GetComponent<RectTransform>().position.y - (diff3.GetComponent<RectTransform>().sizeDelta.y) * (float)1.5);

		diff5.GetComponent<RectTransform>().sizeDelta = new Vector2(diff4.GetComponent<RectTransform>().sizeDelta.x, diff4.GetComponent<RectTransform>().sizeDelta.y);
		diff5.GetComponent<RectTransform>().position = new Vector2(width / 2, diff4.GetComponent<RectTransform>().position.y - (diff4.GetComponent<RectTransform>().sizeDelta.y) * (float)1.5);

		back.GetComponent<RectTransform>().sizeDelta = new Vector2(width * (float)0.15, height * (float)0.02);
		back.GetComponent<RectTransform>().position = new Vector2(width - 100, 100);
	}

	
	// Update is called once per frame
	void Update () {
		
	}
}
