using UnityEngine;

public class Plunger : MonoBehaviour
{
    FixedJoint joint;
    private void OnCollisionEnter(Collision other)
    {
        if (other != null)
        {
            if (other.gameObject.CompareTag("Grapple"))
            {
                joint = gameObject.GetComponent<FixedJoint>();
                joint.connectedBody = other.gameObject.GetComponent<Rigidbody>();

            }
        }
    }

    public void DestroyJoint()
    {
        Destroy(joint);
    }
}
