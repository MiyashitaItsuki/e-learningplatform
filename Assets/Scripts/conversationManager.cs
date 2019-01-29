using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor.Audio;
using UnityEditor.Animations;

public class conversationManager : MonoBehaviour {
	//public Text[] Conversation = new Text[10];
	[SerializeField] List<string> Sentences;

	private List<string>.Enumerator enumerator;
	public int i = 0; 
	public bool sw = true;
	public Text difftext;
	public Text scenariotext;
	public Text Conversation1_Fade;
	public Text Conversation2_Fade;
	public Text Conversation1;
	public Text Conversation2;
	public AudioClip bakaclip;
	public AudioClip toireclip;
	public AudioSource audiosource;
	public Animator animator;
	// Use this for i nitialization
	void Start () {

		//animator.SetBool("talk", false);
		switch ((sceneManager.pattern >> 16) & 0x00FF)
		{
			case 1:
				difftext.text = "difficulty 1";
				break;
			case 2:
				difftext.text = "difficulty 2";
				break;
			case 3:
				difftext.text = "difficulty 3";
				break;
			case 4:
				difftext.text = "difficulty 4";
				break;
			case 5:
				difftext.text = "difficulty 5";
				break;
			default:
				difftext.text = "shine!!";
				break;
		}
		/*switch (sceneManager.pattern & 0x00FF)
		{
			case 1:
				scenariotext.text = "scenario 1";
				Conversation1_Fade.gameObject.SetActive(true);
				Conversation1.gameObject.SetActive(true); 
				Conversation1_Fade.text = "おはようございます。";
				Conversation1.text = "おはようございます。";
				audiosource.PlayOneShot(toireclip, 1);
				//animationcontroller.parameters.
				break;
			case 2:
				scenariotext.text = "scenario 2";
				Conversation1_Fade.gameObject.SetActive(true);
				Conversation1_Fade.text = "おやすみなさい。";
				audiosource.PlayOneShot(bakaclip, 1);
				break;
			case 3:
				scenariotext.text = "scenario 3";
				break;
			default:
				difftext.text = "bake";
				break;

		}*/
		switch (sceneManager.pattern & 0x00FF)
		{
			case 1:
				scenariotext.text = "scenario 1";
				Conversation1_Fade.gameObject.SetActive(false);
				Conversation1.gameObject.SetActive(false);
				Conversation2_Fade.gameObject.SetActive(false);
				Conversation2.gameObject.SetActive(false);
				//Conversation1.text = "Scenario1";
				Sentences.Add("おはようございます");
				Sentences.Add("今日はいい天気ですね");
				Sentences.Add("一日頑張りましょう");
				audiosource.PlayOneShot(toireclip, 1);
				//animationcontroller.parameters.
				break;
			case 2:
				scenariotext.text = "scenario 2";
				Conversation1_Fade.gameObject.SetActive(true);
				Conversation1_Fade.text = "おやすみなさい。";
				audiosource.PlayOneShot(bakaclip, 1);
				break;
			case 3:
				scenariotext.text = "scenario 3";
				break;
			default:
				difftext.text = "bake";
				break;

		}
	}
	
	public void nextText()
	{
		if(sw)
		{
			Conversation2.gameObject.SetActive(false);
			Conversation2_Fade.gameObject.SetActive(false);

			Conversation1.gameObject.SetActive(true);
			Conversation1_Fade.gameObject.SetActive(true);
			Conversation1.text = Sentences[i];
			Conversation1_Fade.text = Sentences[i];
			i++;
			sw ^= true;
		}
		else
		{
			Conversation1.gameObject.SetActive(false);
			Conversation1_Fade.gameObject.SetActive(false);

			Conversation2.gameObject.SetActive(true);
			Conversation2_Fade.gameObject.SetActive(true);
			Conversation2.text = Sentences[i];
			Conversation2_Fade.text = Sentences[i];
			i++;
			sw ^= true;
	}
	}
	// Update is called once per frame
	void Update () {

	}


}
