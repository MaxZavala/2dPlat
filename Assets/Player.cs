using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //stores local transform
    public Transform playerTransform;

    public Rigidbody2D playerRidgedBody;

    // Start is called before the first frame update
    void Start()
    {
        
        
    }
   

    // Update is called once per frame
    void Update()
    {

        updateVisuals();

    }

    public void assign_player_position(float x_direction=0f, float y_direction=0f) {

        if (playerTransform != null)
        {
            playerTransform.position = new Vector3(playerTransform.position.x + x_direction, playerTransform.position.y + y_direction, playerTransform.position.z);
        }
        else { playerTransform = this.transform; }
    }



    public void updateVisuals()
    {


        
        //get inputs
        if (Input.GetKeyDown(KeyCode.A )       ||  Input.GetKeyDown(KeyCode.LeftArrow)  )
        {
            assign_player_position(x_direction: -1f);
            Debug.Log("you have uped");
        }
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            assign_player_position(x_direction: 1f);
            Debug.Log("you have righted");

        }
        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("you have jumped");
        }
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            assign_player_position(y_direction: 1f);
            Debug.Log("you have uped");

        }
        
        
    }
}







            




  