using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Source
{
    public class Core : MonoBehaviour
    {
        public static Core Instance;

        void Awake()
        {
            //incialize app core
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else if (Instance != this)
            {
                DestroyImmediate(gameObject);
            }

            Application.targetFrameRate = 60;
        }
    }
}
