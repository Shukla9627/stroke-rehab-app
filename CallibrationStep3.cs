// Firdausi Mahmood | 1526546
// MEng Final Year Project
// Callibration for Step 3

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Net;
using Senso;

public class CallibrationStep3 : MonoBehaviour
{
    //BONES
    private GameObject bone3, bone4, bone4end; //thumb  
    private GameObject bone6, bone7, bone8, bone8end; //index   
    private GameObject bone12, bone16, bone17, bone17end; //middle   
    private GameObject bone13, bone14, bone15, bone15end; //ring
    private GameObject bone18, bone19, bone20, bone20end; //little

    public SensoHandsController sensoHandsController1 = new SensoHandsController();

    //ANGLES
    public float angle, angle2, angle3, angle4, angle5, angle6, angle7, angle8, angle9;
    public float wideangle, wideangle2, wideangle3, wideangle4, wideangle5, wideangle6, wideangle7, wideangle8, wideangle9;

    //IN-GAME SPRITES
    private GameObject sprite1, sprite2, sprite3, sprite4, sprite5; //images for steps
    private GameObject instruction1, instruction2, instruction3, instruction4, instruction5; //instructions
    private GameObject glow1, glow2, glow3; //glows on steps

    //callibration
    private GameObject bg, text1, text2, step1, step2, step3, inst1, inst2, inst3, overlay;
    private float timer = 0.0f;
    public float waitingTime = 3.0f;

    Wait3 w = new Wait3();

    // Use this for initialization
    void Start()
    {
        bg = GameObject.Find("/Callibration/CallBG");
        text1 = GameObject.Find("/Callibration/Cal");
        text2 = GameObject.Find("/Callibration/CalText");
        step1 = GameObject.Find("/Callibration/CalStep1");
        step2 = GameObject.Find("/Callibration/CalStep2");
        step3 = GameObject.Find("/Callibration/CalStep3");
        inst1 = GameObject.Find("/Callibration/I1");
        inst2 = GameObject.Find("/Callibration/I2");
        inst3 = GameObject.Find("/Callibration/I3");
        overlay = GameObject.Find("/Callibration/Overlay");

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
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos4, pos4end, pos3;
        Vector3 pos7, pos8, pos8end, pos6;
        Vector3 pos16, pos17, pos17end, pos12;
        Vector3 pos14, pos15, pos15end, pos13;
        Vector3 pos19, pos20, pos20end, pos18;

        //thumb
        //Vector3 pos4, pos4end, pos3;
        pos4 = bone4.transform.position;
        pos4end = bone4end.transform.position;
        pos3 = bone3.transform.position;
        //smaller of the two angles is used
        angle = Vector3.Angle(pos4 - pos4end, pos4 - pos3);
        //Debug.Log(angle);

        //index outer
        //Vector3 pos7, pos8, pos8end, pos6;
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
        //Vector3 pos16, pos17, pos17end, pos12;
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
        //Vector3 pos14, pos15, pos15end, pos13;
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
        //Vector3 pos19, pos20, pos20end, pos18;
        pos19 = bone19.transform.position;
        pos20 = bone20.transform.position;
        pos20end = bone20end.transform.position;
        angle8 = Vector3.Angle(pos20 - pos20end, pos20 - pos19);
        //Debug.Log(angle8);

        //little inner
        pos18 = bone18.transform.position;
        angle9 = Vector3.Angle(pos19 - pos20, pos19 - pos18);
        //Debug.Log(angle9);

        overlay.SetActive(false);

        //use these tresholds - error detection
        if (angle > 155 && angle2 > 170 && angle3 > 170 && angle4 > 155 && angle5 > 170 && angle6 > 170 && angle7 > 155 && angle8 > 160 && angle9 > 135)
        {
            overlay.SetActive(true);

            timer += Time.deltaTime;

            //after position is held for 3 seconds...
            if (timer > waitingTime)
            {
                timer = 0f;
                Wait(angle, angle2, angle3, angle4, angle5, angle6, angle7, angle8, angle9);
            }

        }

    }
    void Wait(float angle, float angle2, float angle3, float angle4, float angle5, float angle6, float angle7, float angle8, float angle9)
    {
         //save wide angles in Wait3 script
         w.Wait(angle, angle2, angle3, angle4, angle5, angle6, angle7, angle8, angle9);

         //deactivate current steps, activate main exercise
         bg.SetActive(false);
         text1.SetActive(false);
         text2.SetActive(false);
         overlay.SetActive(false);
         sprite1.SetActive(true);
         step3.SetActive(false);
         inst3.SetActive(false);

     

    }
}



