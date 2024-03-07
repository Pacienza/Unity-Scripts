using UnityEngine;
public class Condicional_switch : MonoBehaviour
 
{
 
 string color;
 bool isAlive;
 
//método que escolhe a cor invocando o método que contém o Switch:
 public void ChoosingColor(string _color)
 
 {
 color = _color;
 ShowColor();
 }
 
//método que escolhe a cor invocando o método que contém o If-Else:
 public void ChoosingColorIf(string _color)
 
 {
 color = _color;
 ShowColorIf();
 
 }
 
//exemplo de método que utiliza o Switch:
 void ShowColor()
 
 {
 
switch (color)
 
 {
 
 case "rosa":
 
 print("A cor é rosa.");
 
 break;
 
 case "verde":
 
 print("A cor é verde.");
 
 break;
 
 case "branco":
 
 print("A cor é branca.");
 
 break;
 
 case null:
 
 print("A cor não existe.");
 
 break;
 
 default:
 
 print("Não se sabe a cor.");
 
 break;
 
 }
 
 }
 
 
 
//exemplo do caso anterior utilizando o If-Else:
 
 void ShowColorIf()
 
 {
 
 if(color == "rosa")
 
 {
 
 print("A cor é rosa.");
 
 return;
 
 }
 
 else if (color == "verde")
 
 {
 
 print("A cor é verde.");
 
 return;
 
 }
 
 else if (color == "branco")
 
 {
 
 print("A cor é branca.");
 
 return;
 
 }
 
 else 
 
 {
 
 print("Não se sabe a cor.");
 
 return;
 
 }
 
 }
 
//exemplo de Switch com números:
 
 void SwitchStatement() {
 
 int number = 3;
 
 switch (number)
 
 {
 
 case 1:
 
 print("Um");
 
 break;
 
 case 2:
 
 print("Dois");
 
 break;
 
 case 3:
 
 print("Três");
 
 break;
 
 default:
 
 print("Default");
 
 break;
 
 }
 
 }
 
}