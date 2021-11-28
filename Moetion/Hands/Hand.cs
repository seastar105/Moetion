// Copyright (c) The Vignette Authors
// This file is part of Moetion.
// Moetion is licensed under the BSD 3-Clause License. See LICENSE for details.

using System.Numerics;

namespace Moetion.Hands
{
    public struct Hand
    {
        public Vector3[] Palm;
        // TODO: convert to Quaternion
        public Vector3 Rotation;
        public Vector3 Wrist;

        // TODO: make a Finger struct with Proximal, Intermediate and Distal fields. Will be much more readable and easy to work with, probably.

        #region Thumb

        public Vector3 ThumbProximal;
        public Vector3 ThumbIntermediate;
        public Vector3 ThumbDistal;

        #endregion

        #region Index Finger

        public Vector3 IndexProximal;
        public Vector3 IndexIntermediate;
        public Vector3 IndexDistal;

        #endregion

        #region Middle Finger

        public Vector3 MiddleProximal;
        public Vector3 MiddleIntermediate;
        public Vector3 MiddleDistal;

        #endregion

        #region Ring Finger

        public Vector3 RingProximal;
        public Vector3 RingIntermediate;
        public Vector3 RingDistal;

        #endregion

        #region Little Finger

        public Vector3 LittleProximal;
        public Vector3 LittleIntermediate;
        public Vector3 LittleDistal;

        #endregion
    }
}
