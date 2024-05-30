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

namespace Android.View.Textservice
{
    #region SentenceSuggestionsInfo
    public partial class SentenceSuggestionsInfo
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textservice/SentenceSuggestionsInfo.html#%3Cinit%3E(android.os.Parcel)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        public SentenceSuggestionsInfo(Android.Os.Parcel arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textservice/SentenceSuggestionsInfo.html#%3Cinit%3E(android.view.textservice.SuggestionsInfo[],int[],int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Textservice.SuggestionsInfo"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public SentenceSuggestionsInfo(Android.View.Textservice.SuggestionsInfo[] arg0, int[] arg1, int[] arg2)
            : base(arg0, arg1, arg2)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textservice/SentenceSuggestionsInfo.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textservice/SentenceSuggestionsInfo.html#getSuggestionsCount()"/> 
        /// </summary>
        public int SuggestionsCount
        {
            get { return IExecuteWithSignature<int>("getSuggestionsCount", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textservice/SentenceSuggestionsInfo.html#getSuggestionsInfoAt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.View.Textservice.SuggestionsInfo"/></returns>
        public Android.View.Textservice.SuggestionsInfo GetSuggestionsInfoAt(int arg0)
        {
            return IExecuteWithSignature<Android.View.Textservice.SuggestionsInfo>("getSuggestionsInfoAt", "(I)Landroid/view/textservice/SuggestionsInfo;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textservice/SentenceSuggestionsInfo.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textservice/SentenceSuggestionsInfo.html#getLengthAt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetLengthAt(int arg0)
        {
            return IExecuteWithSignature<int>("getLengthAt", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textservice/SentenceSuggestionsInfo.html#getOffsetAt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetOffsetAt(int arg0)
        {
            return IExecuteWithSignature<int>("getOffsetAt", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textservice/SentenceSuggestionsInfo.html#writeToParcel(android.os.Parcel,int)"/>
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