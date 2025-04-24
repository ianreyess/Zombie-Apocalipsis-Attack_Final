using UnityEngine;

public class DeactivateInSeconds : MonoBehaviour
{
    [SerializeField]
    private float secondsToDeactivate = 5f;
    
    private void OnEnable()
    {
        Invoke("DeactivateObject", secondsToDeactivate);
    }

    private void DeactivateObject()
    {
        gameObject.SetActive(false);
    }
}
