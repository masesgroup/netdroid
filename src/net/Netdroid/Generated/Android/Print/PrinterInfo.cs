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

namespace Android.Print
{
    #region PrinterInfo
    public partial class PrinterInfo
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/print/PrinterInfo.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/print/PrinterInfo.html#STATUS_BUSY"/>
        /// </summary>
        public static int STATUS_BUSY { get { if (!_STATUS_BUSYReady) { _STATUS_BUSYContent = SGetField<int>(LocalBridgeClazz, "STATUS_BUSY"); _STATUS_BUSYReady = true; } return _STATUS_BUSYContent; } }
        private static int _STATUS_BUSYContent = default;
        private static bool _STATUS_BUSYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/print/PrinterInfo.html#STATUS_IDLE"/>
        /// </summary>
        public static int STATUS_IDLE { get { if (!_STATUS_IDLEReady) { _STATUS_IDLEContent = SGetField<int>(LocalBridgeClazz, "STATUS_IDLE"); _STATUS_IDLEReady = true; } return _STATUS_IDLEContent; } }
        private static int _STATUS_IDLEContent = default;
        private static bool _STATUS_IDLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/print/PrinterInfo.html#STATUS_UNAVAILABLE"/>
        /// </summary>
        public static int STATUS_UNAVAILABLE { get { if (!_STATUS_UNAVAILABLEReady) { _STATUS_UNAVAILABLEContent = SGetField<int>(LocalBridgeClazz, "STATUS_UNAVAILABLE"); _STATUS_UNAVAILABLEReady = true; } return _STATUS_UNAVAILABLEContent; } }
        private static int _STATUS_UNAVAILABLEContent = default;
        private static bool _STATUS_UNAVAILABLEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/print/PrinterInfo.html#getCapabilities()"/>
        /// </summary>
        /// <returns><see cref="Android.Print.PrinterCapabilitiesInfo"/></returns>
        public Android.Print.PrinterCapabilitiesInfo GetCapabilities()
        {
            return IExecuteWithSignature<Android.Print.PrinterCapabilitiesInfo>("getCapabilities", "()Landroid/print/PrinterCapabilitiesInfo;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/print/PrinterInfo.html#getId()"/>
        /// </summary>
        /// <returns><see cref="Android.Print.PrinterId"/></returns>
        public Android.Print.PrinterId GetId()
        {
            return IExecuteWithSignature<Android.Print.PrinterId>("getId", "()Landroid/print/PrinterId;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/print/PrinterInfo.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/print/PrinterInfo.html#getStatus()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetStatus()
        {
            return IExecuteWithSignature<int>("getStatus", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/print/PrinterInfo.html#getDescription()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetDescription()
        {
            return IExecuteWithSignature<Java.Lang.String>("getDescription", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/print/PrinterInfo.html#getName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/print/PrinterInfo.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecute("writeToParcel", arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region Builder
        public partial class Builder
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/print/PrinterInfo.Builder.html#%3Cinit%3E(android.print.PrinterId,java.lang.String,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Print.PrinterId"/></param>
            /// <param name="arg1"><see cref="Java.Lang.String"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            public Builder(Android.Print.PrinterId arg0, Java.Lang.String arg1, int arg2)
                : base(arg0, arg1, arg2)
            {
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/print/PrinterInfo.Builder.html#%3Cinit%3E(android.print.PrinterInfo)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Print.PrinterInfo"/></param>
            public Builder(Android.Print.PrinterInfo arg0)
                : base(arg0)
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
            /// <see href="https://developer.android.com/reference/android/print/PrinterInfo.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Print.PrinterInfo"/></returns>
            public Android.Print.PrinterInfo Build()
            {
                return IExecuteWithSignature<Android.Print.PrinterInfo>("build", "()Landroid/print/PrinterInfo;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/print/PrinterInfo.Builder.html#setCapabilities(android.print.PrinterCapabilitiesInfo)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Print.PrinterCapabilitiesInfo"/></param>
            /// <returns><see cref="Android.Print.PrinterInfo.Builder"/></returns>
            public Android.Print.PrinterInfo.Builder SetCapabilities(Android.Print.PrinterCapabilitiesInfo arg0)
            {
                return IExecuteWithSignature<Android.Print.PrinterInfo.Builder>("setCapabilities", "(Landroid/print/PrinterCapabilitiesInfo;)Landroid/print/PrinterInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/print/PrinterInfo.Builder.html#setDescription(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Print.PrinterInfo.Builder"/></returns>
            public Android.Print.PrinterInfo.Builder SetDescription(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.Print.PrinterInfo.Builder>("setDescription", "(Ljava/lang/String;)Landroid/print/PrinterInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/print/PrinterInfo.Builder.html#setHasCustomPrinterIcon(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Print.PrinterInfo.Builder"/></returns>
            public Android.Print.PrinterInfo.Builder SetHasCustomPrinterIcon(bool arg0)
            {
                return IExecuteWithSignature<Android.Print.PrinterInfo.Builder>("setHasCustomPrinterIcon", "(Z)Landroid/print/PrinterInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/print/PrinterInfo.Builder.html#setIconResourceId(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Print.PrinterInfo.Builder"/></returns>
            public Android.Print.PrinterInfo.Builder SetIconResourceId(int arg0)
            {
                return IExecuteWithSignature<Android.Print.PrinterInfo.Builder>("setIconResourceId", "(I)Landroid/print/PrinterInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/print/PrinterInfo.Builder.html#setInfoIntent(android.app.PendingIntent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.App.PendingIntent"/></param>
            /// <returns><see cref="Android.Print.PrinterInfo.Builder"/></returns>
            public Android.Print.PrinterInfo.Builder SetInfoIntent(Android.App.PendingIntent arg0)
            {
                return IExecuteWithSignature<Android.Print.PrinterInfo.Builder>("setInfoIntent", "(Landroid/app/PendingIntent;)Landroid/print/PrinterInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/print/PrinterInfo.Builder.html#setName(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Print.PrinterInfo.Builder"/></returns>
            public Android.Print.PrinterInfo.Builder SetName(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.Print.PrinterInfo.Builder>("setName", "(Ljava/lang/String;)Landroid/print/PrinterInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/print/PrinterInfo.Builder.html#setStatus(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Print.PrinterInfo.Builder"/></returns>
            public Android.Print.PrinterInfo.Builder SetStatus(int arg0)
            {
                return IExecuteWithSignature<Android.Print.PrinterInfo.Builder>("setStatus", "(I)Landroid/print/PrinterInfo$Builder;", arg0);
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