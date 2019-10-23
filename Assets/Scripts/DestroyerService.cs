using UnityEngine;

public class DestroyerService : MonoBehaviour
{
    public Transform PlayerTransform;

    void Update()
    {
        transform.position = PlayerTransform.position;
    }
}
