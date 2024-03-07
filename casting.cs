using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Casting : MonoBehaviour
{
 // Castings e Convertions -> converter os dados de um tipo para outro tipo
 
 void Start()
 {
 //exemplo 1
 float _decimal = 234.7f;
 int _inteiro = (int)_decimal;
 string _characteres = _inteiro.ToString();
 int _inteiro2 = int.Parse(_characteres);
 float _decimal2 = (float)_inteiro2;
 
 //exemplo 2
 bool _bool = true;
 string booleano = _bool.ToString();
 
 }
}