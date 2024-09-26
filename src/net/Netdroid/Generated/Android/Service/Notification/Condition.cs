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
*  This file is generated by MASES.JNetReflector (ver. 2.5.9.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Service.Notification
{
    #region Condition declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/service/notification/Condition.html"/>
    /// </summary>
    public partial class Condition : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.service.notification.Condition";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Condition() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Condition(params object[] args) : base(args) { }

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

    #region Condition implementation
    public partial class Condition
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/Condition.html#%3Cinit%3E(android.net.Uri,java.lang.String,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public Condition(Android.Net.Uri arg0, Java.Lang.String arg1, int arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/Condition.html#%3Cinit%3E(android.net.Uri,java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public Condition(Android.Net.Uri arg0, Java.Lang.String arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/Condition.html#%3Cinit%3E(android.net.Uri,java.lang.String,java.lang.String,java.lang.String,int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <param name="arg7"><see cref="int"/></param>
        public Condition(Android.Net.Uri arg0, Java.Lang.String arg1, Java.Lang.String arg2, Java.Lang.String arg3, int arg4, int arg5, int arg6, int arg7)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/Condition.html#%3Cinit%3E(android.net.Uri,java.lang.String,java.lang.String,java.lang.String,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        public Condition(Android.Net.Uri arg0, Java.Lang.String arg1, Java.Lang.String arg2, Java.Lang.String arg3, int arg4, int arg5, int arg6)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/Condition.html#%3Cinit%3E(android.os.Parcel)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        public Condition(Android.Os.Parcel arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/Condition.html#id"/>
        /// </summary>
        public Android.Net.Uri id { get { if (!_idReady) { _idContent = IGetField<Android.Net.Uri>("id"); _idReady = true; } return _idContent; } }
        private Android.Net.Uri _idContent = default;
        private bool _idReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/Condition.html#flags"/>
        /// </summary>
        public int flags { get { if (!_flagsReady) { _flagsContent = IGetField<int>("flags"); _flagsReady = true; } return _flagsContent; } }
        private int _flagsContent = default;
        private bool _flagsReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/Condition.html#icon"/>
        /// </summary>
        public int icon { get { if (!_iconReady) { _iconContent = IGetField<int>("icon"); _iconReady = true; } return _iconContent; } }
        private int _iconContent = default;
        private bool _iconReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/Condition.html#source"/>
        /// </summary>
        public int source { get { if (!_sourceReady) { _sourceContent = IGetField<int>("source"); _sourceReady = true; } return _sourceContent; } }
        private int _sourceContent = default;
        private bool _sourceReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/Condition.html#state"/>
        /// </summary>
        public int state { get { if (!_stateReady) { _stateContent = IGetField<int>("state"); _stateReady = true; } return _stateContent; } }
        private int _stateContent = default;
        private bool _stateReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/Condition.html#line1"/>
        /// </summary>
        public Java.Lang.String line1 { get { if (!_line1Ready) { _line1Content = IGetField<Java.Lang.String>("line1"); _line1Ready = true; } return _line1Content; } }
        private Java.Lang.String _line1Content = default;
        private bool _line1Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/Condition.html#line2"/>
        /// </summary>
        public Java.Lang.String line2 { get { if (!_line2Ready) { _line2Content = IGetField<Java.Lang.String>("line2"); _line2Ready = true; } return _line2Content; } }
        private Java.Lang.String _line2Content = default;
        private bool _line2Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/Condition.html#summary"/>
        /// </summary>
        public Java.Lang.String summary { get { if (!_summaryReady) { _summaryContent = IGetField<Java.Lang.String>("summary"); _summaryReady = true; } return _summaryContent; } }
        private Java.Lang.String _summaryContent = default;
        private bool _summaryReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/Condition.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/Condition.html#FLAG_RELEVANT_ALWAYS"/>
        /// </summary>
        public static int FLAG_RELEVANT_ALWAYS { get { if (!_FLAG_RELEVANT_ALWAYSReady) { _FLAG_RELEVANT_ALWAYSContent = SGetField<int>(LocalBridgeClazz, "FLAG_RELEVANT_ALWAYS"); _FLAG_RELEVANT_ALWAYSReady = true; } return _FLAG_RELEVANT_ALWAYSContent; } }
        private static int _FLAG_RELEVANT_ALWAYSContent = default;
        private static bool _FLAG_RELEVANT_ALWAYSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/Condition.html#FLAG_RELEVANT_NOW"/>
        /// </summary>
        public static int FLAG_RELEVANT_NOW { get { if (!_FLAG_RELEVANT_NOWReady) { _FLAG_RELEVANT_NOWContent = SGetField<int>(LocalBridgeClazz, "FLAG_RELEVANT_NOW"); _FLAG_RELEVANT_NOWReady = true; } return _FLAG_RELEVANT_NOWContent; } }
        private static int _FLAG_RELEVANT_NOWContent = default;
        private static bool _FLAG_RELEVANT_NOWReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/Condition.html#SOURCE_CONTEXT"/>
        /// </summary>
        public static int SOURCE_CONTEXT { get { if (!_SOURCE_CONTEXTReady) { _SOURCE_CONTEXTContent = SGetField<int>(LocalBridgeClazz, "SOURCE_CONTEXT"); _SOURCE_CONTEXTReady = true; } return _SOURCE_CONTEXTContent; } }
        private static int _SOURCE_CONTEXTContent = default;
        private static bool _SOURCE_CONTEXTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/Condition.html#SOURCE_SCHEDULE"/>
        /// </summary>
        public static int SOURCE_SCHEDULE { get { if (!_SOURCE_SCHEDULEReady) { _SOURCE_SCHEDULEContent = SGetField<int>(LocalBridgeClazz, "SOURCE_SCHEDULE"); _SOURCE_SCHEDULEReady = true; } return _SOURCE_SCHEDULEContent; } }
        private static int _SOURCE_SCHEDULEContent = default;
        private static bool _SOURCE_SCHEDULEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/Condition.html#SOURCE_UNKNOWN"/>
        /// </summary>
        public static int SOURCE_UNKNOWN { get { if (!_SOURCE_UNKNOWNReady) { _SOURCE_UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "SOURCE_UNKNOWN"); _SOURCE_UNKNOWNReady = true; } return _SOURCE_UNKNOWNContent; } }
        private static int _SOURCE_UNKNOWNContent = default;
        private static bool _SOURCE_UNKNOWNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/Condition.html#SOURCE_USER_ACTION"/>
        /// </summary>
        public static int SOURCE_USER_ACTION { get { if (!_SOURCE_USER_ACTIONReady) { _SOURCE_USER_ACTIONContent = SGetField<int>(LocalBridgeClazz, "SOURCE_USER_ACTION"); _SOURCE_USER_ACTIONReady = true; } return _SOURCE_USER_ACTIONContent; } }
        private static int _SOURCE_USER_ACTIONContent = default;
        private static bool _SOURCE_USER_ACTIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/Condition.html#STATE_ERROR"/>
        /// </summary>
        public static int STATE_ERROR { get { if (!_STATE_ERRORReady) { _STATE_ERRORContent = SGetField<int>(LocalBridgeClazz, "STATE_ERROR"); _STATE_ERRORReady = true; } return _STATE_ERRORContent; } }
        private static int _STATE_ERRORContent = default;
        private static bool _STATE_ERRORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/Condition.html#STATE_FALSE"/>
        /// </summary>
        public static int STATE_FALSE { get { if (!_STATE_FALSEReady) { _STATE_FALSEContent = SGetField<int>(LocalBridgeClazz, "STATE_FALSE"); _STATE_FALSEReady = true; } return _STATE_FALSEContent; } }
        private static int _STATE_FALSEContent = default;
        private static bool _STATE_FALSEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/Condition.html#STATE_TRUE"/>
        /// </summary>
        public static int STATE_TRUE { get { if (!_STATE_TRUEReady) { _STATE_TRUEContent = SGetField<int>(LocalBridgeClazz, "STATE_TRUE"); _STATE_TRUEReady = true; } return _STATE_TRUEContent; } }
        private static int _STATE_TRUEContent = default;
        private static bool _STATE_TRUEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/Condition.html#STATE_UNKNOWN"/>
        /// </summary>
        public static int STATE_UNKNOWN { get { if (!_STATE_UNKNOWNReady) { _STATE_UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "STATE_UNKNOWN"); _STATE_UNKNOWNReady = true; } return _STATE_UNKNOWNContent; } }
        private static int _STATE_UNKNOWNContent = default;
        private static bool _STATE_UNKNOWNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/Condition.html#SCHEME"/>
        /// </summary>
        public static Java.Lang.String SCHEME { get { if (!_SCHEMEReady) { _SCHEMEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SCHEME"); _SCHEMEReady = true; } return _SCHEMEContent; } }
        private static Java.Lang.String _SCHEMEContent = default;
        private static bool _SCHEMEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/Condition.html#newId(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <returns><see cref="Android.Net.Uri.Builder"/></returns>
        public static Android.Net.Uri.Builder NewId(Android.Content.Context arg0)
        {
            return SExecuteWithSignature<Android.Net.Uri.Builder>(LocalBridgeClazz, "newId", "(Landroid/content/Context;)Landroid/net/Uri$Builder;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/Condition.html#isValidId(android.net.Uri,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsValidId(Android.Net.Uri arg0, Java.Lang.String arg1)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isValidId", "(Landroid/net/Uri;Ljava/lang/String;)Z", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/Condition.html#relevanceToString(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String RelevanceToString(int arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "relevanceToString", "(I)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/Condition.html#stateToString(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String StateToString(int arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "stateToString", "(I)Ljava/lang/String;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/Condition.html#copy()"/>
        /// </summary>
        /// <returns><see cref="Android.Service.Notification.Condition"/></returns>
        public Android.Service.Notification.Condition Copy()
        {
            return IExecuteWithSignature<Android.Service.Notification.Condition>("copy", "()Landroid/service/notification/Condition;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/Condition.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/notification/Condition.html#writeToParcel(android.os.Parcel,int)"/>
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