using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class CarController : MonoBehaviour
{
    public float speed = 1500f;

    private float movement = 0f;

    public int count = 0;

    public WheelJoint2D backWheel;
    public WheelJoint2D frontWheel;

    public TMP_Text score;

    void Update()
    {
        movement = -Input.GetAxisRaw("Vertical") * speed;
        score.text = count.ToString();

        if (Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene(1);
        }

    }

    void FixedUpdate()
    {
        if (movement == 0f)
        {
            backWheel.useMotor = false;
            frontWheel.useMotor = false;
        }
        else
        {
            backWheel.useMotor = true;
            JointMotor2D motor = new JointMotor2D { motorSpeed = movement, maxMotorTorque = backWheel.motor.maxMotorTorque };
            backWheel.motor = motor;
            frontWheel.motor = motor;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        count++;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        count--;
    }
}
