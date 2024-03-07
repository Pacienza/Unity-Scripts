using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Variaveis : MonoBehaviour
 
{
 
 //---VARIÁVEIS---
 
 //números
 
 public int integerTeste = 10; // vai de -2.147.483.648 até 2.147.483.647
 
 public float _decimal = 0.386f; //precisão de 6 a 9 dígitos
 
 
 public double _decimal2 = 0.545;// precisão de 15 a 17 dígitos
 
 public ulong megaNumber; // vai de 0 a 18.446.744.073.709.551.615
 
 public long bigNumber; // vai de -9,223,372,036,854,775,808 até 9,223,372,036,854,775,807
 
 
 public bool trueOrFalse = false;
 
 
 public GameObject _gameObject;
 
 
 //caracteres, "textos"
 
 public char a = 'x'; // um caractere
 
 public string text = "meu texto grande"; // uma cadeia de caracteres
 
 
 public Sprite sprite;
 
 public Rigidbody2D rb2D;
 
 
 //---CONSTANTES---
 
 
 public string NAME = "João";
 
 private float HEIGHT = 1.82f;
 
//----------------------------
 
 void Start()
 
 {
 
 trueOrFalse = true;
 
 text = "outro texto";
 
 integerTeste = 20;
 
 
 }
 
}