using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour {

	public void StartGame () {
		SceneManager.LoadScene(1);
	}
}
