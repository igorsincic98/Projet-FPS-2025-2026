using UnityEngine;
using UnityEngine.AI;

public class TrapController : MonoBehaviour
{
    [SerializeField] private TrapOpeningAnim doorOpen;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            doorOpen.TrapOpening();
        }
    }
}
