using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MainSceneUIScript : MonoBehaviour {

	bool infoToggle=true;
	public GameObject infoText;

	void Start()
	{
		infoText.SetActive (false);
		infoToggle=true;
	}

	public void onBackClick()
	{
		SceneManager.LoadScene (1);
	}

	public void onInfoClick()
	{
		if (infoToggle) {
			infoText.SetActive (true);
			infoToggle = false;
		} else {
			infoText.SetActive (false);
			infoToggle = true;
		}
	}
}
