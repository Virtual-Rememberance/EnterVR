using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField]
    public GameObject plunger;

    public float plungerSpeed;

    Transform plungerPos;

    [SerializeField] Transform barrel;

    Rigidbody plungerRB;

    private void Start()
    {
        plungerPos = plunger.transform;
        plungerRB = plunger.GetComponent<Rigidbody>();  
    }

   public void Fire()
    {
        plungerPos.position = barrel.position;
        plungerRB.angularVelocity = barrel.forward * plungerSpeed;

    }
}
