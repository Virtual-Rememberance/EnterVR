using UnityEngine;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class GreenSlot : MonoBehaviour
{
  public bool isSlotFull = false;
  public Transform slot;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("GreenBook"))
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
            otherObj.transform.position = new Vector3(135.94F, 14.208f, -2.51f);
            otherObj.transform.rotation = Quaternion.Euler(0f, 446.403f, 0f);

            grabby.enabled = false;

            isSlotFull = true;
        }
    }
}
