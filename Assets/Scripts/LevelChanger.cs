using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour {

	public Animator animator;
	public int sceneToLoadIndex;
	
	void Update () {
		if (Input.GetKeyDown("p")){
			FadeToLevel(1);
		}
	}
	

	public void FadeToLevel(int sceneIndex){
		sceneToLoadIndex = sceneIndex;
		animator.SetTrigger("FadeOutAnim");
	}

	public void OnFadeComplete(){
		SceneManager.LoadScene(sceneToLoadIndex);
	}

}
