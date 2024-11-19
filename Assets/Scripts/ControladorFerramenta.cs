using UnityEngine;

public class ControladorFerramenta : MonoBehaviour
{

    public Vector3 posicaoFerramenta;
    public float deslocamentoferramenta;
    public float incrementovelocidade;

    internal float deslocamnetoInicial;
    internal int sentidoV;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sentidoV = 1;
        deslocamnetoInicial = deslocamentoferramenta;
    }

    // Update is called once per frame
    void Update()
    {


        posicaoFerramenta.x += + deslocamentoferramenta * Time.deltaTime; //+= é uma variavel é igaul ela mais ela mesma
        posicaoFerramenta.y += + deslocamentoferramenta * Time.deltaTime * sentidoV;

        transform.position = posicaoFerramenta;
        //Arrumar sentido vertical:
        if (transform.position.y >= 465 && sentidoV == 1)
            sentidoV = -1;
        if (transform.position.y <= 35 && sentidoV == -1)
            sentidoV = 1;

        deslocamentoferramenta += incrementovelocidade * Time.deltaTime;


        {
            //Time.deltatime
        }
    }
}
