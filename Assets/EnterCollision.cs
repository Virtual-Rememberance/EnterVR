using UnityEngine;

public class EnterCollision : MonoBehaviour
{
    [SerializeField] private GameObject parentNinjaStar;
    [SerializeField] private Rigidbody nsRB;

    private void Start()
    {
        parentNinjaStar = gameObject.transform.parent.transform.parent.gameObject;
        nsRB = parentNinjaStar.GetComponent<Rigidbody>();
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
