using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TesouraScript : MonoBehaviour{
    //Cria variavel do tipo SpriteRenderer
    SpriteRenderer m_SpriteRenderer;
    public static bool IsTesouraSelecionado;

    // Start is called before the first frame update
    void Start(){
        //Pega o componente SpriteRenderer do objeto
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
        IsTesouraSelecionado = false;
    }

    // Update is called once per frame
    void Update(){
    }

    //Pega o clique na caixa 
    void OnMouseDown(){
        Debug.Log("Clique na tesoura");
        if(!PapelScript.IsPapelSelecionado && !PedraScript.IsPedraSelcionado){
            if(!IsTesouraSelecionado){
                m_SpriteRenderer.color = Color.blue;
                IsTesouraSelecionado = true;
            }
            else{
                m_SpriteRenderer.color = Color.white;
                IsTesouraSelecionado = false;
            }
        }
         /*
        if(PapelScript.IsPapelSelecionado == false){
            Debug.Log("Falso");
        }
        else{
            Debug.Log("VERDADEIRO");
        }*/
    }
}
