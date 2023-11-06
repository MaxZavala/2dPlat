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

    public void assign_player_position(float x_direction) {

       
        playerTransform.position = new Vector3(playerTransform.position.x + x_direction, playerTransform.position.y, playerTransform.position.z);

    }

    

    public void updateVisuals()
    {

        

        //get inputs
        if (Input.GetKeyDown(KeyCode.A))
        {
            assign_player_position(-1f);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            assign_player_position(1f);

        }
      
            
  

    }
}







            




  