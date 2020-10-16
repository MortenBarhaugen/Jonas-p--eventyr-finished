using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

//HOW TO USE:: 
//make a new "C# Script" in the project tab and give it the name "SceneLoad"
//open up the new script and paste the entire contents
//attach the new script to your player object
//Create a new GameObject, adding one of the Collider2D components
//check the "is trigger" box for the collider settings

public class SceneSwitch2 : MonoBehaviour
{


	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Finish")
		{
			Debug.Log("GOGOGOGO SCENE");
			SceneManager.LoadScene("Rom 3"); //load this scene... change SCENENAME to the name of the scene you want
		}
	}
}
