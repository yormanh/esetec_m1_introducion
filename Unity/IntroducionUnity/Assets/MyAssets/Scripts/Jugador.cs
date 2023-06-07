using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    public int velocidad;
    public int vidas;
    public float valorGravedad = 9.81f;
    CharacterController controller;
    public TextMeshProUGUI vidasTexto;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        //puntuacion = 10;
        //gameObject.name = "NuevoNombre";
        //gameObject.SetActive(false);
        //Debug.Log (gameObject.name);
        //Debug.Log(gameObject.transform.position);
        //Debug.Log(gameObject.transform.rotation);
        //Debug.Log(gameObject.transform.localScale);

        //Debug.Log(gameObject.GetComponent<Transform>().position);

        //Debug.Log(gameObject.GetComponent<Jugador>().enabled);
        //gameObject.GetComponent<Jugador>().gameObject.SetActive(false);
        //Debug.Log(gameObject.GetComponent<Jugador>().gameObject.transform.name);


        //Debug.Log("Hola mundo");
    }

    // Update is called once per frame
    public void Update()
    {
        Movimiento();
    }

    public void Movimiento()
    {
        //Debug.Log("Hola mundo cruel");
        //Debug.Log(gameObject.transform.position);

        float horizontal = Input.GetAxis("Horizontal");
        //Debug.Log(horizontal);

        float vertical = Input.GetAxis("Vertical");
        //Debug.Log(vertical);

        Vector3 direccion = new Vector3(horizontal, 0, vertical);
        direccion.y = direccion.y - valorGravedad;
        //direccion.y -= valorGravedad;

        //Saltar
        if(Input.GetButton("Jump"))
        {
            direccion.y = 15;
        }

        controller.Move(direccion * Time.deltaTime * velocidad);

    }


    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Trigger: " + other.name);

        if (other.tag == "Explosivos")
        {
            vidas = vidas - 1; //restarle una vida a las vidas actuales
            //vidas -= 1;
            //vidas--;
            other.gameObject.SetActive(false);
            vidasTexto.text = "Vidas: " + vidas.ToString();
        }
        if (other.tag == "Comida")
        {
            vidas = vidas + 1; //sumar una vida a las vidas actuales
            other.gameObject.SetActive(false);
            vidasTexto.text = "Vidas: " + vidas.ToString();
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision");
    }


}
