using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public TextAsset [] textFile;
    public GameObject Brick;
    public GameObject UnBrick;
    public GameObject Finish;


    void Start()
    {
        checkPos();
    }

    private void Update()
    {


    }
    void checkPos()
    {
        string data = textFile[0].text;
        string [] table = data.Split('\n');
        for (int i = 0; i < table.Length; i++)
        {
            string [] student = table[i].Split(",");
            for (int j = 0; j < student.Length; j++)
            {
                Debug.Log(student[j]);  
                var studentNumber = int.Parse(student[j]);

                if (studentNumber == 1)
                {
                    GenerateBrick(new Vector3(i, 0, j));
                }
                if (studentNumber == -1)
                {
                    GenerateUnBrick(new Vector3(i, 0, j));
                }
                if (studentNumber == 5)
                {
                    GenerateFinish(new Vector3(i, 0, j));
                }
            }
        }
    }

    void GenerateBrick(Vector3 position)
    {
        Instantiate(Brick, position, transform.rotation);
    }
    void GenerateUnBrick(Vector3 position)
    {
        Instantiate(UnBrick, position, transform.rotation);
    }
    void GenerateFinish(Vector3 position)
    {
        Instantiate(Finish, position, transform.rotation);
    }

    void gameFinish()
    {

    }
}
