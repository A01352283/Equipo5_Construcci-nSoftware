using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizManager : MonoBehaviour
{
    public List<QuestionAnswers> QnA;

    public Text QuestionText;
    public Text Answer1Text;
    public Text Answer2Text;
    public Text Answer3Text;
    public Text Answer4Text;

    private QuestionAnswers currentQuestion;
    private int index =0;
    private int mult= 10;
    private int score= 0;

    private void Start(){
        generateQuestions();
        showQuestions();

    }

    public void showQuestions(){
        if(index<QnA.Count){
        currentQuestion=QnA[index];
        Shuffle(currentQuestion.answers);
        QuestionText.text=currentQuestion.question;
        Answer1Text.text=currentQuestion.answers[0];
        Answer2Text.text=currentQuestion.answers[1];
        Answer3Text.text=currentQuestion.answers[2];
        Answer4Text.text=currentQuestion.answers[3];
        }
        else{
            Debug.Log("Game Over");
        }
    }

    public void checkAns(int ans_index){
        if (currentQuestion.answers[ans_index]== currentQuestion.correctanswer){
            index++;
            Debug.Log("CORRECT");
            showQuestions();
        }
        else{
            index++;
            Debug.Log("INCORRECT");
            showQuestions();
        }
    }


    /*void SetAnswers(){
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<AnswerScript>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<Text>().text = QnA[currentQuestion].answers[i];

            if(QnA[currentQuestion].correctanswer == i+1){
                options[i].GetComponent<AnswerScript>().isCorrect = true;
            }
        }
    }
    */
    //We will latter generate the questions by json files
    void generateQuestions(){
        QnA.Add(new QuestionAnswers("How old are you?","22","15","75","30"));
        QnA.Add(new QuestionAnswers("Best game?","Percussion Island","Pokemon","Cuphead","TroyWars"));
        QnA.Add(new QuestionAnswers("Day of the week?","Friday","Tuesday","Thursday","Sunday"));
        QnA.Add(new QuestionAnswers("Best School?","Tec","UNAM","ANAHUAC","POLI"));
    }

    //Function that allows to shuffle the order of the answers
    void Shuffle(List<string> s_list){
        for (int i = 0; i < s_list.Count; i++){
            string temp = s_list[i];
            int randomIndex= Random.Range(i, s_list.Count);
            s_list[i]=s_list[randomIndex];   
            s_list[randomIndex]= temp;     
        }
    }
}