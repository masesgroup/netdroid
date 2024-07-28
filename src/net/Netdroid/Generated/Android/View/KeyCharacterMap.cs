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

namespace Android.View
{
    #region KeyCharacterMap
    public partial class KeyCharacterMap
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/KeyCharacterMap.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/KeyCharacterMap.html#HEX_INPUT"/>
        /// </summary>
        public static char HEX_INPUT { get { if (!_HEX_INPUTReady) { _HEX_INPUTContent = SGetField<char>(LocalBridgeClazz, "HEX_INPUT"); _HEX_INPUTReady = true; } return _HEX_INPUTContent; } }
        private static char _HEX_INPUTContent = default;
        private static bool _HEX_INPUTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/KeyCharacterMap.html#PICKER_DIALOG_INPUT"/>
        /// </summary>
        public static char PICKER_DIALOG_INPUT { get { if (!_PICKER_DIALOG_INPUTReady) { _PICKER_DIALOG_INPUTContent = SGetField<char>(LocalBridgeClazz, "PICKER_DIALOG_INPUT"); _PICKER_DIALOG_INPUTReady = true; } return _PICKER_DIALOG_INPUTContent; } }
        private static char _PICKER_DIALOG_INPUTContent = default;
        private static bool _PICKER_DIALOG_INPUTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/KeyCharacterMap.html#ALPHA"/>
        /// </summary>
        public static int ALPHA { get { if (!_ALPHAReady) { _ALPHAContent = SGetField<int>(LocalBridgeClazz, "ALPHA"); _ALPHAReady = true; } return _ALPHAContent; } }
        private static int _ALPHAContent = default;
        private static bool _ALPHAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/KeyCharacterMap.html#BUILT_IN_KEYBOARD"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int BUILT_IN_KEYBOARD { get { if (!_BUILT_IN_KEYBOARDReady) { _BUILT_IN_KEYBOARDContent = SGetField<int>(LocalBridgeClazz, "BUILT_IN_KEYBOARD"); _BUILT_IN_KEYBOARDReady = true; } return _BUILT_IN_KEYBOARDContent; } }
        private static int _BUILT_IN_KEYBOARDContent = default;
        private static bool _BUILT_IN_KEYBOARDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/KeyCharacterMap.html#COMBINING_ACCENT"/>
        /// </summary>
        public static int COMBINING_ACCENT { get { if (!_COMBINING_ACCENTReady) { _COMBINING_ACCENTContent = SGetField<int>(LocalBridgeClazz, "COMBINING_ACCENT"); _COMBINING_ACCENTReady = true; } return _COMBINING_ACCENTContent; } }
        private static int _COMBINING_ACCENTContent = default;
        private static bool _COMBINING_ACCENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/KeyCharacterMap.html#COMBINING_ACCENT_MASK"/>
        /// </summary>
        public static int COMBINING_ACCENT_MASK { get { if (!_COMBINING_ACCENT_MASKReady) { _COMBINING_ACCENT_MASKContent = SGetField<int>(LocalBridgeClazz, "COMBINING_ACCENT_MASK"); _COMBINING_ACCENT_MASKReady = true; } return _COMBINING_ACCENT_MASKContent; } }
        private static int _COMBINING_ACCENT_MASKContent = default;
        private static bool _COMBINING_ACCENT_MASKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/KeyCharacterMap.html#FULL"/>
        /// </summary>
        public static int FULL { get { if (!_FULLReady) { _FULLContent = SGetField<int>(LocalBridgeClazz, "FULL"); _FULLReady = true; } return _FULLContent; } }
        private static int _FULLContent = default;
        private static bool _FULLReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/KeyCharacterMap.html#MODIFIER_BEHAVIOR_CHORDED"/>
        /// </summary>
        public static int MODIFIER_BEHAVIOR_CHORDED { get { if (!_MODIFIER_BEHAVIOR_CHORDEDReady) { _MODIFIER_BEHAVIOR_CHORDEDContent = SGetField<int>(LocalBridgeClazz, "MODIFIER_BEHAVIOR_CHORDED"); _MODIFIER_BEHAVIOR_CHORDEDReady = true; } return _MODIFIER_BEHAVIOR_CHORDEDContent; } }
        private static int _MODIFIER_BEHAVIOR_CHORDEDContent = default;
        private static bool _MODIFIER_BEHAVIOR_CHORDEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/KeyCharacterMap.html#MODIFIER_BEHAVIOR_CHORDED_OR_TOGGLED"/>
        /// </summary>
        public static int MODIFIER_BEHAVIOR_CHORDED_OR_TOGGLED { get { if (!_MODIFIER_BEHAVIOR_CHORDED_OR_TOGGLEDReady) { _MODIFIER_BEHAVIOR_CHORDED_OR_TOGGLEDContent = SGetField<int>(LocalBridgeClazz, "MODIFIER_BEHAVIOR_CHORDED_OR_TOGGLED"); _MODIFIER_BEHAVIOR_CHORDED_OR_TOGGLEDReady = true; } return _MODIFIER_BEHAVIOR_CHORDED_OR_TOGGLEDContent; } }
        private static int _MODIFIER_BEHAVIOR_CHORDED_OR_TOGGLEDContent = default;
        private static bool _MODIFIER_BEHAVIOR_CHORDED_OR_TOGGLEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/KeyCharacterMap.html#NUMERIC"/>
        /// </summary>
        public static int NUMERIC { get { if (!_NUMERICReady) { _NUMERICContent = SGetField<int>(LocalBridgeClazz, "NUMERIC"); _NUMERICReady = true; } return _NUMERICContent; } }
        private static int _NUMERICContent = default;
        private static bool _NUMERICReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/KeyCharacterMap.html#PREDICTIVE"/>
        /// </summary>
        public static int PREDICTIVE { get { if (!_PREDICTIVEReady) { _PREDICTIVEContent = SGetField<int>(LocalBridgeClazz, "PREDICTIVE"); _PREDICTIVEReady = true; } return _PREDICTIVEContent; } }
        private static int _PREDICTIVEContent = default;
        private static bool _PREDICTIVEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/KeyCharacterMap.html#SPECIAL_FUNCTION"/>
        /// </summary>
        public static int SPECIAL_FUNCTION { get { if (!_SPECIAL_FUNCTIONReady) { _SPECIAL_FUNCTIONContent = SGetField<int>(LocalBridgeClazz, "SPECIAL_FUNCTION"); _SPECIAL_FUNCTIONReady = true; } return _SPECIAL_FUNCTIONContent; } }
        private static int _SPECIAL_FUNCTIONContent = default;
        private static bool _SPECIAL_FUNCTIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/KeyCharacterMap.html#VIRTUAL_KEYBOARD"/>
        /// </summary>
        public static int VIRTUAL_KEYBOARD { get { if (!_VIRTUAL_KEYBOARDReady) { _VIRTUAL_KEYBOARDContent = SGetField<int>(LocalBridgeClazz, "VIRTUAL_KEYBOARD"); _VIRTUAL_KEYBOARDReady = true; } return _VIRTUAL_KEYBOARDContent; } }
        private static int _VIRTUAL_KEYBOARDContent = default;
        private static bool _VIRTUAL_KEYBOARDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/KeyCharacterMap.html#load(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.View.KeyCharacterMap"/></returns>
        public static Android.View.KeyCharacterMap Load(int arg0)
        {
            return SExecuteWithSignature<Android.View.KeyCharacterMap>(LocalBridgeClazz, "load", "(I)Landroid/view/KeyCharacterMap;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/KeyCharacterMap.html#deviceHasKey(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool DeviceHasKey(int arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "deviceHasKey", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/KeyCharacterMap.html#deviceHasKeys(int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool[] DeviceHasKeys(int[] arg0)
        {
            return SExecuteWithSignatureArray<bool>(LocalBridgeClazz, "deviceHasKeys", "([I)[Z", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/KeyCharacterMap.html#getDeadChar(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int GetDeadChar(int arg0, int arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "getDeadChar", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/KeyCharacterMap.html#getEvents(char[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <returns><see cref="Android.View.KeyEvent"/></returns>
        public Android.View.KeyEvent[] GetEvents(char[] arg0)
        {
            return IExecuteWithSignatureArray<Android.View.KeyEvent>("getEvents", "([C)[Landroid/view/KeyEvent;", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/KeyCharacterMap.html#getKeyData(int,android.view.KeyCharacterMap.KeyData)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.View.KeyCharacterMap.KeyData"/></param>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool GetKeyData(int arg0, Android.View.KeyCharacterMap.KeyData arg1)
        {
            return IExecute<bool>("getKeyData", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/KeyCharacterMap.html#isPrintingKey(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsPrintingKey(int arg0)
        {
            return IExecuteWithSignature<bool>("isPrintingKey", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/KeyCharacterMap.html#getDisplayLabel(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="char"/></returns>
        public char GetDisplayLabel(int arg0)
        {
            return IExecuteWithSignature<char>("getDisplayLabel", "(I)C", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/KeyCharacterMap.html#getMatch(int,char[],int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="char"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="char"/></returns>
        public char GetMatch(int arg0, char[] arg1, int arg2)
        {
            return IExecute<char>("getMatch", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/KeyCharacterMap.html#getMatch(int,char[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="char"/></param>
        /// <returns><see cref="char"/></returns>
        public char GetMatch(int arg0, char[] arg1)
        {
            return IExecute<char>("getMatch", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/KeyCharacterMap.html#getNumber(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="char"/></returns>
        public char GetNumber(int arg0)
        {
            return IExecuteWithSignature<char>("getNumber", "(I)C", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/KeyCharacterMap.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/KeyCharacterMap.html#get(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int Get(int arg0, int arg1)
        {
            return IExecute<int>("get", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/KeyCharacterMap.html#getKeyboardType()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetKeyboardType()
        {
            return IExecuteWithSignature<int>("getKeyboardType", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/KeyCharacterMap.html#getModifierBehavior()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetModifierBehavior()
        {
            return IExecuteWithSignature<int>("getModifierBehavior", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/KeyCharacterMap.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecute("writeToParcel", arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region KeyData
        public partial class KeyData
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/KeyCharacterMap.KeyData.html#displayLabel"/>
            /// </summary>
            [global::System.Obsolete()]
            public char displayLabel { get { return IGetField<char>("displayLabel"); } set { ISetField("displayLabel", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/KeyCharacterMap.KeyData.html#number"/>
            /// </summary>
            [global::System.Obsolete()]
            public char number { get { return IGetField<char>("number"); } set { ISetField("number", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/KeyCharacterMap.KeyData.html#meta"/>
            /// </summary>
            [global::System.Obsolete()]
            public char[] meta { get { return IGetFieldArray<char>("meta"); } set { ISetField("meta", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/KeyCharacterMap.KeyData.html#META_LENGTH"/>
            /// </summary>
            [global::System.Obsolete()]
            public static int META_LENGTH { get { if (!_META_LENGTHReady) { _META_LENGTHContent = SGetField<int>(LocalBridgeClazz, "META_LENGTH"); _META_LENGTHReady = true; } return _META_LENGTHContent; } }
            private static int _META_LENGTHContent = default;
            private static bool _META_LENGTHReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region UnavailableException
        public partial class UnavailableException
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields

            #endregion

            #region Static methods

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