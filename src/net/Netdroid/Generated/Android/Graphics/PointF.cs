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
*  This file is generated by MASES.JNetReflector (ver. 2.5.5.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Graphics
{
    #region PointF
    public partial class PointF
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/PointF.html#%3Cinit%3E(android.graphics.Point)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Point"/></param>
        public PointF(Android.Graphics.Point arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/PointF.html#%3Cinit%3E(android.graphics.PointF)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.PointF"/></param>
        public PointF(Android.Graphics.PointF arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/PointF.html#%3Cinit%3E(float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        public PointF(float arg0, float arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/PointF.html#x"/>
        /// </summary>
        public float x { get { return IGetField<float>("x"); } set { ISetField("x", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/PointF.html#y"/>
        /// </summary>
        public float y { get { return IGetField<float>("y"); } set { ISetField("y", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/PointF.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/PointF.html#length(float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <returns><see cref="float"/></returns>
        public static float Length(float arg0, float arg1)
        {
            return SExecute<float>(LocalBridgeClazz, "length", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/PointF.html#equals(float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Equals(float arg0, float arg1)
        {
            return IExecute<bool>("equals", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/PointF.html#length()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float Length()
        {
            return IExecuteWithSignature<float>("length", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/PointF.html#negate()"/>
        /// </summary>
        public void Negate()
        {
            IExecuteWithSignature("negate", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/PointF.html#offset(float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        public void Offset(float arg0, float arg1)
        {
            IExecute("offset", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/PointF.html#set(android.graphics.PointF)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.PointF"/></param>
        public void Set(Android.Graphics.PointF arg0)
        {
            IExecuteWithSignature("set", "(Landroid/graphics/PointF;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/PointF.html#set(float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        public void Set(float arg0, float arg1)
        {
            IExecute("set", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/PointF.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/PointF.html#readFromParcel(android.os.Parcel)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        public void ReadFromParcel(Android.Os.Parcel arg0)
        {
            IExecuteWithSignature("readFromParcel", "(Landroid/os/Parcel;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/PointF.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecute("writeToParcel", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}