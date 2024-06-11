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
*  This file is generated by MASES.JNetReflector (ver. 2.5.2.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Print
{
    #region PrintJobInfo
    public partial class PrintJobInfo
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/print/PrintJobInfo.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/print/PrintJobInfo.html#STATE_BLOCKED"/>
        /// </summary>
        public static int STATE_BLOCKED { get { if (!_STATE_BLOCKEDReady) { _STATE_BLOCKEDContent = SGetField<int>(LocalBridgeClazz, "STATE_BLOCKED"); _STATE_BLOCKEDReady = true; } return _STATE_BLOCKEDContent; } }
        private static int _STATE_BLOCKEDContent = default;
        private static bool _STATE_BLOCKEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/print/PrintJobInfo.html#STATE_CANCELED"/>
        /// </summary>
        public static int STATE_CANCELED { get { if (!_STATE_CANCELEDReady) { _STATE_CANCELEDContent = SGetField<int>(LocalBridgeClazz, "STATE_CANCELED"); _STATE_CANCELEDReady = true; } return _STATE_CANCELEDContent; } }
        private static int _STATE_CANCELEDContent = default;
        private static bool _STATE_CANCELEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/print/PrintJobInfo.html#STATE_COMPLETED"/>
        /// </summary>
        public static int STATE_COMPLETED { get { if (!_STATE_COMPLETEDReady) { _STATE_COMPLETEDContent = SGetField<int>(LocalBridgeClazz, "STATE_COMPLETED"); _STATE_COMPLETEDReady = true; } return _STATE_COMPLETEDContent; } }
        private static int _STATE_COMPLETEDContent = default;
        private static bool _STATE_COMPLETEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/print/PrintJobInfo.html#STATE_CREATED"/>
        /// </summary>
        public static int STATE_CREATED { get { if (!_STATE_CREATEDReady) { _STATE_CREATEDContent = SGetField<int>(LocalBridgeClazz, "STATE_CREATED"); _STATE_CREATEDReady = true; } return _STATE_CREATEDContent; } }
        private static int _STATE_CREATEDContent = default;
        private static bool _STATE_CREATEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/print/PrintJobInfo.html#STATE_FAILED"/>
        /// </summary>
        public static int STATE_FAILED { get { if (!_STATE_FAILEDReady) { _STATE_FAILEDContent = SGetField<int>(LocalBridgeClazz, "STATE_FAILED"); _STATE_FAILEDReady = true; } return _STATE_FAILEDContent; } }
        private static int _STATE_FAILEDContent = default;
        private static bool _STATE_FAILEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/print/PrintJobInfo.html#STATE_QUEUED"/>
        /// </summary>
        public static int STATE_QUEUED { get { if (!_STATE_QUEUEDReady) { _STATE_QUEUEDContent = SGetField<int>(LocalBridgeClazz, "STATE_QUEUED"); _STATE_QUEUEDReady = true; } return _STATE_QUEUEDContent; } }
        private static int _STATE_QUEUEDContent = default;
        private static bool _STATE_QUEUEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/print/PrintJobInfo.html#STATE_STARTED"/>
        /// </summary>
        public static int STATE_STARTED { get { if (!_STATE_STARTEDReady) { _STATE_STARTEDContent = SGetField<int>(LocalBridgeClazz, "STATE_STARTED"); _STATE_STARTEDReady = true; } return _STATE_STARTEDContent; } }
        private static int _STATE_STARTEDContent = default;
        private static bool _STATE_STARTEDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/print/PrintJobInfo.html#getPages()"/>
        /// </summary>
        /// <returns><see cref="Android.Print.PageRange"/></returns>
        public Android.Print.PageRange[] GetPages()
        {
            return IExecuteWithSignatureArray<Android.Print.PageRange>("getPages", "()[Landroid/print/PageRange;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/print/PrintJobInfo.html#getAttributes()"/>
        /// </summary>
        /// <returns><see cref="Android.Print.PrintAttributes"/></returns>
        public Android.Print.PrintAttributes GetAttributes()
        {
            return IExecuteWithSignature<Android.Print.PrintAttributes>("getAttributes", "()Landroid/print/PrintAttributes;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/print/PrintJobInfo.html#getPrinterId()"/>
        /// </summary>
        /// <returns><see cref="Android.Print.PrinterId"/></returns>
        public Android.Print.PrinterId GetPrinterId()
        {
            return IExecuteWithSignature<Android.Print.PrinterId>("getPrinterId", "()Landroid/print/PrinterId;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/print/PrintJobInfo.html#getId()"/>
        /// </summary>
        /// <returns><see cref="Android.Print.PrintJobId"/></returns>
        public Android.Print.PrintJobId GetId()
        {
            return IExecuteWithSignature<Android.Print.PrintJobId>("getId", "()Landroid/print/PrintJobId;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/print/PrintJobInfo.html#hasAdvancedOption(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool HasAdvancedOption(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<bool>("hasAdvancedOption", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/print/PrintJobInfo.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/print/PrintJobInfo.html#getAdvancedIntOption(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetAdvancedIntOption(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<int>("getAdvancedIntOption", "(Ljava/lang/String;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/print/PrintJobInfo.html#getCopies()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetCopies()
        {
            return IExecuteWithSignature<int>("getCopies", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/print/PrintJobInfo.html#getState()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetState()
        {
            return IExecuteWithSignature<int>("getState", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/print/PrintJobInfo.html#getAdvancedStringOption(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetAdvancedStringOption(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getAdvancedStringOption", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/print/PrintJobInfo.html#getLabel()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetLabel()
        {
            return IExecuteWithSignature<Java.Lang.String>("getLabel", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/print/PrintJobInfo.html#getCreationTime()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetCreationTime()
        {
            return IExecuteWithSignature<long>("getCreationTime", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/print/PrintJobInfo.html#writeToParcel(android.os.Parcel,int)"/>
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
            /// <see href="https://developer.android.com/reference/android/print/PrintJobInfo.Builder.html#%3Cinit%3E(android.print.PrintJobInfo)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Print.PrintJobInfo"/></param>
            public Builder(Android.Print.PrintJobInfo arg0)
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
            /// <see href="https://developer.android.com/reference/android/print/PrintJobInfo.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Print.PrintJobInfo"/></returns>
            public Android.Print.PrintJobInfo Build()
            {
                return IExecuteWithSignature<Android.Print.PrintJobInfo>("build", "()Landroid/print/PrintJobInfo;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/print/PrintJobInfo.Builder.html#putAdvancedOption(java.lang.String,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            public void PutAdvancedOption(Java.Lang.String arg0, int arg1)
            {
                IExecute("putAdvancedOption", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/print/PrintJobInfo.Builder.html#putAdvancedOption(java.lang.String,java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Java.Lang.String"/></param>
            public void PutAdvancedOption(Java.Lang.String arg0, Java.Lang.String arg1)
            {
                IExecute("putAdvancedOption", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/print/PrintJobInfo.Builder.html#setAttributes(android.print.PrintAttributes)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Print.PrintAttributes"/></param>
            public void SetAttributes(Android.Print.PrintAttributes arg0)
            {
                IExecuteWithSignature("setAttributes", "(Landroid/print/PrintAttributes;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/print/PrintJobInfo.Builder.html#setCopies(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public void SetCopies(int arg0)
            {
                IExecuteWithSignature("setCopies", "(I)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/print/PrintJobInfo.Builder.html#setPages(android.print.PageRange[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Print.PageRange"/></param>
            public void SetPages(Android.Print.PageRange[] arg0)
            {
                IExecuteWithSignature("setPages", "([Landroid/print/PageRange;)V", new object[] { arg0 });
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