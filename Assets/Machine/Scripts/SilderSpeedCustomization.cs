using System.Collections;
using UnityEngine;

public class SliderSpeedCustomization : MonoBehaviour
{
    [SerializeField] SliderJoint2D sliderJoint;
    [SerializeField] float delay;
    [SerializeField] float speed;

    void Awake()
    {
        StartCoroutine(enableMotor());
    }

    IEnumerator enableMotor()
    {
        JointMotor2D motor = sliderJoint.motor;

        yield return new WaitForSeconds(delay);

        motor.motorSpeed = speed;

        sliderJoint.motor = motor;
    }
}
