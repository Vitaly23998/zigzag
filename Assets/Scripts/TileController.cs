using System.Collections;
using UnityEngine;

public class TileController : MonoBehaviour
{
    bool some = false;

    private void Update()
    {
        Fall();
    }

    void OnTriggerEnter(Collider destroyer)
    {
        if (destroyer.CompareTag("Destroyer"))
        {
            some = true;        
        }
    }

    void Fall()
    {
        if(some)
        {
           transform.Translate(0, -1 * Time.deltaTime ,0);
            Delete();
        }
      
    }

    void Delete()
    {
        if (transform.position.y < -4)
        {
            Destroy(gameObject);
        }
    }

}
