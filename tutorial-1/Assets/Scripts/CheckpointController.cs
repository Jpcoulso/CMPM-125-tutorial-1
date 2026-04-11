using UnityEngine;

public class CheckpointController : MonoBehaviour
{

    public CheckpointController next;
    public MeshRenderer left;
    public MeshRenderer right;
    private void OnTriggerEnter(Collider other)
    {
        vehicleController vehicle = other.gameObject.GetComponent<vehicleController>();
        if (vehicle != null)
        {
            if (this == vehicle.target)
            {
                vehicle.target = next;
            }
            next.left.materials[0].color = Color.red;
            next.right.materials[0].color = Color.red;
            left.materials[0].color = Color.white;
            right.materials[0].color = Color.white;
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
