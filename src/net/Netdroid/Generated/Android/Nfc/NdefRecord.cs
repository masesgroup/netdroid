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

namespace Android.Nfc
{
    #region NdefRecord
    public partial class NdefRecord
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NdefRecord.html#%3Cinit%3E(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <exception cref="Android.Nfc.FormatException"/>
        [global::System.Obsolete()]
        public NdefRecord(byte[] arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NdefRecord.html#%3Cinit%3E(short,byte[],byte[],byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <param name="arg2"><see cref="byte"/></param>
        /// <param name="arg3"><see cref="byte"/></param>
        public NdefRecord(short arg0, byte[] arg1, byte[] arg2, byte[] arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NdefRecord.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NdefRecord.html#RTD_ALTERNATIVE_CARRIER"/>
        /// </summary>
        public static byte[] RTD_ALTERNATIVE_CARRIER { get { if (!_RTD_ALTERNATIVE_CARRIERReady) { _RTD_ALTERNATIVE_CARRIERContent = SGetFieldArray<byte>(LocalBridgeClazz, "RTD_ALTERNATIVE_CARRIER"); _RTD_ALTERNATIVE_CARRIERReady = true; } return _RTD_ALTERNATIVE_CARRIERContent; } }
        private static byte[] _RTD_ALTERNATIVE_CARRIERContent = default;
        private static bool _RTD_ALTERNATIVE_CARRIERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NdefRecord.html#RTD_HANDOVER_CARRIER"/>
        /// </summary>
        public static byte[] RTD_HANDOVER_CARRIER { get { if (!_RTD_HANDOVER_CARRIERReady) { _RTD_HANDOVER_CARRIERContent = SGetFieldArray<byte>(LocalBridgeClazz, "RTD_HANDOVER_CARRIER"); _RTD_HANDOVER_CARRIERReady = true; } return _RTD_HANDOVER_CARRIERContent; } }
        private static byte[] _RTD_HANDOVER_CARRIERContent = default;
        private static bool _RTD_HANDOVER_CARRIERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NdefRecord.html#RTD_HANDOVER_REQUEST"/>
        /// </summary>
        public static byte[] RTD_HANDOVER_REQUEST { get { if (!_RTD_HANDOVER_REQUESTReady) { _RTD_HANDOVER_REQUESTContent = SGetFieldArray<byte>(LocalBridgeClazz, "RTD_HANDOVER_REQUEST"); _RTD_HANDOVER_REQUESTReady = true; } return _RTD_HANDOVER_REQUESTContent; } }
        private static byte[] _RTD_HANDOVER_REQUESTContent = default;
        private static bool _RTD_HANDOVER_REQUESTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NdefRecord.html#RTD_HANDOVER_SELECT"/>
        /// </summary>
        public static byte[] RTD_HANDOVER_SELECT { get { if (!_RTD_HANDOVER_SELECTReady) { _RTD_HANDOVER_SELECTContent = SGetFieldArray<byte>(LocalBridgeClazz, "RTD_HANDOVER_SELECT"); _RTD_HANDOVER_SELECTReady = true; } return _RTD_HANDOVER_SELECTContent; } }
        private static byte[] _RTD_HANDOVER_SELECTContent = default;
        private static bool _RTD_HANDOVER_SELECTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NdefRecord.html#RTD_SMART_POSTER"/>
        /// </summary>
        public static byte[] RTD_SMART_POSTER { get { if (!_RTD_SMART_POSTERReady) { _RTD_SMART_POSTERContent = SGetFieldArray<byte>(LocalBridgeClazz, "RTD_SMART_POSTER"); _RTD_SMART_POSTERReady = true; } return _RTD_SMART_POSTERContent; } }
        private static byte[] _RTD_SMART_POSTERContent = default;
        private static bool _RTD_SMART_POSTERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NdefRecord.html#RTD_TEXT"/>
        /// </summary>
        public static byte[] RTD_TEXT { get { if (!_RTD_TEXTReady) { _RTD_TEXTContent = SGetFieldArray<byte>(LocalBridgeClazz, "RTD_TEXT"); _RTD_TEXTReady = true; } return _RTD_TEXTContent; } }
        private static byte[] _RTD_TEXTContent = default;
        private static bool _RTD_TEXTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NdefRecord.html#RTD_URI"/>
        /// </summary>
        public static byte[] RTD_URI { get { if (!_RTD_URIReady) { _RTD_URIContent = SGetFieldArray<byte>(LocalBridgeClazz, "RTD_URI"); _RTD_URIReady = true; } return _RTD_URIContent; } }
        private static byte[] _RTD_URIContent = default;
        private static bool _RTD_URIReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NdefRecord.html#TNF_ABSOLUTE_URI"/>
        /// </summary>
        public static short TNF_ABSOLUTE_URI { get { if (!_TNF_ABSOLUTE_URIReady) { _TNF_ABSOLUTE_URIContent = SGetField<short>(LocalBridgeClazz, "TNF_ABSOLUTE_URI"); _TNF_ABSOLUTE_URIReady = true; } return _TNF_ABSOLUTE_URIContent; } }
        private static short _TNF_ABSOLUTE_URIContent = default;
        private static bool _TNF_ABSOLUTE_URIReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NdefRecord.html#TNF_EMPTY"/>
        /// </summary>
        public static short TNF_EMPTY { get { if (!_TNF_EMPTYReady) { _TNF_EMPTYContent = SGetField<short>(LocalBridgeClazz, "TNF_EMPTY"); _TNF_EMPTYReady = true; } return _TNF_EMPTYContent; } }
        private static short _TNF_EMPTYContent = default;
        private static bool _TNF_EMPTYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NdefRecord.html#TNF_EXTERNAL_TYPE"/>
        /// </summary>
        public static short TNF_EXTERNAL_TYPE { get { if (!_TNF_EXTERNAL_TYPEReady) { _TNF_EXTERNAL_TYPEContent = SGetField<short>(LocalBridgeClazz, "TNF_EXTERNAL_TYPE"); _TNF_EXTERNAL_TYPEReady = true; } return _TNF_EXTERNAL_TYPEContent; } }
        private static short _TNF_EXTERNAL_TYPEContent = default;
        private static bool _TNF_EXTERNAL_TYPEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NdefRecord.html#TNF_MIME_MEDIA"/>
        /// </summary>
        public static short TNF_MIME_MEDIA { get { if (!_TNF_MIME_MEDIAReady) { _TNF_MIME_MEDIAContent = SGetField<short>(LocalBridgeClazz, "TNF_MIME_MEDIA"); _TNF_MIME_MEDIAReady = true; } return _TNF_MIME_MEDIAContent; } }
        private static short _TNF_MIME_MEDIAContent = default;
        private static bool _TNF_MIME_MEDIAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NdefRecord.html#TNF_UNCHANGED"/>
        /// </summary>
        public static short TNF_UNCHANGED { get { if (!_TNF_UNCHANGEDReady) { _TNF_UNCHANGEDContent = SGetField<short>(LocalBridgeClazz, "TNF_UNCHANGED"); _TNF_UNCHANGEDReady = true; } return _TNF_UNCHANGEDContent; } }
        private static short _TNF_UNCHANGEDContent = default;
        private static bool _TNF_UNCHANGEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NdefRecord.html#TNF_UNKNOWN"/>
        /// </summary>
        public static short TNF_UNKNOWN { get { if (!_TNF_UNKNOWNReady) { _TNF_UNKNOWNContent = SGetField<short>(LocalBridgeClazz, "TNF_UNKNOWN"); _TNF_UNKNOWNReady = true; } return _TNF_UNKNOWNContent; } }
        private static short _TNF_UNKNOWNContent = default;
        private static bool _TNF_UNKNOWNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NdefRecord.html#TNF_WELL_KNOWN"/>
        /// </summary>
        public static short TNF_WELL_KNOWN { get { if (!_TNF_WELL_KNOWNReady) { _TNF_WELL_KNOWNContent = SGetField<short>(LocalBridgeClazz, "TNF_WELL_KNOWN"); _TNF_WELL_KNOWNReady = true; } return _TNF_WELL_KNOWNContent; } }
        private static short _TNF_WELL_KNOWNContent = default;
        private static bool _TNF_WELL_KNOWNReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NdefRecord.html#createApplicationRecord(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Nfc.NdefRecord"/></returns>
        public static Android.Nfc.NdefRecord CreateApplicationRecord(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Android.Nfc.NdefRecord>(LocalBridgeClazz, "createApplicationRecord", "(Ljava/lang/String;)Landroid/nfc/NdefRecord;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NdefRecord.html#createExternal(java.lang.String,java.lang.String,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="byte"/></param>
        /// <returns><see cref="Android.Nfc.NdefRecord"/></returns>
        public static Android.Nfc.NdefRecord CreateExternal(Java.Lang.String arg0, Java.Lang.String arg1, byte[] arg2)
        {
            return SExecute<Android.Nfc.NdefRecord>(LocalBridgeClazz, "createExternal", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NdefRecord.html#createMime(java.lang.String,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <returns><see cref="Android.Nfc.NdefRecord"/></returns>
        public static Android.Nfc.NdefRecord CreateMime(Java.Lang.String arg0, byte[] arg1)
        {
            return SExecute<Android.Nfc.NdefRecord>(LocalBridgeClazz, "createMime", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NdefRecord.html#createTextRecord(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Nfc.NdefRecord"/></returns>
        public static Android.Nfc.NdefRecord CreateTextRecord(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return SExecute<Android.Nfc.NdefRecord>(LocalBridgeClazz, "createTextRecord", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NdefRecord.html#createUri(android.net.Uri)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
        /// <returns><see cref="Android.Nfc.NdefRecord"/></returns>
        public static Android.Nfc.NdefRecord CreateUri(Android.Net.Uri arg0)
        {
            return SExecuteWithSignature<Android.Nfc.NdefRecord>(LocalBridgeClazz, "createUri", "(Landroid/net/Uri;)Landroid/nfc/NdefRecord;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NdefRecord.html#createUri(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Nfc.NdefRecord"/></returns>
        public static Android.Nfc.NdefRecord CreateUri(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Android.Nfc.NdefRecord>(LocalBridgeClazz, "createUri", "(Ljava/lang/String;)Landroid/nfc/NdefRecord;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NdefRecord.html#toUri()"/>
        /// </summary>
        /// <returns><see cref="Android.Net.Uri"/></returns>
        public Android.Net.Uri ToUri()
        {
            return IExecuteWithSignature<Android.Net.Uri>("toUri", "()Landroid/net/Uri;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NdefRecord.html#getId()"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        public byte[] GetId()
        {
            return IExecuteWithSignatureArray<byte>("getId", "()[B");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NdefRecord.html#getPayload()"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        public byte[] GetPayload()
        {
            return IExecuteWithSignatureArray<byte>("getPayload", "()[B");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NdefRecord.html#getType()"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        public byte[] GetType()
        {
            return IExecuteWithSignatureArray<byte>("getType", "()[B");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NdefRecord.html#toByteArray()"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        [global::System.Obsolete()]
        public byte[] ToByteArray()
        {
            return IExecuteWithSignatureArray<byte>("toByteArray", "()[B");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NdefRecord.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NdefRecord.html#toMimeType()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String ToMimeType()
        {
            return IExecuteWithSignature<Java.Lang.String>("toMimeType", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NdefRecord.html#getTnf()"/>
        /// </summary>
        /// <returns><see cref="short"/></returns>
        public short GetTnf()
        {
            return IExecuteWithSignature<short>("getTnf", "()S");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NdefRecord.html#writeToParcel(android.os.Parcel,int)"/>
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