using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MenuUIScript : MonoBehaviour {
	public GameObject infoPanel;
	bool toggle=true;

	public void onStartClick()
	{
		SceneManager.LoadScene (2);
	}

	public void onExitClick()
	{
		Application.Quit ();
	}

	public void onInfo()
	{
		if (toggle) {
			infoPanel.SetActive (true);
			toggle = false;
		} else {
			infoPanel.SetActive (false);
			toggle = true;
		}
	}
}
