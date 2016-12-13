using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour {

	public int energy = 0;
	public int energyCap = 0;

	public void lowerEnergyCap (int amount) {
		energyCap -= amount;
		loseEnergy (amount);

		if (energyCap <= 0) {
			GameOver ();
		}
	}

	public void increaseEnergyCap (int amount) {
		energyCap += amount;
	}

	public void loseEnergy (int amount) {
		energy -= amount;

		// if you lost all of your energy - set to 0
		if (energy < 0) {
			energy = 0;
		}
	}

	public void gainEnergy (int amount) {
		energy += amount;

		// if you went beyond the energy cap - set to energy cap
		if (energy > energyCap) {
			energy = energyCap;
		}
	}

	public void GameOver() {
		Debug.Log ("Game Over");

		// TODO: Send the player to a game over screen
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}
}
