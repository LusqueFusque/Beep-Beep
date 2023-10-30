using UnityEngine;
using UnityEngine.SceneManagement;

public class Moeda : MonoBehaviour
{
    public int velocidadeGiro = 50;

    void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        transform.Rotate(eulers: Vector3.up * velocidadeGiro * Time.deltaTime, relativeTo: Space.World);
    }
}