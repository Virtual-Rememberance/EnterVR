using UnityEngine;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class BlueSlot : MonoBehaviour
{
  public bool isSlotFull = false;
  public Transform slot;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("BlueBook"))
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
            otherObj.transform.position = new Vector3(136.948F, 14.223f, -2.814f);
            otherObj.transform.rotation = Quaternion.Euler(0f, 90.769f, 0f);

            grabby.enabled = false;

            isSlotFull = true;
        }
    }
}
