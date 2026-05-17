using UnityEngine;

public class ItemPickUp : MonoBehaviour
{
    [SerializeField] public bool isDrill;
    [SerializeField] public bool isPick;
    [SerializeField] 
    private InventoryController inventoryController;

    // Use OnTriggerEnter � works with CharacterController
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (isDrill)
            {
                PlayerController.Instance.PickUpDrill();
                Debug.Log("Drill destory");
            }
            else if (isPick)
            {
                PlayerController.Instance.PickUpPick();
                //inventoryController.AddItem("pickaxe");
                Debug.Log("Pick destory");
            }
            Destroy(gameObject);
        }
    }
}