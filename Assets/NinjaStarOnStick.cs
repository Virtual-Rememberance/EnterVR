using UnityEngine;

public class NinjaStarStick : MonoBehaviour
{
    [SerializeField] private Rigidbody nsRB;

    private void Start()
    {
        nsRB = gameObject.GetComponent<Rigidbody>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Target")
        {
            nsRB.linearVelocity = Vector3.zero;
            nsRB.angularVelocity = Vector3.zero;
            nsRB.isKinematic = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        nsRB.isKinematic = false;
    }
}