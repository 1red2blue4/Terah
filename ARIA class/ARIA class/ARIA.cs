/*
 * Program: ARIA class
 * Programmer: Ian Davis
 * Purpose: Outline for emotional spectrum for battles & NPCS
 * Date: 11/2/16
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARIA_class
{
    /*
     * CLASS DESCRIPTION:
     * Every emotion listed as attributes will have their values manipulated throughout the game.
     * Each emotion is not isolated, if one increases or decreases, the others will shift accordingly
     * At the moment, each emotion is only able to shift one intensity at a time in either direction, but 
     * has a range from 1 to 3. If they go beyond this range, then they will be set to the maximum or
     * minimum values accordingly. 
     * 
     * EXAMPLE:
     * In a test class, we make an ARIA object's method call, for instance 'JoyPlus()'.
     * Let's say 'joy' was set to 2, now it will increase to 3.
     * The other emotions will all decrease by 1, making joy the predominant emotion.
     * If, for instance, 'stoic' was already set to 1, then it will remain at that value.
     * 
     * */

    class ARIA
    {
        //8 emotions, 3 intensities (set to 2 by default, should be specified in object paramters
        private int joy=2;//pink
        private int calm = 2;//green
        private int stoic = 2;//dark blue
        private int suspicious = 2;//orange
        private int touchy = 2;//black
        private int sad = 2;//light blue
        private int scared = 2;//yellow
        private int angry = 2;//red
        
        //values of emotions should be initialized when ARIA object created
        public ARIA(int j,int c,int st,int su,int t, int sa, int sc,int a)
        {
            //NOTE: When object created, all parameters should be entered in this order
            //to prevent the logical error of values going to the wrong variable
            joy = j;
            calm = c;
            stoic = st;
            suspicious = su;
            touchy = t;
            sad = sa;
            scared = sc;
            angry = a;

            //keeping intensity level of each emotion in range 1-3
            int[] emoValues = { joy, calm, stoic, suspicious, touchy, sad, scared, angry };//to make checks more efficient
            for(int i=0;i<emoValues.Length;i++)
            {
                //intensity check
                if (emoValues[i] < 1)
                    emoValues[i] = 1;
                else if (emoValues[i] > 3)
                    emoValues[i] = 3;
            }
        }//end of constructor

        //------------------------------------------------------METHODS------------------------------------------------------------
        //Each of these methods will control the emotion values
        //--JOY--
        public int Joy { get { return joy; } set { joy = value; } }
        public void JoyPlus()//increase 'joy', decreases others
        {
            int []otherValues = {calm, stoic, suspicious, touchy, sad, scared, angry };//for easier checks
            joy++;

            //range check
            if (joy > 3)
                joy = 3;

            //other values decrease
            for(int i=0;i<otherValues.Length;i++)
            {
                otherValues[i]--;

                //range check
                if (otherValues[i] < 1)
                    otherValues[i] = 1;
            }
        }//end of method

        public void JoyMinus()//decrease 'joy', increases others
        {
            int[] otherValues = { calm, stoic, suspicious, touchy, sad, scared, angry };//for easier checks
            joy--;

            //range check
            if (joy < 1)
                joy = 1;

            //other values decrease
            for (int i = 0; i < otherValues.Length; i++)
            {
                otherValues[i]++;

                //range check
                if (otherValues[i] > 3)
                    otherValues[i] = 3;
            }
        }//end of method

        //--CALM--
        public int Calm { get { return calm; } set { calm = value; } }
        public void CalmPlus()//increase 'calm', decreases others
        {
            int[] otherValues = { joy, stoic, suspicious, touchy, sad, scared, angry };//for easier checks
            calm++;

            //range check
            if (calm > 3)
                calm = 3;

            //other values decrease
            for (int i = 0; i < otherValues.Length; i++)
            {
                otherValues[i]--;

                //range check
                if (otherValues[i] < 1)
                    otherValues[i] = 1;
            }
        }//end of method

        public void CalmMinus()//decrease 'calm', increases others
        {
            int[] otherValues = { joy, stoic, suspicious, touchy, sad, scared, angry };//for easier checks
            calm--;

            //range check
            if (calm < 1)
                calm = 1;

            //other values decrease
            for (int i = 0; i < otherValues.Length; i++)
            {
                otherValues[i]++;

                //range check
                if (otherValues[i] > 3)
                    otherValues[i] = 3;
            }
        }//end of method

        //--STOIC--
        public int Stoic { get { return stoic; } set { stoic = value; } }
        public void StoicPlus()//increase 'stoic', decreases others
        {
            int[] otherValues = { joy, calm, suspicious, touchy, sad, scared, angry };//for easier checks
            stoic++;

            //range check
            if (stoic > 3)
                stoic = 3;

            //other values decrease
            for (int i = 0; i < otherValues.Length; i++)
            {
                otherValues[i]--;

                //range check
                if (otherValues[i] < 1)
                    otherValues[i] = 1;
            }
        }//end of method

        public void StoicMinus()//decrease 'stoic', increases others
        {
            int[] otherValues = { joy, calm, suspicious, touchy, sad, scared, angry };//for easier checks
            stoic--;

            //range check
            if (stoic < 1)
                stoic = 1;

            //other values decrease
            for (int i = 0; i < otherValues.Length; i++)
            {
                otherValues[i]++;

                //range check
                if (otherValues[i] > 3)
                    otherValues[i] = 3;
            }
        }//end of method

        //--SUSPICIOUS--
        public int Suspicious { get { return suspicious; } set { suspicious = value; } }
        public void SuspiciousPlus()//increase 'suspicious', decreases others
        {
            int[] otherValues = { joy, calm, stoic, touchy, sad, scared, angry };//for easier checks
            suspicious++;

            //range check
            if (suspicious > 3)
                suspicious = 3;

            //other values decrease
            for (int i = 0; i < otherValues.Length; i++)
            {
                otherValues[i]--;

                //range check
                if (otherValues[i] < 1)
                    otherValues[i] = 1;
            }
        }//end of method

        public void SuspiciousMinus()//decrease 'suspicious', increases others
        {
            int[] otherValues = { joy, calm, stoic, touchy, sad, scared, angry };//for easier checks
            suspicious--;

            //range check
            if (suspicious < 1)
                suspicious = 1;

            //other values decrease
            for (int i = 0; i < otherValues.Length; i++)
            {
                otherValues[i]++;

                //range check
                if (otherValues[i] > 3)
                    otherValues[i] = 3;
            }
        }//end of method

        //--TOUCHY--
        public int Touchy { get { return touchy; } set { touchy = value; } }
        public void TouchyPlus()//increase 'touchy', decreases others
        {
            int[] otherValues = { joy, calm, stoic, suspicious, sad, scared, angry };//for easier checks
            touchy++;

            //range check
            if (touchy > 3)
                touchy = 3;

            //other values decrease
            for (int i = 0; i < otherValues.Length; i++)
            {
                otherValues[i]--;

                //range check
                if (otherValues[i] < 1)
                    otherValues[i] = 1;
            }
        }//end of method

        public void TouchyMinus()//decrease 'touchy', increases others
        {
            int[] otherValues = { joy, calm, stoic, suspicious, sad, scared, angry };//for easier checks
            touchy--;

            //range check
            if (touchy < 1)
                touchy = 1;

            //other values decrease
            for (int i = 0; i < otherValues.Length; i++)
            {
                otherValues[i]++;

                //range check
                if (otherValues[i] > 3)
                    otherValues[i] = 3;
            }
        }//end of method

        //--SAD--
        public int Sad { get { return sad; } set { sad = value; } }
        public void SadPlus()//increase 'sad', decreases others
        {
            int[] otherValues = { joy, calm, stoic, suspicious, touchy, scared, angry };//for easier checks
            sad++;

            //range check
            if (sad > 3)
                sad = 3;

            //other values decrease
            for (int i = 0; i < otherValues.Length; i++)
            {
                otherValues[i]--;

                //range check
                if (otherValues[i] < 1)
                    otherValues[i] = 1;
            }
        }//end of method

        public void SadMinus()//decrease 'sad', increases others
        {
            int[] otherValues = { joy, calm, stoic, suspicious, touchy, scared, angry };//for easier checks
            sad--;

            //range check
            if (sad < 1)
                sad = 1;

            //other values decrease
            for (int i = 0; i < otherValues.Length; i++)
            {
                otherValues[i]++;

                //range check
                if (otherValues[i] > 3)
                    otherValues[i] = 3;
            }
        }//end of method

        //--SCARED--
        public int Scared { get { return scared; } set { scared = value; } }
        public void ScaredPlus()//increase 'scared', decreases others
        {
            int[] otherValues = { joy, calm, stoic, suspicious, touchy, sad, angry };//for easier checks
            scared++;

            //range check
            if (scared > 3)
                scared = 3;

            //other values decrease
            for (int i = 0; i < otherValues.Length; i++)
            {
                otherValues[i]--;

                //range check
                if (otherValues[i] < 1)
                    otherValues[i] = 1;
            }
        }//end of method

        public void ScaredMinus()//decrease 'scared', increases others
        {
            int[] otherValues = { joy, calm, stoic, suspicious, touchy, sad, angry };//for easier checks
            scared--;

            //range check
            if (scared < 1)
                scared = 1;

            //other values decrease
            for (int i = 0; i < otherValues.Length; i++)
            {
                otherValues[i]++;

                //range check
                if (otherValues[i] > 3)
                    otherValues[i] = 3;
            }
        }//end of method

        //--ANGRY--
        public int Angry { get { return angry; } set { angry = value; } }
        public void AngryPlus()//increase 'angry', decreases others
        {
            int[] otherValues = { joy, calm, stoic, suspicious, touchy, sad, scared };//for easier checks
            angry++;

            //range check
            if (angry > 3)
                angry = 3;

            //other values decrease
            for (int i = 0; i < otherValues.Length; i++)
            {
                otherValues[i]--;

                //range check
                if (otherValues[i] < 1)
                    otherValues[i] = 1;
            }
        }//end of method

        public void AngryMinus()//decrease 'angry', increases others
        {
            int[] otherValues = { joy, calm, stoic, suspicious, touchy, sad, scared };//for easier checks
            angry--;

            //range check
            if (angry < 1)
                angry = 1;

            //other values decrease
            for (int i = 0; i < otherValues.Length; i++)
            {
                otherValues[i]++;

                //range check
                if (otherValues[i] > 3)
                    otherValues[i] = 3;
            }
        }//end of method
    }
}
