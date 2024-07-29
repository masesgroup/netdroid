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
*  This file is generated by MASES.JNetReflector (ver. 2.5.6.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Graphics
{
    #region Gainmap
    public partial class Gainmap
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Gainmap.html#%3Cinit%3E(android.graphics.Bitmap)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Bitmap"/></param>
        public Gainmap(Android.Graphics.Bitmap arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Gainmap.html#%3Cinit%3E(android.graphics.Gainmap,android.graphics.Bitmap)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Gainmap"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.Bitmap"/></param>
        public Gainmap(Android.Graphics.Gainmap arg0, Android.Graphics.Bitmap arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Gainmap.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Gainmap.html#getGainmapContents()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.Bitmap"/></returns>
        public Android.Graphics.Bitmap GetGainmapContents()
        {
            return IExecuteWithSignature<Android.Graphics.Bitmap>("getGainmapContents", "()Landroid/graphics/Bitmap;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Gainmap.html#getDisplayRatioForFullHdr()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetDisplayRatioForFullHdr()
        {
            return IExecuteWithSignature<float>("getDisplayRatioForFullHdr", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Gainmap.html#getMinDisplayRatioForHdrTransition()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetMinDisplayRatioForHdrTransition()
        {
            return IExecuteWithSignature<float>("getMinDisplayRatioForHdrTransition", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Gainmap.html#getEpsilonHdr()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float[] GetEpsilonHdr()
        {
            return IExecuteWithSignatureArray<float>("getEpsilonHdr", "()[F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Gainmap.html#getEpsilonSdr()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float[] GetEpsilonSdr()
        {
            return IExecuteWithSignatureArray<float>("getEpsilonSdr", "()[F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Gainmap.html#getGamma()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float[] GetGamma()
        {
            return IExecuteWithSignatureArray<float>("getGamma", "()[F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Gainmap.html#getRatioMax()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float[] GetRatioMax()
        {
            return IExecuteWithSignatureArray<float>("getRatioMax", "()[F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Gainmap.html#getRatioMin()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float[] GetRatioMin()
        {
            return IExecuteWithSignatureArray<float>("getRatioMin", "()[F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Gainmap.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Gainmap.html#setDisplayRatioForFullHdr(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        public void SetDisplayRatioForFullHdr(float arg0)
        {
            IExecuteWithSignature("setDisplayRatioForFullHdr", "(F)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Gainmap.html#setEpsilonHdr(float,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        public void SetEpsilonHdr(float arg0, float arg1, float arg2)
        {
            IExecute("setEpsilonHdr", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Gainmap.html#setEpsilonSdr(float,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        public void SetEpsilonSdr(float arg0, float arg1, float arg2)
        {
            IExecute("setEpsilonSdr", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Gainmap.html#setGainmapContents(android.graphics.Bitmap)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Bitmap"/></param>
        public void SetGainmapContents(Android.Graphics.Bitmap arg0)
        {
            IExecuteWithSignature("setGainmapContents", "(Landroid/graphics/Bitmap;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Gainmap.html#setGamma(float,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        public void SetGamma(float arg0, float arg1, float arg2)
        {
            IExecute("setGamma", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Gainmap.html#setMinDisplayRatioForHdrTransition(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        public void SetMinDisplayRatioForHdrTransition(float arg0)
        {
            IExecuteWithSignature("setMinDisplayRatioForHdrTransition", "(F)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Gainmap.html#setRatioMax(float,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        public void SetRatioMax(float arg0, float arg1, float arg2)
        {
            IExecute("setRatioMax", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Gainmap.html#setRatioMin(float,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        public void SetRatioMin(float arg0, float arg1, float arg2)
        {
            IExecute("setRatioMin", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Gainmap.html#writeToParcel(android.os.Parcel,int)"/>
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