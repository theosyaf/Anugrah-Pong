using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScript : MonoBehaviour
{
    [SerializeField]
    public int speed;
    [SerializeField]
    public KeyCode upKey, downKey; 

    private Rigidbody2D rig; 
 
    private void Start() 
    { 
        rig = GetComponent<Rigidbody2D>(); 
    } 

    private void Update() 
    { 
        MoveObject(GetInput()); 
    }

    private Vector2 GetInput() 
    { 
        if (Input.GetKey(upKey)){
            return Vector2.up * speed;
        }
        else if (Input.GetKey(downKey))
        {
            return Vector2.down * speed;
        }

        return Vector2.zero;

    }

    private void MoveObject(Vector2 movement) {
        rig.velocity = movement;
    }
}
