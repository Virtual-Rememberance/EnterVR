using UnityEngine;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class PinkSlot : MonoBehaviour
{
    public bool isSlotFull = false;
    public Transform slot;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PinkBook"))
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
            otherObj.transform.position = new Vector3(138.53F, 14.238f, -2.699f);
            otherObj.transform.rotation = Quaternion.Euler(0f, 93.492f, 0f);

            grabby.enabled = false;

            isSlotFull = true;
        }
    }
}

