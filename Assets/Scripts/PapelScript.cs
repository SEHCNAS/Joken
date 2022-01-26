using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PapelScript : MonoBehaviour{
    //Cria variavel do tipo SpriteRenderer
    SpriteRenderer m_SpriteRenderer;

    public static bool IsPapelSelecionado;

    // Start is called before the first frame update
    void Start(){
        //Pega o componente SpriteRenderer do objeto
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
        IsPapelSelecionado = false;  
    }

    // Update is called once per frame
    void Update(){
    }

    //Pega o clique na caixa 
    void OnMouseDown(){
        Debug.Log("Clique no papel");
        if(!TesouraScript.IsTesouraSelecionado && !PedraScript.IsPedraSelcionado){
            if(!IsPapelSelecionado){
                m_SpriteRenderer.color = Color.blue;
                IsPapelSelecionado = true;
            }
            else{
                m_SpriteRenderer.color = Color.white;
                IsPapelSelecionado = false;
            }
        }
    }
}