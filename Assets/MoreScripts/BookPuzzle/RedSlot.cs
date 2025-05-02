using UnityEngine;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class RedSlot : MonoBehaviour
{
    public bool isSlotFull = false;
    public Transform slot;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("RedBook"))
        {
            GameObject otherObj = other.gameObject;
            Rigidbody rb = otherObj.GetComponent<Rigidbody>();
            XRGrabInteractable grabby = other.GetComponent<XRGrabInteractable>();

            if (rb != null)
            {
                rb.angularVelocity = Vector3.zero;
                rb.linearVelocity = Vector3.zero;
                rb.isKinematic = true;
            }

            otherObj.transform.parent = slot;
            otherObj.transform.position = new Vector3(137.729F, 14.225f, -2.564f);
            otherObj.transform.rotation = Quaternion.Euler(0f, 91.046f, 0f);

            grabby.enabled = false;

            isSlotFull = true;
        }
    }
}
