// Copyright (c) The Vignette Authors
// This file is part of Moetion.
// Moetion is licensed under LGPL v3. See LICENSE.md for details.

using System.Numerics;

namespace Moetion.Hands
{
    public struct Hand
    {
        // FIXME: kalidokit takes a Vector array with 3 Vectors, so I'm not sure if this is correct.
        public Vector3[] Palm;
        // FIXME: Handrotation might be a vector array but I might be wrong.
        public Vector3[] HandRotation;
        public Vector3 Wrist;

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