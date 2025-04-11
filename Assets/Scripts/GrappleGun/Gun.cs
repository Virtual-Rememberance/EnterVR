using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField]
    public GameObject plunger;

    public float plungerSpeed;

    [SerializeField] Transform barrel;

    Transform plungerPos;

    Rigidbody plungerRB;

    Plunger plungerScript;

    public bool hasBeenShot { get; set; }

    public void Start()
    {
        plungerPos = plunger.transform;
        plungerRB = plunger.GetComponent<Rigidbody>();
        plungerScript = gameObject.GetComponent<Plunger>();
    }

    public void Update()
    {
        if (!hasBeenShot)
        {
            plungerPos.position = barrel.position;
            plungerPos.forward = barrel.forward;
        }

    }

    public void Fire()
   {
        hasBeenShot = true;
        plungerPos.position = barrel.position;
        plungerRB.angularVelocity = barrel.forward * plungerSpeed;

   }

   public void CancelFire()
   {
        hasBeenShot = false;
        plungerScript.DestroyJoint();

   } 
}
