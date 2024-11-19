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
        if (Input.GetKey(KeyCode.UpArrow) && transform.position.y <= 465)// Código para a Mãozinha subir
        {
            Vector3 novaPos = new Vector3(0,velocidadeMaozinha * Time.deltaTime,0);
            transform.position += novaPos;
        }

        if (Input.GetKey(KeyCode.DownArrow) && transform.position.y >= 35) //Código para a Mãozinha desça
        {
            Vector3 novaPos = new Vector3(0, velocidadeMaozinha * Time.deltaTime, 0);
            transform.position -= novaPos;
        }
        if (Input.GetKey(KeyCode.LeftArrow)) //Código para a Mãozinha desça
        {
            Vector3 novaPos = new Vector3(velocidadeMaozinha * Time.deltaTime,0,0);
            transform.position -= novaPos;
        }
        if (Input.GetKey(KeyCode.RightArrow)) //Código para a Mãozinha desça
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
