using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MenuScript : MonoBehaviour {

	public Canvas quitMenu;

	public Button startText;
	public Button optionsText;
	public Button creditsText;
	public Button exitText;


	// Use this for initialization
	void Start () {
		quitMenu = quitMenu.GetComponent<Canvas> ();

		startText = startText.GetComponent<Button> ();
		optionsText = startText.GetComponent<Button> ();
		creditsText = startText.GetComponent<Button> ();
		exitText = startText.GetComponent<Button> ();

		quitMenu.enabled = false;
	}
		
	public void PlayPress() {
		// Application.LoadLevel(1);
	}

	public void OptionsPress() {
		
	}

	public void CreditsPress() {

	}
	
	public void ExitPress() {
		quitMenu.enabled = true;

		startText.enabled = false;
		optionsText.enabled = false;
		creditsText.enabled = false;
		exitText.enabled = false;
	}

	public void YesPress() {
		Application.Quit ();
	}

	public void NoPress() {
		quitMenu.enabled = false;

		startText.enabled = true;
		optionsText.enabled = true;
		creditsText.enabled = true;
		exitText.enabled = true;
	}
		
}
