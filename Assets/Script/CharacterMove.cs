using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float mouseSpeed = 1f;
    public float camDistance;
    public GameObject Player;
    private Animator animator;


    void Playeranimation()
    {
        if (Input.GetKey(KeyCode.W) ^ Input.GetKey(KeyCode.A) ^ Input.GetKey(KeyCode.S) ^ Input.GetKey(KeyCode.D))
            animator.SetBool("Run", true);
        if (!(Input.GetKey(KeyCode.W) ^ Input.GetKey(KeyCode.A) ^ Input.GetKey(KeyCode.S) ^ Input.GetKey(KeyCode.D)))
            animator.SetBool("Run", false);
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A) ^ (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D)))
            animator.SetBool("Run", true);
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A) ^ (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D)))
            animator.SetBool("Run", true);
    }
    void PlayerMove()
    {
        if (Input.GetKey(KeyCode.W))
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.A))
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.S))
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.D))
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
           
    }
 
        void Start()
        {
            animator = Player.GetComponent<Animator>();
            Cursor.lockState = CursorLockMode.Confined;//마우스 가두기 
           

        }
        void Update()
        {
            PlayerMove();
            transform.Rotate(0f, Input.GetAxis("Mouse X") * mouseSpeed, 0f, Space.Self); //마우스 회전
            Playeranimation();
         
        }
    }


