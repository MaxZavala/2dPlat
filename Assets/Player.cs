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

       
        playerTransform.position = new Vector3(playerTransform.position.x + x_direction, playerTransform.position.y+ y_direction, playerTransform.position.z);

    }

    

    public void updateVisuals()
    {

        

        //get inputs
        if (Input.GetKeyDown(KeyCode.A))
        {
            assign_player_position(x_direction: -1f);
             Debug.Log("you have uped");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            assign_player_position(x_direction: 1f);
            Debug.Log("you have righted");

        }
        if(Input.GetButtonDown("Jump")){
            Debug.Log("you have jumped");
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            assign_player_position(y_direction: 1f);
            Debug.Log("you have uped");

        }
        }
}







            




  