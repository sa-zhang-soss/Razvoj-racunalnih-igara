using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class PlayerMovement : MonoBehaviour
{
    public float walkspeed = 10f;
    public float runspeed = 20f;
    public float crouchspeed = 2f;

    public float jump = 1f;
    public float gravity = 10f;
    public float yVelocity = 0f;

    public float lookspeed = 2f;
    public float lookspeedMax = 30f;

    public float height = 2f;
    public float crouchheight = 1f;

    public float maxstamina = 3f;
    public float staminareg = 1f;
    public float staminadrain = 1f;

    public Vector2 turn;
    public float mousesens = 1f;
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        

    }

    void Update()
    {
        turn.x += Input.GetAxis("Mouse X") * mousesens;
        turn.y += Input.GetAxis("Mouse Y") * mousesens;
        transform.localRotation = Quaternion.Euler(-turn.y, turn.x, 0);

        //setanje i trcanje
        float currentheight = height;
        float currentstamina = maxstamina;

        bool wantRun = Input.GetKey(KeyCode.LeftShift);
        bool isRun = wantRun && currentstamina > 0f;

        

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        if (isRun)
        {
            currentstamina -= staminadrain * Time.deltaTime;
        }
        else
        {
            currentstamina += staminareg * Time.deltaTime;
        }

        float currentSpeed = isRun ? runspeed : walkspeed;

        //cucenje
        if (Input.GetKey(KeyCode.C))
        {
            currentSpeed = crouchspeed;
            currentheight = crouchheight;

        }

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        transform.Translate(movement * currentSpeed * Time.deltaTime);


        //skok
        if (transform.position.y <= 1f) 
        {
            yVelocity = 0f;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                yVelocity = jump;
            }
        }
        else
        {
            yVelocity -= gravity * Time.deltaTime;
        }

        Vector3 ymovement = new Vector3(moveHorizontal, yVelocity, moveVertical);
        transform.Translate(ymovement * currentSpeed * Time.deltaTime, Space.Self);

        
    }
}
