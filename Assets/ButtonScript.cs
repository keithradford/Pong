using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    public void SinglePlayer(){
    	// When AI is implemented
    }
    public void MultiPlayer(){
    	SceneManager.LoadScene("Game");
    }
}
