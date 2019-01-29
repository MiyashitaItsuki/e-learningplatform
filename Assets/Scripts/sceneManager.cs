using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class sceneManager : MonoBehaviour {

	public static int pattern = 0; // 5 * 5

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void loadSceneMainMenu()
	{
		SceneManager.LoadScene("mainMenu");
	}
	public void loadSceneScenarioSelect()
	{
		SceneManager.LoadScene("scenarioSelect");
	}
	public void loadSceneDifficultySelect(int scenario)
	{
		pattern = pattern | (0x00FF & scenario);
		SceneManager.LoadScene("difficultySelect");
	}

	/*
	 *	0 1 2 3 4
	 *	5 6 .....
	 *  .
	 *  .
	 *  20 21 22 23 24
	 * 
	 * 
	 */
	public void loadSceneConversation(int scenarioAndDifficulty)
	{
		pattern = pattern | ((0x00FF & scenarioAndDifficulty) << 16);
		SceneManager.LoadScene("conversation");
	}

	public void EndApp()
	{
		#if UNITY_EDITOR
			UnityEditor.EditorApplication.isPlaying = false;
		#else
			Application.Quit();
		#endif
	}
	/*public void loadSceneConversation(int scenarioAndDifficulty)
	{
		pattern = pattern | ((0x00FF & scenarioAndDifficulty) << 16);
		SceneManager.LoadScene("conversation");
	}*/

}
