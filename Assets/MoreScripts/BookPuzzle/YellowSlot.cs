using UnityEngine;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class YellowSlot : MonoBehaviour
{
    public bool isSlotFull = false;
    public Transform slot;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("YellowBook"))
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
            otherObj.transform.position = new Vector3(139.278F, 14.243f, -2.518f);
            otherObj.transform.rotation = Quaternion.Euler(0f, 88.363f, 0f);

            grabby.enabled = false;

            isSlotFull = true;
        }
    }
}
