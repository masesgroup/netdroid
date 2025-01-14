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
*  This file is generated by MASES.JNetReflector (ver. 2.5.10.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Speech.Tts
{
    #region Voice declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/speech/tts/Voice.html"/>
    /// </summary>
    public partial class Voice : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.speech.tts.Voice";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Voice() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Voice(params object[] args) : base(args) { }
    
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
    
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;
    
        // TODO: complete the class
    
    }
    #endregion

    #region Voice implementation
    public partial class Voice
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/tts/Voice.html#%3Cinit%3E(java.lang.String,java.util.Locale,int,int,boolean,java.util.Set)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="bool"/></param>
        /// <param name="arg5"><see cref="Java.Util.Set"/></param>
        public Voice(Java.Lang.String arg0, Java.Util.Locale arg1, int arg2, int arg3, bool arg4, Java.Util.Set<Java.Lang.String> arg5)
            : base(arg0, arg1, arg2, arg3, arg4, arg5)
        {
        }
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/tts/Voice.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/tts/Voice.html#LATENCY_HIGH"/>
        /// </summary>
        public static int LATENCY_HIGH { get { if (!_LATENCY_HIGHReady) { _LATENCY_HIGHContent = SGetField<int>(LocalBridgeClazz, "LATENCY_HIGH"); _LATENCY_HIGHReady = true; } return _LATENCY_HIGHContent; } }
        private static int _LATENCY_HIGHContent = default;
        private static bool _LATENCY_HIGHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/tts/Voice.html#LATENCY_LOW"/>
        /// </summary>
        public static int LATENCY_LOW { get { if (!_LATENCY_LOWReady) { _LATENCY_LOWContent = SGetField<int>(LocalBridgeClazz, "LATENCY_LOW"); _LATENCY_LOWReady = true; } return _LATENCY_LOWContent; } }
        private static int _LATENCY_LOWContent = default;
        private static bool _LATENCY_LOWReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/tts/Voice.html#LATENCY_NORMAL"/>
        /// </summary>
        public static int LATENCY_NORMAL { get { if (!_LATENCY_NORMALReady) { _LATENCY_NORMALContent = SGetField<int>(LocalBridgeClazz, "LATENCY_NORMAL"); _LATENCY_NORMALReady = true; } return _LATENCY_NORMALContent; } }
        private static int _LATENCY_NORMALContent = default;
        private static bool _LATENCY_NORMALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/tts/Voice.html#LATENCY_VERY_HIGH"/>
        /// </summary>
        public static int LATENCY_VERY_HIGH { get { if (!_LATENCY_VERY_HIGHReady) { _LATENCY_VERY_HIGHContent = SGetField<int>(LocalBridgeClazz, "LATENCY_VERY_HIGH"); _LATENCY_VERY_HIGHReady = true; } return _LATENCY_VERY_HIGHContent; } }
        private static int _LATENCY_VERY_HIGHContent = default;
        private static bool _LATENCY_VERY_HIGHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/tts/Voice.html#LATENCY_VERY_LOW"/>
        /// </summary>
        public static int LATENCY_VERY_LOW { get { if (!_LATENCY_VERY_LOWReady) { _LATENCY_VERY_LOWContent = SGetField<int>(LocalBridgeClazz, "LATENCY_VERY_LOW"); _LATENCY_VERY_LOWReady = true; } return _LATENCY_VERY_LOWContent; } }
        private static int _LATENCY_VERY_LOWContent = default;
        private static bool _LATENCY_VERY_LOWReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/tts/Voice.html#QUALITY_HIGH"/>
        /// </summary>
        public static int QUALITY_HIGH { get { if (!_QUALITY_HIGHReady) { _QUALITY_HIGHContent = SGetField<int>(LocalBridgeClazz, "QUALITY_HIGH"); _QUALITY_HIGHReady = true; } return _QUALITY_HIGHContent; } }
        private static int _QUALITY_HIGHContent = default;
        private static bool _QUALITY_HIGHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/tts/Voice.html#QUALITY_LOW"/>
        /// </summary>
        public static int QUALITY_LOW { get { if (!_QUALITY_LOWReady) { _QUALITY_LOWContent = SGetField<int>(LocalBridgeClazz, "QUALITY_LOW"); _QUALITY_LOWReady = true; } return _QUALITY_LOWContent; } }
        private static int _QUALITY_LOWContent = default;
        private static bool _QUALITY_LOWReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/tts/Voice.html#QUALITY_NORMAL"/>
        /// </summary>
        public static int QUALITY_NORMAL { get { if (!_QUALITY_NORMALReady) { _QUALITY_NORMALContent = SGetField<int>(LocalBridgeClazz, "QUALITY_NORMAL"); _QUALITY_NORMALReady = true; } return _QUALITY_NORMALContent; } }
        private static int _QUALITY_NORMALContent = default;
        private static bool _QUALITY_NORMALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/tts/Voice.html#QUALITY_VERY_HIGH"/>
        /// </summary>
        public static int QUALITY_VERY_HIGH { get { if (!_QUALITY_VERY_HIGHReady) { _QUALITY_VERY_HIGHContent = SGetField<int>(LocalBridgeClazz, "QUALITY_VERY_HIGH"); _QUALITY_VERY_HIGHReady = true; } return _QUALITY_VERY_HIGHContent; } }
        private static int _QUALITY_VERY_HIGHContent = default;
        private static bool _QUALITY_VERY_HIGHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/tts/Voice.html#QUALITY_VERY_LOW"/>
        /// </summary>
        public static int QUALITY_VERY_LOW { get { if (!_QUALITY_VERY_LOWReady) { _QUALITY_VERY_LOWContent = SGetField<int>(LocalBridgeClazz, "QUALITY_VERY_LOW"); _QUALITY_VERY_LOWReady = true; } return _QUALITY_VERY_LOWContent; } }
        private static int _QUALITY_VERY_LOWContent = default;
        private static bool _QUALITY_VERY_LOWReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/tts/Voice.html#isNetworkConnectionRequired()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsNetworkConnectionRequired()
        {
            return IExecuteWithSignature<bool>("isNetworkConnectionRequired", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/tts/Voice.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/tts/Voice.html#getLatency()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetLatency()
        {
            return IExecuteWithSignature<int>("getLatency", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/tts/Voice.html#getQuality()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetQuality()
        {
            return IExecuteWithSignature<int>("getQuality", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/tts/Voice.html#getName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/tts/Voice.html#getLocale()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Locale"/></returns>
        public Java.Util.Locale GetLocale()
        {
            return IExecuteWithSignature<Java.Util.Locale>("getLocale", "()Ljava/util/Locale;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/tts/Voice.html#getFeatures()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Lang.String> GetFeatures()
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Lang.String>>("getFeatures", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/tts/Voice.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecuteWithSignature("writeToParcel", "(Landroid/os/Parcel;I)V", arg0, arg1);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}