using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PapelScript : MonoBehaviour
{
    //Cria variavel do tipo SpriteRenderer
    SpriteRenderer m_SpriteRenderer;

    int count;
    int restoDivisao;
    // Start is called before the first frame update
    void Start()
    {
        //Pega o componente SpriteRenderer do objeto
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Pega o clique na caixa 
    void OnMouseDown() {
        Debug.Log("Clique na caixa");
        count ++;
        restoDivisao = count % 2;
        
        if(restoDivisao == 1)
        {
            m_SpriteRenderer.color = Color.blue;
        }
        else
        {
            m_SpriteRenderer.color = Color.red;
        }
        
    }
}