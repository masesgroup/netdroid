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

namespace Android.Graphics
{
    #region Matrix
    public partial class Matrix
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Matrix.html#%3Cinit%3E(android.graphics.Matrix)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Matrix"/></param>
        public Matrix(Android.Graphics.Matrix arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Matrix.html#IDENTITY_MATRIX"/>
        /// </summary>
        public static Android.Graphics.Matrix IDENTITY_MATRIX { get { if (!_IDENTITY_MATRIXReady) { _IDENTITY_MATRIXContent = SGetField<Android.Graphics.Matrix>(LocalBridgeClazz, "IDENTITY_MATRIX"); _IDENTITY_MATRIXReady = true; } return _IDENTITY_MATRIXContent; } }
        private static Android.Graphics.Matrix _IDENTITY_MATRIXContent = default;
        private static bool _IDENTITY_MATRIXReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Matrix.html#MPERSP_0"/>
        /// </summary>
        public static int MPERSP_0 { get { if (!_MPERSP_0Ready) { _MPERSP_0Content = SGetField<int>(LocalBridgeClazz, "MPERSP_0"); _MPERSP_0Ready = true; } return _MPERSP_0Content; } }
        private static int _MPERSP_0Content = default;
        private static bool _MPERSP_0Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Matrix.html#MPERSP_1"/>
        /// </summary>
        public static int MPERSP_1 { get { if (!_MPERSP_1Ready) { _MPERSP_1Content = SGetField<int>(LocalBridgeClazz, "MPERSP_1"); _MPERSP_1Ready = true; } return _MPERSP_1Content; } }
        private static int _MPERSP_1Content = default;
        private static bool _MPERSP_1Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Matrix.html#MPERSP_2"/>
        /// </summary>
        public static int MPERSP_2 { get { if (!_MPERSP_2Ready) { _MPERSP_2Content = SGetField<int>(LocalBridgeClazz, "MPERSP_2"); _MPERSP_2Ready = true; } return _MPERSP_2Content; } }
        private static int _MPERSP_2Content = default;
        private static bool _MPERSP_2Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Matrix.html#MSCALE_X"/>
        /// </summary>
        public static int MSCALE_X { get { if (!_MSCALE_XReady) { _MSCALE_XContent = SGetField<int>(LocalBridgeClazz, "MSCALE_X"); _MSCALE_XReady = true; } return _MSCALE_XContent; } }
        private static int _MSCALE_XContent = default;
        private static bool _MSCALE_XReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Matrix.html#MSCALE_Y"/>
        /// </summary>
        public static int MSCALE_Y { get { if (!_MSCALE_YReady) { _MSCALE_YContent = SGetField<int>(LocalBridgeClazz, "MSCALE_Y"); _MSCALE_YReady = true; } return _MSCALE_YContent; } }
        private static int _MSCALE_YContent = default;
        private static bool _MSCALE_YReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Matrix.html#MSKEW_X"/>
        /// </summary>
        public static int MSKEW_X { get { if (!_MSKEW_XReady) { _MSKEW_XContent = SGetField<int>(LocalBridgeClazz, "MSKEW_X"); _MSKEW_XReady = true; } return _MSKEW_XContent; } }
        private static int _MSKEW_XContent = default;
        private static bool _MSKEW_XReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Matrix.html#MSKEW_Y"/>
        /// </summary>
        public static int MSKEW_Y { get { if (!_MSKEW_YReady) { _MSKEW_YContent = SGetField<int>(LocalBridgeClazz, "MSKEW_Y"); _MSKEW_YReady = true; } return _MSKEW_YContent; } }
        private static int _MSKEW_YContent = default;
        private static bool _MSKEW_YReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Matrix.html#MTRANS_X"/>
        /// </summary>
        public static int MTRANS_X { get { if (!_MTRANS_XReady) { _MTRANS_XContent = SGetField<int>(LocalBridgeClazz, "MTRANS_X"); _MTRANS_XReady = true; } return _MTRANS_XContent; } }
        private static int _MTRANS_XContent = default;
        private static bool _MTRANS_XReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Matrix.html#MTRANS_Y"/>
        /// </summary>
        public static int MTRANS_Y { get { if (!_MTRANS_YReady) { _MTRANS_YContent = SGetField<int>(LocalBridgeClazz, "MTRANS_Y"); _MTRANS_YReady = true; } return _MTRANS_YContent; } }
        private static int _MTRANS_YContent = default;
        private static bool _MTRANS_YReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Matrix.html#invert(android.graphics.Matrix)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Matrix"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Invert(Android.Graphics.Matrix arg0)
        {
            return IExecuteWithSignature<bool>("invert", "(Landroid/graphics/Matrix;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Matrix.html#isAffine()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsAffine()
        {
            return IExecuteWithSignature<bool>("isAffine", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Matrix.html#isIdentity()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsIdentity()
        {
            return IExecuteWithSignature<bool>("isIdentity", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Matrix.html#mapRect(android.graphics.RectF,android.graphics.RectF)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.RectF"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.RectF"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool MapRect(Android.Graphics.RectF arg0, Android.Graphics.RectF arg1)
        {
            return IExecute<bool>("mapRect", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Matrix.html#mapRect(android.graphics.RectF)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.RectF"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool MapRect(Android.Graphics.RectF arg0)
        {
            return IExecuteWithSignature<bool>("mapRect", "(Landroid/graphics/RectF;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Matrix.html#postConcat(android.graphics.Matrix)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Matrix"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool PostConcat(Android.Graphics.Matrix arg0)
        {
            return IExecuteWithSignature<bool>("postConcat", "(Landroid/graphics/Matrix;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Matrix.html#postRotate(float,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool PostRotate(float arg0, float arg1, float arg2)
        {
            return IExecute<bool>("postRotate", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Matrix.html#postRotate(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool PostRotate(float arg0)
        {
            return IExecuteWithSignature<bool>("postRotate", "(F)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Matrix.html#postScale(float,float,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool PostScale(float arg0, float arg1, float arg2, float arg3)
        {
            return IExecute<bool>("postScale", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Matrix.html#postScale(float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool PostScale(float arg0, float arg1)
        {
            return IExecute<bool>("postScale", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Matrix.html#postSkew(float,float,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool PostSkew(float arg0, float arg1, float arg2, float arg3)
        {
            return IExecute<bool>("postSkew", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Matrix.html#postSkew(float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool PostSkew(float arg0, float arg1)
        {
            return IExecute<bool>("postSkew", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Matrix.html#postTranslate(float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool PostTranslate(float arg0, float arg1)
        {
            return IExecute<bool>("postTranslate", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Matrix.html#preConcat(android.graphics.Matrix)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Matrix"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool PreConcat(Android.Graphics.Matrix arg0)
        {
            return IExecuteWithSignature<bool>("preConcat", "(Landroid/graphics/Matrix;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Matrix.html#preRotate(float,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool PreRotate(float arg0, float arg1, float arg2)
        {
            return IExecute<bool>("preRotate", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Matrix.html#preRotate(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool PreRotate(float arg0)
        {
            return IExecuteWithSignature<bool>("preRotate", "(F)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Matrix.html#preScale(float,float,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool PreScale(float arg0, float arg1, float arg2, float arg3)
        {
            return IExecute<bool>("preScale", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Matrix.html#preScale(float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool PreScale(float arg0, float arg1)
        {
            return IExecute<bool>("preScale", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Matrix.html#preSkew(float,float,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool PreSkew(float arg0, float arg1, float arg2, float arg3)
        {
            return IExecute<bool>("preSkew", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Matrix.html#preSkew(float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool PreSkew(float arg0, float arg1)
        {
            return IExecute<bool>("preSkew", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Matrix.html#preTranslate(float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool PreTranslate(float arg0, float arg1)
        {
            return IExecute<bool>("preTranslate", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Matrix.html#rectStaysRect()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool RectStaysRect()
        {
            return IExecuteWithSignature<bool>("rectStaysRect", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Matrix.html#setConcat(android.graphics.Matrix,android.graphics.Matrix)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Matrix"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.Matrix"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SetConcat(Android.Graphics.Matrix arg0, Android.Graphics.Matrix arg1)
        {
            return IExecute<bool>("setConcat", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Matrix.html#setPolyToPoly(float[],int,float[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SetPolyToPoly(float[] arg0, int arg1, float[] arg2, int arg3, int arg4)
        {
            return IExecute<bool>("setPolyToPoly", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Matrix.html#setRectToRect(android.graphics.RectF,android.graphics.RectF,android.graphics.Matrix.ScaleToFit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.RectF"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.RectF"/></param>
        /// <param name="arg2"><see cref="Android.Graphics.Matrix.ScaleToFit"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SetRectToRect(Android.Graphics.RectF arg0, Android.Graphics.RectF arg1, Android.Graphics.Matrix.ScaleToFit arg2)
        {
            return IExecute<bool>("setRectToRect", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Matrix.html#dump(java.io.PrintWriter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.PrintWriter"/></param>
        public void Dump(Java.Io.PrintWriter arg0)
        {
            IExecuteWithSignature("dump", "(Ljava/io/PrintWriter;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Matrix.html#mapRadius(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="float"/></returns>
        public float MapRadius(float arg0)
        {
            return IExecuteWithSignature<float>("mapRadius", "(F)F", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Matrix.html#toShortString()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String ToShortString()
        {
            return IExecuteWithSignature<Java.Lang.String>("toShortString", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Matrix.html#getValues(float[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        public void GetValues(float[] arg0)
        {
            IExecuteWithSignature("getValues", "([F)V", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Matrix.html#mapPoints(float[],float[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        public void MapPoints(float[] arg0, float[] arg1)
        {
            IExecute("mapPoints", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Matrix.html#mapPoints(float[],int,float[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        public void MapPoints(float[] arg0, int arg1, float[] arg2, int arg3, int arg4)
        {
            IExecute("mapPoints", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Matrix.html#mapPoints(float[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        public void MapPoints(float[] arg0)
        {
            IExecuteWithSignature("mapPoints", "([F)V", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Matrix.html#mapVectors(float[],float[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        public void MapVectors(float[] arg0, float[] arg1)
        {
            IExecute("mapVectors", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Matrix.html#mapVectors(float[],int,float[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        public void MapVectors(float[] arg0, int arg1, float[] arg2, int arg3, int arg4)
        {
            IExecute("mapVectors", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Matrix.html#mapVectors(float[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        public void MapVectors(float[] arg0)
        {
            IExecuteWithSignature("mapVectors", "([F)V", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Matrix.html#reset()"/>
        /// </summary>
        public void Reset()
        {
            IExecuteWithSignature("reset", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Matrix.html#set(android.graphics.Matrix)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Matrix"/></param>
        public void Set(Android.Graphics.Matrix arg0)
        {
            IExecuteWithSignature("set", "(Landroid/graphics/Matrix;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Matrix.html#setRotate(float,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        public void SetRotate(float arg0, float arg1, float arg2)
        {
            IExecute("setRotate", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Matrix.html#setRotate(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        public void SetRotate(float arg0)
        {
            IExecuteWithSignature("setRotate", "(F)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Matrix.html#setScale(float,float,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        public void SetScale(float arg0, float arg1, float arg2, float arg3)
        {
            IExecute("setScale", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Matrix.html#setScale(float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        public void SetScale(float arg0, float arg1)
        {
            IExecute("setScale", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Matrix.html#setSinCos(float,float,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        public void SetSinCos(float arg0, float arg1, float arg2, float arg3)
        {
            IExecute("setSinCos", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Matrix.html#setSinCos(float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        public void SetSinCos(float arg0, float arg1)
        {
            IExecute("setSinCos", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Matrix.html#setSkew(float,float,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        public void SetSkew(float arg0, float arg1, float arg2, float arg3)
        {
            IExecute("setSkew", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Matrix.html#setSkew(float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        public void SetSkew(float arg0, float arg1)
        {
            IExecute("setSkew", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Matrix.html#setTranslate(float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        public void SetTranslate(float arg0, float arg1)
        {
            IExecute("setTranslate", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Matrix.html#setValues(float[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        public void SetValues(float[] arg0)
        {
            IExecuteWithSignature("setValues", "([F)V", new object[] { arg0 });
        }

        #endregion

        #region Nested classes
        #region ScaleToFit
        public partial class ScaleToFit
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/Matrix.ScaleToFit.html#CENTER"/>
            /// </summary>
            public static Android.Graphics.Matrix.ScaleToFit CENTER { get { if (!_CENTERReady) { _CENTERContent = SGetField<Android.Graphics.Matrix.ScaleToFit>(LocalBridgeClazz, "CENTER"); _CENTERReady = true; } return _CENTERContent; } }
            private static Android.Graphics.Matrix.ScaleToFit _CENTERContent = default;
            private static bool _CENTERReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/Matrix.ScaleToFit.html#END"/>
            /// </summary>
            public static Android.Graphics.Matrix.ScaleToFit END { get { if (!_ENDReady) { _ENDContent = SGetField<Android.Graphics.Matrix.ScaleToFit>(LocalBridgeClazz, "END"); _ENDReady = true; } return _ENDContent; } }
            private static Android.Graphics.Matrix.ScaleToFit _ENDContent = default;
            private static bool _ENDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/Matrix.ScaleToFit.html#FILL"/>
            /// </summary>
            public static Android.Graphics.Matrix.ScaleToFit FILL { get { if (!_FILLReady) { _FILLContent = SGetField<Android.Graphics.Matrix.ScaleToFit>(LocalBridgeClazz, "FILL"); _FILLReady = true; } return _FILLContent; } }
            private static Android.Graphics.Matrix.ScaleToFit _FILLContent = default;
            private static bool _FILLReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/Matrix.ScaleToFit.html#START"/>
            /// </summary>
            public static Android.Graphics.Matrix.ScaleToFit START { get { if (!_STARTReady) { _STARTContent = SGetField<Android.Graphics.Matrix.ScaleToFit>(LocalBridgeClazz, "START"); _STARTReady = true; } return _STARTContent; } }
            private static Android.Graphics.Matrix.ScaleToFit _STARTContent = default;
            private static bool _STARTReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/Matrix.ScaleToFit.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Graphics.Matrix.ScaleToFit"/></returns>
            public static Android.Graphics.Matrix.ScaleToFit ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Android.Graphics.Matrix.ScaleToFit>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Matrix$ScaleToFit;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/Matrix.ScaleToFit.html#values()"/>
            /// </summary>
            /// <returns><see cref="Android.Graphics.Matrix.ScaleToFit"/></returns>
            public static Android.Graphics.Matrix.ScaleToFit[] Values()
            {
                return SExecuteWithSignatureArray<Android.Graphics.Matrix.ScaleToFit>(LocalBridgeClazz, "values", "()[Landroid/graphics/Matrix$ScaleToFit;");
            }

            #endregion

            #region Instance methods

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