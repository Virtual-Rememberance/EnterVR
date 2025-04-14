using UnityEngine;

public class Plunger : MonoBehaviour
{
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
