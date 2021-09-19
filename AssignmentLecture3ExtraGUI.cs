
using UnityEngine;
using UnityEngine.UI;

public class AssignmentLecture3ExtraGUI : MonoBehaviour
{
    public Text scoreText;

    public AssignmentLecture3Extra assignmentLecture3Extra;

        
    void Update()
    {
        scoreText.text = assignmentLecture3Extra.score.ToString();      
        

    }
}
