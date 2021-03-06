﻿using System;

namespace ObcidiaNetwork.Base
{
    /// <summary>
    /// Represents styatic methods of sigmoid function
    /// </summary>
    internal class Sigmoid
    {
        /// <summary>
        /// used to calculate output values.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static double Output (double value)
        {
            //return 1.0f / (float)(1.0f + Math.Exp (-value));
            return value < -45.0 ? 0.0 : value > 45.0 ? 1.0 : 1.0 / (1.0 + Math.Exp (-value));
        }

        /// <summary>
        /// Used to calculate new weight values.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static double Derivative (double value)
        {
            return value * (1 - value);
        }
    }
}