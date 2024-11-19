using UnityEngine;

public class ControladorJogador : MonoBehaviour
{
    public float velocidadeMaozinha;
    public Geral JuizdoJogo;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) && transform.position.y <= 465)// C�digo para a M�ozinha subir
        {
            Vector3 novaPos = new Vector3(0,velocidadeMaozinha * Time.deltaTime,0);
            transform.position += novaPos;
        }

        if (Input.GetKey(KeyCode.DownArrow) && transform.position.y >= 35) //C�digo para a M�ozinha des�a
        {
            Vector3 novaPos = new Vector3(0, velocidadeMaozinha * Time.deltaTime, 0);
            transform.position -= novaPos;
        }
        if (Input.GetKey(KeyCode.LeftArrow)) //C�digo para a M�ozinha des�a
        {
            Vector3 novaPos = new Vector3(velocidadeMaozinha * Time.deltaTime,0,0);
            transform.position -= novaPos;
        }
        if (Input.GetKey(KeyCode.RightArrow)) //C�digo para a M�ozinha des�a
        {
            Vector3 novaPos = new Vector3(velocidadeMaozinha * Time.deltaTime,0,0);
            transform.position += novaPos;
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name.StartsWith("Ferramenta"))
        {
            float posicaoY = Random.value * 465;
            collision.GetComponent<ControladorFerramenta>().posicaoFerramenta.x = 0;
            collision.GetComponent<ControladorFerramenta>().posicaoFerramenta.y = posicaoY;

            JuizdoJogo.MarcaPonto();
        }
    }



}
