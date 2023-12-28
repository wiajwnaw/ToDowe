using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementHandler : MonoBehaviour {

    private const float SPEED = 50f;

    private PlayerMain playerMain;

    private Vector3 moveDir;
    private Vector3 lastMoveDir;

    public AudioClip OpenDoorSound;  //指定需要播放的音效
    private AudioSource source;   //必须定义AudioSource才能调用AudioClip
   

    private void Start()
    {

        source = GetComponent<AudioSource>();  //将this Object 上面的Component赋值给定义的AudioSource
      
    }
    private void Awake() {
        playerMain = GetComponent<PlayerMain>();
    }

    

    private void Update() 
    {
        HandleMovement();
        /*if (Input.GetKeyDown(KeyCode.W) )
        {
            source.PlayOneShot(OpenDoorSound, 1f);
            source.loop = true;
            source.Play();
        }
        else if(Input.GetKeyUp(KeyCode.W))
        {
            source.Stop();
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            source.PlayOneShot(OpenDoorSound, 1f);
            source.loop = true;
            source.Play();
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            source.Stop();
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            source.PlayOneShot(OpenDoorSound, 1f);
            source.loop = true;
            source.Play();
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            source.Stop();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            source.PlayOneShot(OpenDoorSound, 1f);
            source.loop = true;
            source.Play();
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            source.Stop();
        }*/
    }
    

    private void HandleMovement() {
        float moveX = 0f;
        float moveY = 0f;
        
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) {
            moveY = +1f;
            
                
              

        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) {
            moveY = -1f;
            
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) {
            moveX = -1f;
           
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) {
            moveX = +1f;
            
        }

        moveDir = new Vector3(moveX, moveY).normalized;

        bool isIdle = moveX == 0 && moveY == 0;
        if (isIdle) {
            playerMain.PlayerSwapAimNormal.PlayIdleAnim();
        } else {
            lastMoveDir = moveDir;
            playerMain.PlayerSwapAimNormal.PlayMoveAnim(moveDir);
        }
    }

    private void FixedUpdate() {
        playerMain.PlayerRigidbody2D.velocity = moveDir * SPEED;
    }

    public void Enable() {
        enabled = true;
    }

    public void Disable() {
        enabled = false;
        playerMain.PlayerRigidbody2D.velocity = Vector3.zero;
    }

    public Vector3 GetLastMoveDir() {
        return lastMoveDir;
    }

}
