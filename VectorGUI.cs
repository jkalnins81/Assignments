
using UnityEngine;
using UnityEngine.UI;

public class VectorGUI : MonoBehaviour
{
    public Text vectorText;

    public AssignmentLecture3Extra assignmentLecture3Extra;

            
    void Update()
    {

        // vectorText.text = assignmentLecture3Extra.randomVectorX.ToString();

        vectorText.text = assignmentLecture3Extra.randomVectorXY.ToString();




    }
}
