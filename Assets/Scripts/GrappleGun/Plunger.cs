using UnityEngine;

public class Plunger : MonoBehaviour
{
    public bool isGrappling = false;

    private void OnCollisionEnter(Collision other)
    {
       if (other.gameObject.CompareTag("Grapple"))
       {
            Rigidbody otherRB = other.gameObject.GetComponent<Rigidbody>();
            if (otherRB == null) 
            {
                Debug.Log("Object does not have RB");
            }

         
         FixedJoint joint = gameObject.AddComponent<FixedJoint>();
         joint.connectedBody = otherRB;
         isGrappling = true;  
       }
       else
       {
            isGrappling = false; 
       }
    }

    public void DestroyJoint()
    {
        FixedJoint joint = GetComponent<FixedJoint>();

        if (joint != null)
        {
            Destroy(joint);
        }
    }
}
