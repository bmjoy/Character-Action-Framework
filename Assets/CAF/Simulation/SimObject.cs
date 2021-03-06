﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CAF.Simulation
{
    public class SimObject : MonoBehaviour
    {
        public SimObjectManager simObjectManager;

        protected virtual void Awake()
        {
            SimAwake();
        }

        protected virtual void Start()
        {
            SimStart();
        }

        /// <summary>
        /// Called once as soon as the script is initialized.
        /// </summary>
        public virtual void SimAwake()
        {
        }

        /// <summary>
        /// Called once after awake.
        /// </summary>
        public virtual void SimStart()
        {
        }

        /// <summary>
        /// Called every simulations tick.
        /// </summary>
        public virtual void SimUpdate()
        {
        }

        /// <summary>
        /// Called every simulation tick after all updates are called.
        /// </summary>
        public virtual void SimLateUpdate()
        {
        }
    }
}