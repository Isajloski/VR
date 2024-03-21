using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Transform camera;
    private CharacterController character;
    private float speed = 2;
    public AudioSource walking;
    private bool flag = true;


    
    void Start(){
    	character = GetComponent<CharacterController>();
    }

    void Update(){
      if(camera.eulerAngles.x >= 35.0 && camera.eulerAngles.x < 80.0){
      
      	if(flag == true){
			walking.Play();
			flag = false;
      	}

      
    		Vector3 forward = camera.TransformDirection(Vector3.forward);
		character.SimpleMove(forward * speed);
    	}
    	else{
		walking.Stop();
		flag = true;
	}

    }
}

