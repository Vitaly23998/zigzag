using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed;
    //false - z, true - x;
    private bool PlayerSide = true;
    public static bool die;

    private void Start()
    {
        die = false;
    }

    private void Update()
    {
        Dying();
        SideChangeInput();
        PlayerEngine();
    }

    void SideChangeInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            PlayerSide = !PlayerSide;
        }
    }

   void PlayerEngine()
    {
        if (PlayerSide)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * Speed);
            return;
        }
        transform.Translate(Vector3.right * Time.deltaTime * Speed);
    }

    void Dying()
    {
        if(transform.position.y < -1)
        {
            die = true;
        }
    }
}
