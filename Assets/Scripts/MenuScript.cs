using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MenuScript : MonoBehaviour {

	public Canvas quitMenu;

	public Button startText;
	public Button optionsText;
	public Button creditsText;
	public Button exitText;

	public Image quitScreen;

	public Transform mainCamera;


	// Use this for initialization
	void Start () {
		quitMenu = quitMenu.GetComponent<Canvas> ();

		startText = startText.GetComponent<Button> ();
		optionsText = optionsText.GetComponent<Button> ();
		creditsText = creditsText.GetComponent<Button> ();
		exitText = exitText.GetComponent<Button> ();

		quitScreen = quitScreen.GetComponent<Image> ();

		mainCamera = mainCamera.GetComponent<Transform> ();

		quitMenu.enabled = false;
	}

	void Update() {
		if (quitMenu.enabled) {
			if (Input.GetMouseButtonDown (0)) {
				if (!quitScreen.rectTransform.rect.Contains(Input.mousePosition - mainCamera.position)) {
					NoPress ();
				}
			}
		}
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
