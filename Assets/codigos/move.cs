
using System;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class move : MonoBehaviour
{
    public Rigidbody variavel;
    public TMP_Text vida;
    public TMP_Text moedas;
    public AudioSource somdojogo; 
    public AudioClip moeda;
    public AudioClip baterbarreira;
   
   

    // Update is called once per frame
    void Update()
    {
        variavel.AddForce(0, 0, 1);
        if (Keyboard.current.leftArrowKey.isPressed)
        {
            variavel.AddForce(-4, 0, 0);
        }
        if (Keyboard.current.rightArrowKey.isPressed)
        {
            variavel.AddForce(4, 0, 0);
        }
      // se a bola cair da plataforma, o jogador perde uma vida e a bola volta para a posição inicial
      if (transform.position.y < -1)
        {
            vida.text = (int.Parse(vida.text) - 1).ToString();
            transform.position = new Vector3(0, 1, 0);
            variavel.linearVelocity = Vector3.zero;
            if (int.Parse(vida.text) <= 0)
            {
                FindAnyObjectByType<controlador>().reiniciar();
            }
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "barreiras")
        {
            vida.text = (int.Parse(vida.text) - 1). ToString();
            if (int.Parse(vida.text) <= 0)
            {
                FindAnyObjectByType<controlador>().reiniciar();
            }
            somdojogo.PlayOneShot(baterbarreira);
        }
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "moedas")
        {
            moedas.text = (int.Parse(moedas.text) + 1).ToString();
            somdojogo.PlayOneShot(moeda);
        }
    }
}
