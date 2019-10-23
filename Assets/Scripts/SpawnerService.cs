using UnityEngine;

public class SpawnerService : MonoBehaviour
{
    //false - z, true - x;
    private bool TileSide = true;
    public Transform PlayerTransform;
    public GameObject Tile;
    public GameObject Crystall;

    void Update()
    {
     if(PlayerTransform.position.x + 10 > transform.position.x || PlayerTransform.position.z + 10 > transform.position.z)
        {
            var tilelenght = Random.Range(1, 7);
            for (int i = 0; i < tilelenght; i++)
            {
                SpawnerEngine();
                CrystallSpawner();
                TileSpawner();
            }

            TileSide = !TileSide;
        }
    }

    void TileSpawner()
    {
        Instantiate(Tile, transform.position, Quaternion.identity);
    }

    private void CrystallSpawner()
    {
        var crystallchance = 0.2f;
        if (Random.value < crystallchance)
            Instantiate(Crystall, new Vector3(transform.position.x, 0.3f, transform.position.z), Quaternion.Euler(90, 0, 0));
    }

    void SpawnerEngine()
    {
        if (TileSide)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 1);
            return;
        }
        transform.position = new Vector3(transform.position.x + 1, transform.position.y, transform.position.z);
    }
}
