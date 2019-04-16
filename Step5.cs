// Firdausi Mahmood | 1526546
// MEng Final Year Project
// Step 5 of the exercise.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Net;
using Senso;
using System.IO;

public class Step5 : MonoBehaviour
{
    //BONES
    private GameObject bone3, bone4, bone4end; //thumb  
    private GameObject bone6, bone7, bone8, bone8end; //index   
    private GameObject bone12, bone16, bone17, bone17end; //middle   
    private GameObject bone13, bone14, bone15, bone15end; //ring
    private GameObject bone18, bone19, bone20, bone20end; //little

    //IN-GAME SPRITES
    private GameObject sprite1, sprite2, sprite3, sprite4, sprite5; //images for steps
    private GameObject instruction1, instruction2, instruction3, instruction4, instruction5; //instructions
    private GameObject glow1, glow2, glow3; //glows on steps

    //ANGLES
    public float angle, angle2, angle3, angle4, angle5, angle6, angle7, angle8, angle9;
    public float fangle, fangle2, fangle3, fangle4, fangle5, fangle6, fangle7, fangle8, fangle9; //imported from callibration

    //UNUSED
    public SensoHandsController sensoHandsController1 = new SensoHandsController(); //was for vibration.

    //WRITE
    String m_path;

    //TIMER
    private float start_time;

    //ITERATION COUNT
    private GameObject iterations;

    //FEEDBACK
    private GameObject aid1, aid2, aid3, aid4, aid5, aid6, aid7, aid8, aid9, aid10;

    // Use this for initialization
    void Start()
    {
        iterations = GameObject.Find("/Canvas/Text2");

        bone3 = GameObject.Find("/Right Hand Container/right_hand/Armature/Bone.022/Bone/Bone.001/Bone.002/Bone.003");
        bone4 = GameObject.Find("/Right Hand Container/right_hand/Armature/Bone.022/Bone/Bone.001/Bone.002/Bone.003/Bone.004");
        bone4end = GameObject.Find("/Right Hand Container/right_hand/Armature/Bone.022/Bone/Bone.001/Bone.002/Bone.003/Bone.004/Bone.004_end");
        bone6 = GameObject.Find("/Right Hand Container/right_hand/Armature/Bone.022/Bone/Bone.005/Bone.006");
        bone7 = GameObject.Find("/Right Hand Container/right_hand/Armature/Bone.022/Bone/Bone.005/Bone.006/Bone.007");
        bone8 = GameObject.Find("/Right Hand Container/right_hand/Armature/Bone.022/Bone/Bone.005/Bone.006/Bone.007/Bone.008");
        bone8end = GameObject.Find("/Right Hand Container/right_hand/Armature/Bone.022/Bone/Bone.005/Bone.006/Bone.007/Bone.008/Bone.008_end");
        bone12 = GameObject.Find("/Right Hand Container/right_hand/Armature/Bone.022/Bone/Bone.009/Bone.012");
        bone16 = GameObject.Find("/Right Hand Container/right_hand/Armature/Bone.022/Bone/Bone.009/Bone.012/Bone.016");
        bone17 = GameObject.Find("/Right Hand Container/right_hand/Armature/Bone.022/Bone/Bone.009/Bone.012/Bone.016/Bone.017");
        bone17end = GameObject.Find("/Right Hand Container/right_hand/Armature/Bone.022/Bone/Bone.009/Bone.012/Bone.016/Bone.017/Bone.017_end");
        bone13 = GameObject.Find("/Right Hand Container/right_hand/Armature/Bone.022/Bone/Bone.010/Bone.013");
        bone14 = GameObject.Find("/Right Hand Container/right_hand/Armature/Bone.022/Bone/Bone.010/Bone.013/Bone.014");
        bone15 = GameObject.Find("/Right Hand Container/right_hand/Armature/Bone.022/Bone/Bone.010/Bone.013/Bone.014/Bone.015");
        bone15end = GameObject.Find("/Right Hand Container/right_hand/Armature/Bone.022/Bone/Bone.010/Bone.013/Bone.014/Bone.015/Bone.015_end");
        bone18 = GameObject.Find("/Right Hand Container/right_hand/Armature/Bone.022/Bone/Bone.011/Bone.018");
        bone19 = GameObject.Find("/Right Hand Container/right_hand/Armature/Bone.022/Bone/Bone.011/Bone.018/Bone.019");
        bone20 = GameObject.Find("/Right Hand Container/right_hand/Armature/Bone.022/Bone/Bone.011/Bone.018/Bone.019/Bone.020");
        bone20end = GameObject.Find("/Right Hand Container/right_hand/Armature/Bone.022/Bone/Bone.011/Bone.018/Bone.019/Bone.020/Bone.020_end");

        sprite1 = GameObject.Find("/Steps/Step1");
        sprite2 = GameObject.Find("/Steps/Step2");
        sprite3 = GameObject.Find("/Steps/Step3");
        sprite4 = GameObject.Find("/Steps/Step4");
        sprite5 = GameObject.Find("/Steps/Step5");

        instruction1 = GameObject.Find("/Environment/step1");
        instruction2 = GameObject.Find("/Environment/step2");
        instruction3 = GameObject.Find("/Environment/step3");
        instruction4 = GameObject.Find("/Environment/step4");
        instruction5 = GameObject.Find("/Environment/step5");

        glow1 = GameObject.Find("/Steps/Glow1");
        glow2 = GameObject.Find("/Steps/Glow2");
        glow3 = GameObject.Find("/Steps/Glow3");

        aid1 = GameObject.Find("/Aid/AidThumbIn");
        aid2 = GameObject.Find("/Aid/AidThumbOut");
        aid3 = GameObject.Find("/Aid/AidIndexIn");
        aid4 = GameObject.Find("/Aid/AidIndexOut");
        aid5 = GameObject.Find("/Aid/AidMiddleIn");
        aid6 = GameObject.Find("/Aid/AidMiddleOut");
        aid7 = GameObject.Find("/Aid/AidRingIn");
        aid8 = GameObject.Find("/Aid/AidRingOut");
        aid9 = GameObject.Find("/Aid/AidLittleIn");
        aid10 = GameObject.Find("/Aid/AidLittleOut");

        m_path = Application.dataPath;

        // Write date to text file
        using (StreamWriter sw = new StreamWriter(m_path + "/Step5_T6.txt", true))
        {
            sw.Write(DateTime.Now);
            sw.Write("\r\n");
        }
    }

    // Update is called once per frame
    void Update()
    {
        m_path = Application.dataPath;

        //Call these from callibration steps
        fangle = Wait1.fistangle;
        fangle2 = Wait1.fistangle2;
        fangle3 = Wait1.fistangle3;
        fangle4 = Wait1.fistangle4;
        fangle5 = Wait1.fistangle5;
        fangle6 = Wait1.fistangle6;
        fangle7 = Wait1.fistangle7;
        fangle8 = Wait1.fistangle8;
        fangle9 = Wait1.fistangle9;

        //vector declaration
        Vector3 pos4, pos4end, pos3;
        Vector3 pos7, pos8, pos8end, pos6;
        Vector3 pos16, pos17, pos17end, pos12;
        Vector3 pos14, pos15, pos15end, pos13;
        Vector3 pos19, pos20, pos20end, pos18;

        //thumb
        pos4 = bone4.transform.position;
        pos4end = bone4end.transform.position;
        pos3 = bone3.transform.position;
        //smaller of the two angles is used
        angle = Vector3.Angle(pos4 - pos4end, pos4 - pos3);
        //Debug.Log(angle);

        //index outer
        pos7 = bone7.transform.position;
        pos8 = bone8.transform.position;
        pos8end = bone8end.transform.position;
        angle2 = Vector3.Angle(pos8 - pos8end, pos8 - pos7);
        // Debug.Log(angle2);

        //index inner
        pos6 = bone6.transform.position;
        angle3 = Vector3.Angle(pos7 - pos8, pos7 - pos6);
        //Debug.Log(angle3);

        //middle outer
        pos16 = bone16.transform.position;
        pos17 = bone17.transform.position;
        pos17end = bone17end.transform.position;
        angle4 = Vector3.Angle(pos17 - pos17end, pos17 - pos16);
        //Debug.Log(angle4);

        //middle inner
        pos12 = bone12.transform.position;
        angle5 = Vector3.Angle(pos16 - pos17, pos16 - pos12);
        //Debug.Log(angle5);

        //ring outer
        pos14 = bone14.transform.position;
        pos15 = bone15.transform.position;
        pos15end = bone15end.transform.position;
        angle6 = Vector3.Angle(pos15 - pos15end, pos15 - pos14);
        //Debug.Log(angle6);

        //ring inner
        pos13 = bone13.transform.position;
        angle7 = Vector3.Angle(pos14 - pos15, pos14 - pos13);
        //Debug.Log(angle7);

        //little outer
        pos19 = bone19.transform.position;
        pos20 = bone20.transform.position;
        pos20end = bone20end.transform.position;
        angle8 = Vector3.Angle(pos20 - pos20end, pos20 - pos19);
        //Debug.Log(angle8);

        //little inner
        pos18 = bone18.transform.position;
        angle9 = Vector3.Angle(pos19 - pos20, pos19 - pos18);
        //Debug.Log(angle9);

        //write angles to text file
        using (StreamWriter sw = new StreamWriter(m_path + "/Step5_T6.txt", true))
        {
            sw.Write(" \t" + angle + "\t " + angle2 + " \t" + angle3 + "\t " + angle4 + "\t " + angle5 + " \t" + angle6 + "\t " + angle7 + "\t " + angle8 + " \t" + angle9);
            sw.Write("\r\n");
        }

        //by default all aid inactivated 
        aid1.SetActive(false);
        aid2.SetActive(false);
        aid3.SetActive(false);
        aid4.SetActive(false);
        aid5.SetActive(false);
        aid6.SetActive(false);
        aid7.SetActive(false);
        aid8.SetActive(false);
        aid9.SetActive(false);
        aid10.SetActive(false);

        //if user is stuck on a step for more than 5 seconds, display assistance
        if ((Time.time - start_time) > 5.0f)
        {
            Assistance();
        }

        //if (angle < 145 && angle2 < 150 && angle3 < 140 && angle4 < 135 && angle5 < 145 && angle6 < 145 && angle7 < 120 && angle8 < 140 && angle9 < 120)
        if (angle < (fangle + 20) && angle > (fangle - 20) && angle2 < (fangle2 + 20) && angle2 > (fangle2 - 20) && angle3 < (fangle3 + 20) && angle3 > (fangle3 - 20) && angle4 < (fangle4 + 20) && angle4 > (fangle4 - 20) && angle5 < (fangle5 + 20) && angle5 > (fangle5 - 20) && angle6 < (fangle6 + 20) && angle6 > (fangle6 - 20) && angle7 < (fangle7 + 20) && angle7 > (fangle7 - 20) && angle8 < (fangle8 + 20) && angle8 > (fangle8 - 20) && angle9 < (fangle9 + 20) && angle9 > (fangle9 - 20))
        {
            //Debug.Log("Step five complete");

            // stop timer and write time to file
            using (StreamWriter sw = new StreamWriter(m_path + "/time5_T6.txt", true))
            {
                sw.Write((Time.time - start_time) + "\r\n");
            }

            FanglePrint();

            //Deactivate current steps, activate next steps
            sprite5.SetActive(false);
            instruction5.SetActive(false);
            sprite2.SetActive(true);
            instruction2.SetActive(true);
            glow1.SetActive(false);
            glow2.SetActive(true);
        }
    }
    void OnEnable()
    {
        //start timer when step is activated
        start_time = Time.time;
        //increment number of iterations
        iterations.SetActive(true);
    }

    void FanglePrint()
    {
        //print callibration angles for step 5 to file
        using (StreamWriter sw = new StreamWriter(m_path + "/Step5Fangle_T6.txt", true))
        {
            sw.Write(fangle + " " + fangle2 + " " + fangle3 + " " + fangle4 + " " + fangle5 + " " + fangle6 + " " + fangle7 + " " + fangle8 + " " + fangle9);
            sw.Write("\r\n");
        }
    }

    // Assistance function checks if each angle is within the callibration threshold. If not, the respective aid instruction is displayed.
    void Assistance()
    {
        //Debug.Log("active");
        if (angle > (fangle + 20))
        {
            aid1.SetActive(true);
        }
        if (angle < (fangle - 20))
        {
            aid2.SetActive(true);
        }

        if (angle2 > (fangle2 + 20))
        {
            aid3.SetActive(true);
        }
        if (angle2 < (fangle2 - 20))
        {
            aid4.SetActive(true);
        }

        if (angle3 > (fangle3 + 20))
        {
            aid3.SetActive(true);
        }
        if (angle3 < (fangle3 - 20))
        {
            aid4.SetActive(true);
        }

        if (angle4 > (fangle4 + 20))
        {
            aid5.SetActive(true);
        }
        if (angle4 < (fangle4 - 20))
        {
            aid6.SetActive(true);
        }

        if (angle5 > (fangle5 + 20))
        {
            aid5.SetActive(true);
        }
        if (angle5 < (fangle5 - 20))
        {
            aid6.SetActive(true);
        }

        if (angle6 > (fangle6 + 20))
        {
            aid7.SetActive(true);
        }
        if (angle6 < (fangle6 - 20))
        {
            aid8.SetActive(true);
        }

        if (angle7 > (fangle7 + 20))
        {
            aid7.SetActive(true);
        }
        if (angle7 < (fangle7 - 20))
        {
            aid8.SetActive(true);
        }

        if (angle8 > (fangle8 + 20))
        {
            aid9.SetActive(true);
        }
        if (angle8 < (fangle8 - 20))
        {
            aid10.SetActive(true);
        }

        if (angle9 > (fangle9 + 20))
        {
            aid9.SetActive(true);
        }
        if (angle9 < (fangle9 - 20))
        {
            aid10.SetActive(true);
        }
    }
}


