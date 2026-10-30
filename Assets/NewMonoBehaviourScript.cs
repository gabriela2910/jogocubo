using UnityEngine;

public class fimdejogo : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Nível terminado!");
        }
    }
}