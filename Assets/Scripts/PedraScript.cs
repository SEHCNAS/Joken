using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PedraScript : MonoBehaviour{
    //Cria variavel do tipo SpriteRenderer
    SpriteRenderer m_SpriteRenderer;
    
    public static bool IsPedraSelcionado;

    // Start is called before the first frame update
    void Start(){
        //Pega o componente SpriteRenderer do objeto
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
        IsPedraSelcionado = false;
        
    }

    // Update is called once per frame
    void Update(){
        
    }

    //Pega o clique na caixa 
    void OnMouseDown(){
        Debug.Log("Clique na pedra");  
        if(!TesouraScript.IsTesouraSelecionado && !PapelScript.IsPapelSelecionado){    
            if(!IsPedraSelcionado){
                m_SpriteRenderer.color = Color.blue;
                IsPedraSelcionado = true;
            }
            else{
                m_SpriteRenderer.color = Color.white;
                IsPedraSelcionado = false;
            }
        }
    }
}