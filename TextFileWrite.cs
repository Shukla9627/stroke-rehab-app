// Firdausi Mahmood | 1526546
// MEng Final Year Project
// Writes the date and time of the start of the exercise to a text file, as well as the type of exercise and iteration count

using UnityEngine;
using UnityEditor;
using System.IO;
using System;
using UnityEngine.UI;

public class TextFileWrite: MonoBehaviour
{
    int iteration = 0;
    String m_path;
    
    void Start()
    {
        m_path = Application.dataPath;
        Debug.Log("" + m_path);

       using (StreamWriter sw = new StreamWriter(m_path + "/textfile2_T6.txt", true))
        {
            //Write headers and date/time
            sw.Write("\tExercise: Grasping\r\n");
            sw.Write(DateTime.Now);
            sw.WriteLine("\tIterations Completed");
        }
    }

    void OnEnable()
    {
        m_path = Application.dataPath;

        // Create an instance of StreamWriter to write text to a file
        // 'true' ensures that existing text in the file is not overwritten
        using (StreamWriter sw = new StreamWriter(m_path + "/textfile2_T6.txt", true))
        {         
            // Write iteration
            sw.Write("\t" + iteration);
            iteration++;
            sw.Write("\r\n");
            /*if(iteration == 6)
            {
                Application.Quit();
            }*/
        }
    }
}
