using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainMenuObjManager: MonoBehaviour {
	public GameObject title;
	public GameObject startButton;
	public GameObject quitButton;
	public GameObject scoreButton;
	public float width;
	public float height;
	// Use this for initialization
	void Start () {
		width = Screen.width;
		height = Screen.height;
	}

	// Update is called once per frame
	void Update() {
		title.GetComponent<RectTransform>().sizeDelta = new Vector2(width*(float)0.8, height*(float)0.3);
		title.GetComponent<RectTransform>().position = new Vector2(width/2, (height / 2)+400);

		startButton.GetComponent<RectTransform>().sizeDelta = new Vector2(width * (float)0.6, height * (float)0.1);
		startButton.GetComponent<RectTransform>().position = new Vector2(width/2, title.GetComponent<RectTransform>().position.y - title.GetComponent<RectTransform>().sizeDelta.y);

		quitButton.GetComponent<RectTransform>().sizeDelta = new Vector2(startButton.GetComponent<RectTransform>().sizeDelta.x, startButton.GetComponent<RectTransform>().sizeDelta.y);
		quitButton.GetComponent<RectTransform>().position = new Vector2(startButton.GetComponent<RectTransform>().position.x, startButton.GetComponent<RectTransform>().position.y - (startButton.GetComponent<RectTransform>().sizeDelta.y)*2);

		scoreButton.GetComponent<RectTransform>().sizeDelta = new Vector2(quitButton.GetComponent<RectTransform>().sizeDelta.x, quitButton.GetComponent<RectTransform>().sizeDelta.y);
		scoreButton.GetComponent<RectTransform>().position = new Vector2(quitButton.GetComponent<RectTransform>().position.x, quitButton.GetComponent<RectTransform>().position.y - (quitButton.GetComponent<RectTransform>().sizeDelta.y)*2);

	}
}
