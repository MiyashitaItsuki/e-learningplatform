using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scenarioObjManager : MonoBehaviour {
	public GameObject scenarioText;
	public GameObject scenario1;
	public GameObject scenario2;
	public GameObject scenario3;
	public GameObject scenario4;
	public GameObject scenario5;
	public GameObject back;
	public float width;
	public float height;
	// Use this for initialization
	void Start () {
		width = Screen.width;
		height = Screen.height;
		scenarioText.GetComponent<RectTransform>().sizeDelta = new Vector2(width * (float)0.3, height * (float)0.1);
		scenarioText.GetComponent<RectTransform>().position = new Vector2(width / 2, (height / 2) + 500);

		scenario1.GetComponent<RectTransform>().sizeDelta = new Vector2(width * (float)0.5, height * (float)0.1);
		scenario1.GetComponent<RectTransform>().position = new Vector2(width / 2, scenarioText.GetComponent<RectTransform>().position.y -scenarioText.GetComponent<RectTransform>().sizeDelta.y);

		scenario2.GetComponent<RectTransform>().sizeDelta = new Vector2(scenario1.GetComponent<RectTransform>().sizeDelta.x, scenario1.GetComponent<RectTransform>().sizeDelta.y);
		scenario2.GetComponent<RectTransform>().position = new Vector2(width / 2, scenario1.GetComponent<RectTransform>().position.y - (scenario1.GetComponent<RectTransform>().sizeDelta.y)*(float)1.5);

		scenario3.GetComponent<RectTransform>().sizeDelta = new Vector2(scenario2.GetComponent<RectTransform>().sizeDelta.x, scenario2.GetComponent<RectTransform>().sizeDelta.y);
		scenario3.GetComponent<RectTransform>().position = new Vector2(width / 2, scenario2.GetComponent<RectTransform>().position.y - (scenario2.GetComponent<RectTransform>().sizeDelta.y) * (float)1.5);

		scenario4.GetComponent<RectTransform>().sizeDelta = new Vector2(scenario3.GetComponent<RectTransform>().sizeDelta.x, scenario3.GetComponent<RectTransform>().sizeDelta.y);
		scenario4.GetComponent<RectTransform>().position = new Vector2(width / 2, scenario3.GetComponent<RectTransform>().position.y - (scenario3.GetComponent<RectTransform>().sizeDelta.y) * (float)1.5);

		scenario5.GetComponent<RectTransform>().sizeDelta = new Vector2(scenario4.GetComponent<RectTransform>().sizeDelta.x, scenario4.GetComponent<RectTransform>().sizeDelta.y);
		scenario5.GetComponent<RectTransform>().position = new Vector2(width / 2, scenario4.GetComponent<RectTransform>().position.y - (scenario4.GetComponent<RectTransform>().sizeDelta.y) * (float)1.5);

		back.GetComponent<RectTransform>().sizeDelta = new Vector2(width * (float)0.15, height * (float)0.02);
		back.GetComponent<RectTransform>().position = new Vector2(width - 100,100);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
