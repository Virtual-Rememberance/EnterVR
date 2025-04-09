using UnityEngine;

public class Plunger : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other != null)
        {
            if (other.gameObject.CompareTag("Grapple"))
            {

            }
        }
    }
}
