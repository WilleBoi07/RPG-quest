using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerMovement : MonoBehaviour
{
    private CharacterController characterController; //Ref till vår controller komponent
    private CharacterAnimations playerAnimations;
    public float movementSpeed = 3f; //Ref till vår rörelse hastighet
    public float gravity = 9f; //Ref till vår gravity
    public float rotationSpeed = 0.15f; //Ref till vår rotations hastighet
    public float rotateDegreesPerSecond = 180f; //Ref till hur mycket vi roterar i sekunden 

    private void Awake()
    {
        characterController = GetComponent<CharacterController>(); //Upon Awake, hämta characterController komponenten
        playerAnimations = GetComponent<CharacterAnimations>();
    }
    void Update()
    {
        Move(); //Starta vår Move funktion
        Rotate(); //Starta vår Rotate funktion
        AnimateWalk();
    }
    void Move()
    {
        if (Input.GetAxis(Axis.vertical_axis) > 0) //Om vi rör oss frammåt... 
        {
            Vector3 moveDirection = transform.forward; //Sett vår direction till forward
            moveDirection.y -= gravity * Time.deltaTime; // Sett även vår gravity i relation till rörelsen, och uppdatera mellan 
            characterController.Move(moveDirection * movementSpeed * Time.deltaTime); //Rör oss i relation till character controllern
        }
        else if (Input.GetAxis(Axis.vertical_axis) < 0) //samma om vi rör oss bakåt
        {
            Vector3 moveDirection = -transform.forward;
            moveDirection.y -= gravity * Time.deltaTime;
            characterController.Move(moveDirection * movementSpeed * Time.deltaTime);
        }
        else
        {
            characterController.Move(Vector3.zero);
        }

    }
    void Rotate() //Om vi roterar
    {
        Vector3 rotation_Direction = Vector3.zero;
        if (Input.GetAxis(Axis.horizontal_axis) < 0)
        {
            rotation_Direction = transform.TransformDirection(Vector3.left); //Låter oss rotera åt vänster
        }
        if (Input.GetAxis(Axis.horizontal_axis) > 0)
        {
            rotation_Direction = transform.TransformDirection(Vector3.right); //Låter oss rotera åt höger
        }
        if (rotation_Direction != Vector3.zero)
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(rotation_Direction),
            rotateDegreesPerSecond * Time.deltaTime); ;
        }
    }

    void AnimateWalk()
    {
        if (characterController.velocity.sqrMagnitude != 0)
        {
            playerAnimations.Walk(true);
        }
        else
        {
            playerAnimations.Walk(false);
        }
    }

}
