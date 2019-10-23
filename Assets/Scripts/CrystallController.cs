using UnityEngine;

public class CrystallController : MonoBehaviour
{
    public ParticleSystem boom;
    public GameObject model;

    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            ScoreService.ChangeScore();
            boom.Play(true);
            Destroy(model);
        }
        if (col.CompareTag("Destroyer"))
        {
            Destroy(gameObject);
        }
    }
}
