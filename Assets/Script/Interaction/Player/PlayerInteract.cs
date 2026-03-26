using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    private Camera cam;

    [SerializeField]
    private float distance = 3f;
    [SerializeField]
    private LayerMask mask;
    [SerializeField] private GameObject textMessage;
    [SerializeField] private Transform CanvasTransform;
    private PlayerInput.OnFootActions onFoot;
    private PlayerInput playerInput;

    private PlayerUI playerUI;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cam = GetComponent<PlayerLook>().cam;
        playerInput = new PlayerInput();
        onFoot = playerInput.OnFoot;
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(cam.transform.position, cam.transform.forward);
        Debug.DrawRay(ray.origin, ray.direction * distance, Color.white);
        RaycastHit hitInfo;
        if (Physics.Raycast(ray, out hitInfo, distance, mask) == GameObject.FindGameObjectWithTag("Interactive"))

        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("Key Pressed");
                hitInfo.collider.gameObject.GetComponent<Interactable>().Interacting();
                Debug.Log("Message Sent");

            }
            if (GameObject.FindGameObjectsWithTag("ItemPrompt"). Length < 1)
            {
                GameObject prompt = Instantiate(textMessage, CanvasTransform);
                prompt.GetComponent<TextMeshProUGUI>().text =
                    (hitInfo.transform.GetComponent<Interactable>().promptMessage);
            }
        }
        else Destroy(GameObject.FindGameObjectWithTag("ItemPrompt"));
        

    }



}
