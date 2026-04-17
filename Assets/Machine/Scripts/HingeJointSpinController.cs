using System.Collections;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UIElements;

public class HingeJointSpinController : MonoBehaviour
{
    [SerializeField] HingeJoint2D hingeJoint;
    [SerializeField] Rigidbody2D rigidbody;
    [SerializeField] float delay;
    [SerializeField] float speed;

    void Awake()
    {
        StartCoroutine(OnFanSpin());
    }

    IEnumerator OnFanSpin()
    {
        JointMotor2D motor = hingeJoint.motor;

        yield return new WaitForSeconds(delay);

        motor.motorSpeed = speed;

        rigidbody.freezeRotation = false;

        hingeJoint.motor = motor;
    }
}
