using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void PlayGame(){
        SceneManager.LoadScene("Game");
        Debug.Log("Created By Anugah");
    }

    public void OpenAuthor(){
        Debug.Log("Created By Anugah");
    }
}
