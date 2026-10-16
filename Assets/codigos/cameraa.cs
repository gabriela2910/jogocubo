using UnityEngine;

public class cameraa : MonoBehaviour
{
   public Transform Jogador;
   public Vector3 distancia;
    // Update is called once per frame
    void Update()
    {
     transform.position = Jogador.position + distancia;   
    }
}
