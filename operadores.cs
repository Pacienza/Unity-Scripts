using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
 
public class Operadores : MonoBehaviour
 
{
 
 int testeInt = 50;
 int testeInt2 = 150;
 int testeTotal;
 int remainder;
 float testeFloat = 50.3f;
 float testeFloat2 = 150.5f;
 
 
 void Start()
 
 {
 
 //operações aritméticas usuais:
 
 testeTotal = 50 * 150; //multiplicação
 
 testeTotal = testeInt / testeInt2; //divisão
 
 testeTotal = testeInt - testeInt2; //subtração
 
 testeTotal = testeInt + testeInt2; //soma
 
 
 
 //operações usando os métodos da classe Mathf:
 
 testeFloat = Mathf.Sqrt(9.0f); //raiz quadrada
 
 testeFloat2 = Mathf.Pow(9.0f, 2.0f); //potenciação
 
 testeFloat = Mathf.Abs(testeFloat); //número absoluto (sempre positivo)
 
 
 
 //sobra da divisão de um número pelo outro:
 
 remainder = testeInt % testeInt2;
 
 
 //soma 1
 
 testeInt++;// o mesmo que:
 
 testeInt = testeInt + 1;
 
 
 //subtrai 1
 
 testeInt--;// o mesmo que:
 
 testeInt = testeInt - 1;
 
 
 //soma um número
 
 testeInt += 2; // o mesmo que:
 
 testeInt = testeInt + 2;
 
 
 //subtrai um número
 
 testeInt -= 3; // o mesmo que:
 
 testeInt = testeInt - 3;
 
 }
 
}