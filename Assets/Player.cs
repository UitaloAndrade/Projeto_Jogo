using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Animator Anim;
    public float speed;
    public static float fixedDeltaTime;

    // Update is called once per frame
    void FixedUpdate()
    {
        movePlayer();
}


void movePlayer(){
        Vector3 movement = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0f);
        Anim.SetFloat("Horizontal", movement.x);
        Anim.SetFloat("Vertical", movement.y);
        Anim.SetFloat("Speed", movement.magnitude);

        transform.position = transform.position + movement * speed * Time.fixedDeltaTime;
        }


void VidaJogar(){
        // 100 de vida nivel 1 
}

void paladino(){
        // hibrido fisico e dano magico mais tank do que dano
        // 80 de vida nivel 1
        // 10% (armadura) diminui na vida , e a armadura  nivel 1
        // 35 mana nivel 1
        // item inicial armadura nivel 
        // item espada dano fisico na vida  inicial
        // habilidade poder magico de cura , aumentar a  proteçao(% da aarmadura) 
        // 15 de dano fisico
        // passiva a cada nivel recebe mais 1 armadura 
}
void Assasino(){
        // dano fisico++  e critico 
        // 60 de vida inicial
        // 50 mana para castar habilidades
        // 5% de armadura == reduçao de dano
        //  35 de dano fisico     
        // dano magico 5 
        // habilidade passiva dano critico 
        // habilidades nos proximos 3 ataques recebe dano critico
        // item inicial adaga recebe chance de critico(%) e dano critico (%)
        
}
void barbaro(){
        //furia inves de mana combate fisico e staca furia  ataque reduz dano de inimigo, furia cheia ele atima modo foda e sofre menso dano e causa mais dano != debuff
        // 70 de vida inicial
        // mana(furia) quando ativado a furia nos proximos 3 ataques da mais dano e recebe menos dano
        //passiva -40 % de vida ele causa mais dano
        //habilidade berseker (recebe 5 cargas) a cada 2 ataque recebe uam carga , a cada 1 ataques recebidos ganha 1 carga.
        // 7% de armadura nivel 1
        //dano fisico 20
        // item machado nivel 1

}


void feiticeiro(){
                // dano magico coolwdawn etc...
                //50 de vida
                //90 de mana
                //5% de armadura 
                //dano fisico 10 
                // poder magico 30
 //habilidade elemental fogo(dano critico) agua(reduçao de dano fisico ) terra(dano + e aumenta a armadura) vento(dano e diminiu armadura do inimigo) e decide qual habilidade usar,
                // item cajado ou outra coisa tanto faz
                //passiva aumenta a mana 3% a cada nivel
}

}
