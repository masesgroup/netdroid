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

namespace Android.Content
{
    #region RestrictionEntry
    public partial class RestrictionEntry
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/RestrictionEntry.html#%3Cinit%3E(android.os.Parcel)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        public RestrictionEntry(Android.Os.Parcel arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/RestrictionEntry.html#%3Cinit%3E(int,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public RestrictionEntry(int arg0, Java.Lang.String arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/RestrictionEntry.html#%3Cinit%3E(java.lang.String,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public RestrictionEntry(Java.Lang.String arg0, bool arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/RestrictionEntry.html#%3Cinit%3E(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public RestrictionEntry(Java.Lang.String arg0, int arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/RestrictionEntry.html#%3Cinit%3E(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public RestrictionEntry(Java.Lang.String arg0, Java.Lang.String arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/RestrictionEntry.html#%3Cinit%3E(java.lang.String,java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public RestrictionEntry(Java.Lang.String arg0, Java.Lang.String[] arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/RestrictionEntry.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/RestrictionEntry.html#TYPE_BOOLEAN"/>
        /// </summary>
        public static int TYPE_BOOLEAN { get { if (!_TYPE_BOOLEANReady) { _TYPE_BOOLEANContent = SGetField<int>(LocalBridgeClazz, "TYPE_BOOLEAN"); _TYPE_BOOLEANReady = true; } return _TYPE_BOOLEANContent; } }
        private static int _TYPE_BOOLEANContent = default;
        private static bool _TYPE_BOOLEANReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/RestrictionEntry.html#TYPE_BUNDLE"/>
        /// </summary>
        public static int TYPE_BUNDLE { get { if (!_TYPE_BUNDLEReady) { _TYPE_BUNDLEContent = SGetField<int>(LocalBridgeClazz, "TYPE_BUNDLE"); _TYPE_BUNDLEReady = true; } return _TYPE_BUNDLEContent; } }
        private static int _TYPE_BUNDLEContent = default;
        private static bool _TYPE_BUNDLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/RestrictionEntry.html#TYPE_BUNDLE_ARRAY"/>
        /// </summary>
        public static int TYPE_BUNDLE_ARRAY { get { if (!_TYPE_BUNDLE_ARRAYReady) { _TYPE_BUNDLE_ARRAYContent = SGetField<int>(LocalBridgeClazz, "TYPE_BUNDLE_ARRAY"); _TYPE_BUNDLE_ARRAYReady = true; } return _TYPE_BUNDLE_ARRAYContent; } }
        private static int _TYPE_BUNDLE_ARRAYContent = default;
        private static bool _TYPE_BUNDLE_ARRAYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/RestrictionEntry.html#TYPE_CHOICE"/>
        /// </summary>
        public static int TYPE_CHOICE { get { if (!_TYPE_CHOICEReady) { _TYPE_CHOICEContent = SGetField<int>(LocalBridgeClazz, "TYPE_CHOICE"); _TYPE_CHOICEReady = true; } return _TYPE_CHOICEContent; } }
        private static int _TYPE_CHOICEContent = default;
        private static bool _TYPE_CHOICEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/RestrictionEntry.html#TYPE_INTEGER"/>
        /// </summary>
        public static int TYPE_INTEGER { get { if (!_TYPE_INTEGERReady) { _TYPE_INTEGERContent = SGetField<int>(LocalBridgeClazz, "TYPE_INTEGER"); _TYPE_INTEGERReady = true; } return _TYPE_INTEGERContent; } }
        private static int _TYPE_INTEGERContent = default;
        private static bool _TYPE_INTEGERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/RestrictionEntry.html#TYPE_MULTI_SELECT"/>
        /// </summary>
        public static int TYPE_MULTI_SELECT { get { if (!_TYPE_MULTI_SELECTReady) { _TYPE_MULTI_SELECTContent = SGetField<int>(LocalBridgeClazz, "TYPE_MULTI_SELECT"); _TYPE_MULTI_SELECTReady = true; } return _TYPE_MULTI_SELECTContent; } }
        private static int _TYPE_MULTI_SELECTContent = default;
        private static bool _TYPE_MULTI_SELECTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/RestrictionEntry.html#TYPE_NULL"/>
        /// </summary>
        public static int TYPE_NULL { get { if (!_TYPE_NULLReady) { _TYPE_NULLContent = SGetField<int>(LocalBridgeClazz, "TYPE_NULL"); _TYPE_NULLReady = true; } return _TYPE_NULLContent; } }
        private static int _TYPE_NULLContent = default;
        private static bool _TYPE_NULLReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/RestrictionEntry.html#TYPE_STRING"/>
        /// </summary>
        public static int TYPE_STRING { get { if (!_TYPE_STRINGReady) { _TYPE_STRINGContent = SGetField<int>(LocalBridgeClazz, "TYPE_STRING"); _TYPE_STRINGReady = true; } return _TYPE_STRINGContent; } }
        private static int _TYPE_STRINGContent = default;
        private static bool _TYPE_STRINGReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/RestrictionEntry.html#createBundleArrayEntry(java.lang.String,android.content.RestrictionEntry[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.Content.RestrictionEntry"/></param>
        /// <returns><see cref="Android.Content.RestrictionEntry"/></returns>
        public static Android.Content.RestrictionEntry CreateBundleArrayEntry(Java.Lang.String arg0, Android.Content.RestrictionEntry[] arg1)
        {
            return SExecute<Android.Content.RestrictionEntry>(LocalBridgeClazz, "createBundleArrayEntry", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/RestrictionEntry.html#createBundleEntry(java.lang.String,android.content.RestrictionEntry[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.Content.RestrictionEntry"/></param>
        /// <returns><see cref="Android.Content.RestrictionEntry"/></returns>
        public static Android.Content.RestrictionEntry CreateBundleEntry(Java.Lang.String arg0, Android.Content.RestrictionEntry[] arg1)
        {
            return SExecute<Android.Content.RestrictionEntry>(LocalBridgeClazz, "createBundleEntry", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/RestrictionEntry.html#getRestrictions()"/>
        /// </summary>
        /// <returns><see cref="Android.Content.RestrictionEntry"/></returns>
        public Android.Content.RestrictionEntry[] GetRestrictions()
        {
            return IExecuteWithSignatureArray<Android.Content.RestrictionEntry>("getRestrictions", "()[Landroid/content/RestrictionEntry;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/RestrictionEntry.html#getSelectedState()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool GetSelectedState()
        {
            return IExecuteWithSignature<bool>("getSelectedState", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/RestrictionEntry.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/RestrictionEntry.html#getIntValue()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetIntValue()
        {
            return IExecuteWithSignature<int>("getIntValue", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/RestrictionEntry.html#getType()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetType()
        {
            return IExecuteWithSignature<int>("getType", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/RestrictionEntry.html#getDescription()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetDescription()
        {
            return IExecuteWithSignature<Java.Lang.String>("getDescription", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/RestrictionEntry.html#getKey()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetKey()
        {
            return IExecuteWithSignature<Java.Lang.String>("getKey", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/RestrictionEntry.html#getSelectedString()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetSelectedString()
        {
            return IExecuteWithSignature<Java.Lang.String>("getSelectedString", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/RestrictionEntry.html#getTitle()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetTitle()
        {
            return IExecuteWithSignature<Java.Lang.String>("getTitle", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/RestrictionEntry.html#getAllSelectedStrings()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String[] GetAllSelectedStrings()
        {
            return IExecuteWithSignatureArray<Java.Lang.String>("getAllSelectedStrings", "()[Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/RestrictionEntry.html#getChoiceEntries()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String[] GetChoiceEntries()
        {
            return IExecuteWithSignatureArray<Java.Lang.String>("getChoiceEntries", "()[Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/RestrictionEntry.html#getChoiceValues()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String[] GetChoiceValues()
        {
            return IExecuteWithSignatureArray<Java.Lang.String>("getChoiceValues", "()[Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/RestrictionEntry.html#setAllSelectedStrings(java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetAllSelectedStrings(Java.Lang.String[] arg0)
        {
            IExecuteWithSignature("setAllSelectedStrings", "([Ljava/lang/String;)V", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/RestrictionEntry.html#setChoiceEntries(android.content.Context,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void SetChoiceEntries(Android.Content.Context arg0, int arg1)
        {
            IExecute("setChoiceEntries", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/RestrictionEntry.html#setChoiceEntries(java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetChoiceEntries(Java.Lang.String[] arg0)
        {
            IExecuteWithSignature("setChoiceEntries", "([Ljava/lang/String;)V", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/RestrictionEntry.html#setChoiceValues(android.content.Context,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void SetChoiceValues(Android.Content.Context arg0, int arg1)
        {
            IExecute("setChoiceValues", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/RestrictionEntry.html#setChoiceValues(java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetChoiceValues(Java.Lang.String[] arg0)
        {
            IExecuteWithSignature("setChoiceValues", "([Ljava/lang/String;)V", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/RestrictionEntry.html#setDescription(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetDescription(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setDescription", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/RestrictionEntry.html#setIntValue(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetIntValue(int arg0)
        {
            IExecuteWithSignature("setIntValue", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/RestrictionEntry.html#setRestrictions(android.content.RestrictionEntry[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.RestrictionEntry"/></param>
        public void SetRestrictions(Android.Content.RestrictionEntry[] arg0)
        {
            IExecuteWithSignature("setRestrictions", "([Landroid/content/RestrictionEntry;)V", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/RestrictionEntry.html#setSelectedState(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetSelectedState(bool arg0)
        {
            IExecuteWithSignature("setSelectedState", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/RestrictionEntry.html#setSelectedString(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetSelectedString(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setSelectedString", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/RestrictionEntry.html#setTitle(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetTitle(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setTitle", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/RestrictionEntry.html#setType(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetType(int arg0)
        {
            IExecuteWithSignature("setType", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/RestrictionEntry.html#writeToParcel(android.os.Parcel,int)"/>
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