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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Content.Res
{
    #region ColorStateList
    public partial class ColorStateList
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/res/ColorStateList.html#%3Cinit%3E(int[][],int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public ColorStateList(int[][] arg0, int[] arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/res/ColorStateList.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/res/ColorStateList.html#createFromXml(android.content.res.Resources,org.xmlpull.v1.XmlPullParser,android.content.res.Resources.Theme)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Res.Resources"/></param>
        /// <param name="arg1"><see cref="Org.Xmlpull.V1.XmlPullParser"/></param>
        /// <param name="arg2"><see cref="Android.Content.Res.Resources.Theme"/></param>
        /// <returns><see cref="Android.Content.Res.ColorStateList"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Org.Xmlpull.V1.XmlPullParserException"/>
        public static Android.Content.Res.ColorStateList CreateFromXml(Android.Content.Res.Resources arg0, Org.Xmlpull.V1.XmlPullParser arg1, Android.Content.Res.Resources.Theme arg2)
        {
            return SExecute<Android.Content.Res.ColorStateList>(LocalBridgeClazz, "createFromXml", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/res/ColorStateList.html#createFromXml(android.content.res.Resources,org.xmlpull.v1.XmlPullParser)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Res.Resources"/></param>
        /// <param name="arg1"><see cref="Org.Xmlpull.V1.XmlPullParser"/></param>
        /// <returns><see cref="Android.Content.Res.ColorStateList"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Org.Xmlpull.V1.XmlPullParserException"/>
        [global::System.Obsolete()]
        public static Android.Content.Res.ColorStateList CreateFromXml(Android.Content.Res.Resources arg0, Org.Xmlpull.V1.XmlPullParser arg1)
        {
            return SExecute<Android.Content.Res.ColorStateList>(LocalBridgeClazz, "createFromXml", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/res/ColorStateList.html#valueOf(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Content.Res.ColorStateList"/></returns>
        public static Android.Content.Res.ColorStateList ValueOf(int arg0)
        {
            return SExecuteWithSignature<Android.Content.Res.ColorStateList>(LocalBridgeClazz, "valueOf", "(I)Landroid/content/res/ColorStateList;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/res/ColorStateList.html#withAlpha(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Content.Res.ColorStateList"/></returns>
        public Android.Content.Res.ColorStateList WithAlpha(int arg0)
        {
            return IExecuteWithSignature<Android.Content.Res.ColorStateList>("withAlpha", "(I)Landroid/content/res/ColorStateList;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/res/ColorStateList.html#withLStar(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="Android.Content.Res.ColorStateList"/></returns>
        public Android.Content.Res.ColorStateList WithLStar(float arg0)
        {
            return IExecuteWithSignature<Android.Content.Res.ColorStateList>("withLStar", "(F)Landroid/content/res/ColorStateList;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/res/ColorStateList.html#isOpaque()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsOpaque()
        {
            return IExecuteWithSignature<bool>("isOpaque", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/res/ColorStateList.html#isStateful()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsStateful()
        {
            return IExecuteWithSignature<bool>("isStateful", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/res/ColorStateList.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/res/ColorStateList.html#getChangingConfigurations()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetChangingConfigurations()
        {
            return IExecuteWithSignature<int>("getChangingConfigurations", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/res/ColorStateList.html#getColorForState(int[],int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetColorForState(int[] arg0, int arg1)
        {
            return IExecute<int>("getColorForState", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/res/ColorStateList.html#getDefaultColor()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetDefaultColor()
        {
            return IExecuteWithSignature<int>("getDefaultColor", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/res/ColorStateList.html#writeToParcel(android.os.Parcel,int)"/>
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