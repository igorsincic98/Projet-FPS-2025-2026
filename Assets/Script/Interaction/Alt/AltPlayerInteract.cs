using UnityEngine;

public class AltPlayerInteract : MonoBehaviour
{
    private Camera cam;

    [SerializeField]
    private float distance = 3f;
    [SerializeField]
    private LayerMask mask;
    [SerializeField] private GameObject textMessage;
    [SerializeField] private Transform CanvasTransform;

    private PlayerUI playerUI;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cam = GetComponent<AltPlayerLook>().cam;
    }

    // Update is called once per frame
    void Update()
    {
    }

    void Interact()
    {
        Ray ray = new Ray(cam.transform.position, cam.transform.forward);
        Debug.DrawRay(ray.origin, ray.direction * distance);
        RaycastHit hitInfo;
        if (Physics.Raycast(ray, out hitInfo, distance, mask))
        {
            if (hitInfo.collider.GetComponent<AltInteractable>() != null)
            {
                GameObject instantiate = Instantiate(textMessage, CanvasTransform);
                Debug.Log(hitInfo.collider.GetComponent<AltInteractable>().promptMessage);
            }
        }
    }
}
