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

namespace Android.Os
{
    #region VibrationAttributes
    public partial class VibrationAttributes
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/VibrationAttributes.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/VibrationAttributes.html#FLAG_BYPASS_INTERRUPTION_POLICY"/>
        /// </summary>
        public static int FLAG_BYPASS_INTERRUPTION_POLICY { get { if (!_FLAG_BYPASS_INTERRUPTION_POLICYReady) { _FLAG_BYPASS_INTERRUPTION_POLICYContent = SGetField<int>(LocalBridgeClazz, "FLAG_BYPASS_INTERRUPTION_POLICY"); _FLAG_BYPASS_INTERRUPTION_POLICYReady = true; } return _FLAG_BYPASS_INTERRUPTION_POLICYContent; } }
        private static int _FLAG_BYPASS_INTERRUPTION_POLICYContent = default;
        private static bool _FLAG_BYPASS_INTERRUPTION_POLICYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/VibrationAttributes.html#USAGE_ACCESSIBILITY"/>
        /// </summary>
        public static int USAGE_ACCESSIBILITY { get { if (!_USAGE_ACCESSIBILITYReady) { _USAGE_ACCESSIBILITYContent = SGetField<int>(LocalBridgeClazz, "USAGE_ACCESSIBILITY"); _USAGE_ACCESSIBILITYReady = true; } return _USAGE_ACCESSIBILITYContent; } }
        private static int _USAGE_ACCESSIBILITYContent = default;
        private static bool _USAGE_ACCESSIBILITYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/VibrationAttributes.html#USAGE_ALARM"/>
        /// </summary>
        public static int USAGE_ALARM { get { if (!_USAGE_ALARMReady) { _USAGE_ALARMContent = SGetField<int>(LocalBridgeClazz, "USAGE_ALARM"); _USAGE_ALARMReady = true; } return _USAGE_ALARMContent; } }
        private static int _USAGE_ALARMContent = default;
        private static bool _USAGE_ALARMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/VibrationAttributes.html#USAGE_CLASS_ALARM"/>
        /// </summary>
        public static int USAGE_CLASS_ALARM { get { if (!_USAGE_CLASS_ALARMReady) { _USAGE_CLASS_ALARMContent = SGetField<int>(LocalBridgeClazz, "USAGE_CLASS_ALARM"); _USAGE_CLASS_ALARMReady = true; } return _USAGE_CLASS_ALARMContent; } }
        private static int _USAGE_CLASS_ALARMContent = default;
        private static bool _USAGE_CLASS_ALARMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/VibrationAttributes.html#USAGE_CLASS_FEEDBACK"/>
        /// </summary>
        public static int USAGE_CLASS_FEEDBACK { get { if (!_USAGE_CLASS_FEEDBACKReady) { _USAGE_CLASS_FEEDBACKContent = SGetField<int>(LocalBridgeClazz, "USAGE_CLASS_FEEDBACK"); _USAGE_CLASS_FEEDBACKReady = true; } return _USAGE_CLASS_FEEDBACKContent; } }
        private static int _USAGE_CLASS_FEEDBACKContent = default;
        private static bool _USAGE_CLASS_FEEDBACKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/VibrationAttributes.html#USAGE_CLASS_MASK"/>
        /// </summary>
        public static int USAGE_CLASS_MASK { get { if (!_USAGE_CLASS_MASKReady) { _USAGE_CLASS_MASKContent = SGetField<int>(LocalBridgeClazz, "USAGE_CLASS_MASK"); _USAGE_CLASS_MASKReady = true; } return _USAGE_CLASS_MASKContent; } }
        private static int _USAGE_CLASS_MASKContent = default;
        private static bool _USAGE_CLASS_MASKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/VibrationAttributes.html#USAGE_CLASS_MEDIA"/>
        /// </summary>
        public static int USAGE_CLASS_MEDIA { get { if (!_USAGE_CLASS_MEDIAReady) { _USAGE_CLASS_MEDIAContent = SGetField<int>(LocalBridgeClazz, "USAGE_CLASS_MEDIA"); _USAGE_CLASS_MEDIAReady = true; } return _USAGE_CLASS_MEDIAContent; } }
        private static int _USAGE_CLASS_MEDIAContent = default;
        private static bool _USAGE_CLASS_MEDIAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/VibrationAttributes.html#USAGE_CLASS_UNKNOWN"/>
        /// </summary>
        public static int USAGE_CLASS_UNKNOWN { get { if (!_USAGE_CLASS_UNKNOWNReady) { _USAGE_CLASS_UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "USAGE_CLASS_UNKNOWN"); _USAGE_CLASS_UNKNOWNReady = true; } return _USAGE_CLASS_UNKNOWNContent; } }
        private static int _USAGE_CLASS_UNKNOWNContent = default;
        private static bool _USAGE_CLASS_UNKNOWNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/VibrationAttributes.html#USAGE_COMMUNICATION_REQUEST"/>
        /// </summary>
        public static int USAGE_COMMUNICATION_REQUEST { get { if (!_USAGE_COMMUNICATION_REQUESTReady) { _USAGE_COMMUNICATION_REQUESTContent = SGetField<int>(LocalBridgeClazz, "USAGE_COMMUNICATION_REQUEST"); _USAGE_COMMUNICATION_REQUESTReady = true; } return _USAGE_COMMUNICATION_REQUESTContent; } }
        private static int _USAGE_COMMUNICATION_REQUESTContent = default;
        private static bool _USAGE_COMMUNICATION_REQUESTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/VibrationAttributes.html#USAGE_HARDWARE_FEEDBACK"/>
        /// </summary>
        public static int USAGE_HARDWARE_FEEDBACK { get { if (!_USAGE_HARDWARE_FEEDBACKReady) { _USAGE_HARDWARE_FEEDBACKContent = SGetField<int>(LocalBridgeClazz, "USAGE_HARDWARE_FEEDBACK"); _USAGE_HARDWARE_FEEDBACKReady = true; } return _USAGE_HARDWARE_FEEDBACKContent; } }
        private static int _USAGE_HARDWARE_FEEDBACKContent = default;
        private static bool _USAGE_HARDWARE_FEEDBACKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/VibrationAttributes.html#USAGE_MEDIA"/>
        /// </summary>
        public static int USAGE_MEDIA { get { if (!_USAGE_MEDIAReady) { _USAGE_MEDIAContent = SGetField<int>(LocalBridgeClazz, "USAGE_MEDIA"); _USAGE_MEDIAReady = true; } return _USAGE_MEDIAContent; } }
        private static int _USAGE_MEDIAContent = default;
        private static bool _USAGE_MEDIAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/VibrationAttributes.html#USAGE_NOTIFICATION"/>
        /// </summary>
        public static int USAGE_NOTIFICATION { get { if (!_USAGE_NOTIFICATIONReady) { _USAGE_NOTIFICATIONContent = SGetField<int>(LocalBridgeClazz, "USAGE_NOTIFICATION"); _USAGE_NOTIFICATIONReady = true; } return _USAGE_NOTIFICATIONContent; } }
        private static int _USAGE_NOTIFICATIONContent = default;
        private static bool _USAGE_NOTIFICATIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/VibrationAttributes.html#USAGE_PHYSICAL_EMULATION"/>
        /// </summary>
        public static int USAGE_PHYSICAL_EMULATION { get { if (!_USAGE_PHYSICAL_EMULATIONReady) { _USAGE_PHYSICAL_EMULATIONContent = SGetField<int>(LocalBridgeClazz, "USAGE_PHYSICAL_EMULATION"); _USAGE_PHYSICAL_EMULATIONReady = true; } return _USAGE_PHYSICAL_EMULATIONContent; } }
        private static int _USAGE_PHYSICAL_EMULATIONContent = default;
        private static bool _USAGE_PHYSICAL_EMULATIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/VibrationAttributes.html#USAGE_RINGTONE"/>
        /// </summary>
        public static int USAGE_RINGTONE { get { if (!_USAGE_RINGTONEReady) { _USAGE_RINGTONEContent = SGetField<int>(LocalBridgeClazz, "USAGE_RINGTONE"); _USAGE_RINGTONEReady = true; } return _USAGE_RINGTONEContent; } }
        private static int _USAGE_RINGTONEContent = default;
        private static bool _USAGE_RINGTONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/VibrationAttributes.html#USAGE_TOUCH"/>
        /// </summary>
        public static int USAGE_TOUCH { get { if (!_USAGE_TOUCHReady) { _USAGE_TOUCHContent = SGetField<int>(LocalBridgeClazz, "USAGE_TOUCH"); _USAGE_TOUCHReady = true; } return _USAGE_TOUCHContent; } }
        private static int _USAGE_TOUCHContent = default;
        private static bool _USAGE_TOUCHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/VibrationAttributes.html#USAGE_UNKNOWN"/>
        /// </summary>
        public static int USAGE_UNKNOWN { get { if (!_USAGE_UNKNOWNReady) { _USAGE_UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "USAGE_UNKNOWN"); _USAGE_UNKNOWNReady = true; } return _USAGE_UNKNOWNContent; } }
        private static int _USAGE_UNKNOWNContent = default;
        private static bool _USAGE_UNKNOWNReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/VibrationAttributes.html#createForUsage(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Os.VibrationAttributes"/></returns>
        public static Android.Os.VibrationAttributes CreateForUsage(int arg0)
        {
            return SExecuteWithSignature<Android.Os.VibrationAttributes>(LocalBridgeClazz, "createForUsage", "(I)Landroid/os/VibrationAttributes;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/VibrationAttributes.html#getFlags()"/> 
        /// </summary>
        public int Flags
        {
            get { return IExecuteWithSignature<int>("getFlags", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/VibrationAttributes.html#getUsage()"/> 
        /// </summary>
        public int Usage
        {
            get { return IExecuteWithSignature<int>("getUsage", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/VibrationAttributes.html#getUsageClass()"/> 
        /// </summary>
        public int UsageClass
        {
            get { return IExecuteWithSignature<int>("getUsageClass", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/VibrationAttributes.html#isFlagSet(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsFlagSet(int arg0)
        {
            return IExecuteWithSignature<bool>("isFlagSet", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/VibrationAttributes.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/VibrationAttributes.html#writeToParcel(android.os.Parcel,int)"/>
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
            /// <see href="https://developer.android.com/reference/android/os/VibrationAttributes.Builder.html#%3Cinit%3E(android.media.AudioAttributes)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Media.AudioAttributes"/></param>
            public Builder(Android.Media.AudioAttributes arg0)
                : base(arg0)
            {
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/VibrationAttributes.Builder.html#%3Cinit%3E(android.os.VibrationAttributes)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.VibrationAttributes"/></param>
            public Builder(Android.Os.VibrationAttributes arg0)
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
            /// <see href="https://developer.android.com/reference/android/os/VibrationAttributes.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Os.VibrationAttributes"/></returns>
            public Android.Os.VibrationAttributes Build()
            {
                return IExecuteWithSignature<Android.Os.VibrationAttributes>("build", "()Landroid/os/VibrationAttributes;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/VibrationAttributes.Builder.html#setFlags(int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <returns><see cref="Android.Os.VibrationAttributes.Builder"/></returns>
            public Android.Os.VibrationAttributes.Builder SetFlags(int arg0, int arg1)
            {
                return IExecute<Android.Os.VibrationAttributes.Builder>("setFlags", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/VibrationAttributes.Builder.html#setUsage(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Os.VibrationAttributes.Builder"/></returns>
            public Android.Os.VibrationAttributes.Builder SetUsage(int arg0)
            {
                return IExecuteWithSignature<Android.Os.VibrationAttributes.Builder>("setUsage", "(I)Landroid/os/VibrationAttributes$Builder;", arg0);
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