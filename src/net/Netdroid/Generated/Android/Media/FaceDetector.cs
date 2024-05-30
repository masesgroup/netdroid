/*
*  Copyright 2024 MASES s.r.l.
*
*  Licensed under the Apache License, Version 2.0 (the "License");
*  you may not use this file except in compliance with the License.
*  You may obtain a copy of the License at
*
*  http://www.apache.org/licenses/LICENSE-2.0
*
*  Unless required by applicable law or agreed to in writing, software
*  distributed under the License is distributed on an "AS IS" BASIS,
*  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
*  See the License for the specific language governing permissions and
*  limitations under the License.
*
*  Refer to LICENSE for more information.
*/

/*
*  This file is generated by MASES.JNetReflector (ver. 2.5.1.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Media
{
    #region FaceDetector
    public partial class FaceDetector
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/FaceDetector.html#%3Cinit%3E(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public FaceDetector(int arg0, int arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/FaceDetector.html#findFaces(android.graphics.Bitmap,android.media.FaceDetector.Face[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Bitmap"/></param>
        /// <param name="arg1"><see cref="Android.Media.FaceDetector.Face"/></param>
        /// <returns><see cref="int"/></returns>
        public int FindFaces(Android.Graphics.Bitmap arg0, Android.Media.FaceDetector.Face[] arg1)
        {
            return IExecute<int>("findFaces", arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region Face
        public partial class Face
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/FaceDetector.Face.html#CONFIDENCE_THRESHOLD"/>
            /// </summary>
            public static float CONFIDENCE_THRESHOLD { get { if (!_CONFIDENCE_THRESHOLDReady) { _CONFIDENCE_THRESHOLDContent = SGetField<float>(LocalBridgeClazz, "CONFIDENCE_THRESHOLD"); _CONFIDENCE_THRESHOLDReady = true; } return _CONFIDENCE_THRESHOLDContent; } }
            private static float _CONFIDENCE_THRESHOLDContent = default;
            private static bool _CONFIDENCE_THRESHOLDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/FaceDetector.Face.html#EULER_X"/>
            /// </summary>
            public static int EULER_X { get { if (!_EULER_XReady) { _EULER_XContent = SGetField<int>(LocalBridgeClazz, "EULER_X"); _EULER_XReady = true; } return _EULER_XContent; } }
            private static int _EULER_XContent = default;
            private static bool _EULER_XReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/FaceDetector.Face.html#EULER_Y"/>
            /// </summary>
            public static int EULER_Y { get { if (!_EULER_YReady) { _EULER_YContent = SGetField<int>(LocalBridgeClazz, "EULER_Y"); _EULER_YReady = true; } return _EULER_YContent; } }
            private static int _EULER_YContent = default;
            private static bool _EULER_YReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/FaceDetector.Face.html#EULER_Z"/>
            /// </summary>
            public static int EULER_Z { get { if (!_EULER_ZReady) { _EULER_ZContent = SGetField<int>(LocalBridgeClazz, "EULER_Z"); _EULER_ZReady = true; } return _EULER_ZContent; } }
            private static int _EULER_ZContent = default;
            private static bool _EULER_ZReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/FaceDetector.Face.html#confidence()"/>
            /// </summary>
            /// <returns><see cref="float"/></returns>
            public float Confidence()
            {
                return IExecuteWithSignature<float>("confidence", "()F");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/FaceDetector.Face.html#eyesDistance()"/>
            /// </summary>
            /// <returns><see cref="float"/></returns>
            public float EyesDistance()
            {
                return IExecuteWithSignature<float>("eyesDistance", "()F");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/FaceDetector.Face.html#pose(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="float"/></returns>
            public float Pose(int arg0)
            {
                return IExecuteWithSignature<float>("pose", "(I)F", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/FaceDetector.Face.html#getMidPoint(android.graphics.PointF)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Graphics.PointF"/></param>
            public void GetMidPoint(Android.Graphics.PointF arg0)
            {
                IExecuteWithSignature("getMidPoint", "(Landroid/graphics/PointF;)V", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}