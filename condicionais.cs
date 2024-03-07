using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 
public class Condicional_If : MonoBehaviour
 
{
 
 [SerializeField]
 
 bool isPlaying;
 float points;
 int highScore;
 int lives = 10;
 
 
 public Text PointsTxt;
 public Text HighScoreTxt;
 public Text LivesTxt;
 
 
 private void Update()
 
 {
 
 AddScores();
 
 }
 
 void AddScores() {
 
 if (isPlaying && lives > 0)
 
 {
 points += 1 * Time.deltaTime;
 
 PointsTxt.text = "Points: " + ((int)points).ToString();
 
 
 if ((int)points > highScore)
 {
 
 highScore = (int)points;
 
 HighScoreTxt.text = "High Score: " + highScore.ToString();
 
 HighScoreMessage();
 
 }
 
 }
 
 else
 
 {
 
 return;
 
 }
 
 }
 
 void HighScoreMessage(){
 
 if(highScore < 10){
 print("muito mal");
 return;
 
 }else if(highScore >= 10 && highScore < 50){
 print("médio");
 
 }else if (highScore >= 50 && highScore < 100){
 print("muito bem");
 
 }else{
 print("excepcional");
 }
 }
 
 
 public void Damage(){
 
 lives--;
 
 LivesTxt.text = "Lives: " + lives.ToString();
 
 points = 0;
 
 PointsTxt.text = "Points: " +((int)points).ToString();
 
 }
 
 public void IsPlaying(){
 
 isPlaying = !isPlaying;
 
 }
 
}