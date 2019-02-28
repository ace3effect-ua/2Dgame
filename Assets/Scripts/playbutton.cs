using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playbutton : MonoBehaviour
{
	public Animator animator;

	public void StartButtonClicked() {
		animator.SetBool("Exit", true);

		SceneManager.LoadScene( 1 );


	}
}
