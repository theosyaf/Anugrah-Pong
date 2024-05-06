using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreController : MonoBehaviour
{
    public TextMeshProUGUI skorKiri; 
    public TextMeshProUGUI skorKanan; 
 
    public ScoreManager manager; 

    private void Update() 
    { 
        skorKiri.text = manager.LeftScore.ToString(); 
        skorKanan.text = manager.RightScore.ToString(); 
    } 
}
