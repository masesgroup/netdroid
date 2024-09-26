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

namespace Android.Content
{
    #region ClipDescription declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/content/ClipDescription.html"/>
    /// </summary>
    public partial class ClipDescription : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.content.ClipDescription";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ClipDescription() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ClipDescription(params object[] args) : base(args) { }

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

    #region ClipDescription implementation
    public partial class ClipDescription
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ClipDescription.html#%3Cinit%3E(android.content.ClipDescription)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.ClipDescription"/></param>
        public ClipDescription(Android.Content.ClipDescription arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ClipDescription.html#%3Cinit%3E(java.lang.CharSequence,java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public ClipDescription(Java.Lang.CharSequence arg0, Java.Lang.String[] arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ClipDescription.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ClipDescription.html#CLASSIFICATION_COMPLETE"/>
        /// </summary>
        public static int CLASSIFICATION_COMPLETE { get { if (!_CLASSIFICATION_COMPLETEReady) { _CLASSIFICATION_COMPLETEContent = SGetField<int>(LocalBridgeClazz, "CLASSIFICATION_COMPLETE"); _CLASSIFICATION_COMPLETEReady = true; } return _CLASSIFICATION_COMPLETEContent; } }
        private static int _CLASSIFICATION_COMPLETEContent = default;
        private static bool _CLASSIFICATION_COMPLETEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ClipDescription.html#CLASSIFICATION_NOT_COMPLETE"/>
        /// </summary>
        public static int CLASSIFICATION_NOT_COMPLETE { get { if (!_CLASSIFICATION_NOT_COMPLETEReady) { _CLASSIFICATION_NOT_COMPLETEContent = SGetField<int>(LocalBridgeClazz, "CLASSIFICATION_NOT_COMPLETE"); _CLASSIFICATION_NOT_COMPLETEReady = true; } return _CLASSIFICATION_NOT_COMPLETEContent; } }
        private static int _CLASSIFICATION_NOT_COMPLETEContent = default;
        private static bool _CLASSIFICATION_NOT_COMPLETEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ClipDescription.html#CLASSIFICATION_NOT_PERFORMED"/>
        /// </summary>
        public static int CLASSIFICATION_NOT_PERFORMED { get { if (!_CLASSIFICATION_NOT_PERFORMEDReady) { _CLASSIFICATION_NOT_PERFORMEDContent = SGetField<int>(LocalBridgeClazz, "CLASSIFICATION_NOT_PERFORMED"); _CLASSIFICATION_NOT_PERFORMEDReady = true; } return _CLASSIFICATION_NOT_PERFORMEDContent; } }
        private static int _CLASSIFICATION_NOT_PERFORMEDContent = default;
        private static bool _CLASSIFICATION_NOT_PERFORMEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ClipDescription.html#EXTRA_IS_REMOTE_DEVICE"/>
        /// </summary>
        public static Java.Lang.String EXTRA_IS_REMOTE_DEVICE { get { if (!_EXTRA_IS_REMOTE_DEVICEReady) { _EXTRA_IS_REMOTE_DEVICEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_IS_REMOTE_DEVICE"); _EXTRA_IS_REMOTE_DEVICEReady = true; } return _EXTRA_IS_REMOTE_DEVICEContent; } }
        private static Java.Lang.String _EXTRA_IS_REMOTE_DEVICEContent = default;
        private static bool _EXTRA_IS_REMOTE_DEVICEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ClipDescription.html#EXTRA_IS_SENSITIVE"/>
        /// </summary>
        public static Java.Lang.String EXTRA_IS_SENSITIVE { get { if (!_EXTRA_IS_SENSITIVEReady) { _EXTRA_IS_SENSITIVEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_IS_SENSITIVE"); _EXTRA_IS_SENSITIVEReady = true; } return _EXTRA_IS_SENSITIVEContent; } }
        private static Java.Lang.String _EXTRA_IS_SENSITIVEContent = default;
        private static bool _EXTRA_IS_SENSITIVEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ClipDescription.html#MIMETYPE_TEXT_HTML"/>
        /// </summary>
        public static Java.Lang.String MIMETYPE_TEXT_HTML { get { if (!_MIMETYPE_TEXT_HTMLReady) { _MIMETYPE_TEXT_HTMLContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "MIMETYPE_TEXT_HTML"); _MIMETYPE_TEXT_HTMLReady = true; } return _MIMETYPE_TEXT_HTMLContent; } }
        private static Java.Lang.String _MIMETYPE_TEXT_HTMLContent = default;
        private static bool _MIMETYPE_TEXT_HTMLReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ClipDescription.html#MIMETYPE_TEXT_INTENT"/>
        /// </summary>
        public static Java.Lang.String MIMETYPE_TEXT_INTENT { get { if (!_MIMETYPE_TEXT_INTENTReady) { _MIMETYPE_TEXT_INTENTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "MIMETYPE_TEXT_INTENT"); _MIMETYPE_TEXT_INTENTReady = true; } return _MIMETYPE_TEXT_INTENTContent; } }
        private static Java.Lang.String _MIMETYPE_TEXT_INTENTContent = default;
        private static bool _MIMETYPE_TEXT_INTENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ClipDescription.html#MIMETYPE_TEXT_PLAIN"/>
        /// </summary>
        public static Java.Lang.String MIMETYPE_TEXT_PLAIN { get { if (!_MIMETYPE_TEXT_PLAINReady) { _MIMETYPE_TEXT_PLAINContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "MIMETYPE_TEXT_PLAIN"); _MIMETYPE_TEXT_PLAINReady = true; } return _MIMETYPE_TEXT_PLAINContent; } }
        private static Java.Lang.String _MIMETYPE_TEXT_PLAINContent = default;
        private static bool _MIMETYPE_TEXT_PLAINReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ClipDescription.html#MIMETYPE_TEXT_URILIST"/>
        /// </summary>
        public static Java.Lang.String MIMETYPE_TEXT_URILIST { get { if (!_MIMETYPE_TEXT_URILISTReady) { _MIMETYPE_TEXT_URILISTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "MIMETYPE_TEXT_URILIST"); _MIMETYPE_TEXT_URILISTReady = true; } return _MIMETYPE_TEXT_URILISTContent; } }
        private static Java.Lang.String _MIMETYPE_TEXT_URILISTContent = default;
        private static bool _MIMETYPE_TEXT_URILISTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ClipDescription.html#MIMETYPE_UNKNOWN"/>
        /// </summary>
        public static Java.Lang.String MIMETYPE_UNKNOWN { get { if (!_MIMETYPE_UNKNOWNReady) { _MIMETYPE_UNKNOWNContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "MIMETYPE_UNKNOWN"); _MIMETYPE_UNKNOWNReady = true; } return _MIMETYPE_UNKNOWNContent; } }
        private static Java.Lang.String _MIMETYPE_UNKNOWNContent = default;
        private static bool _MIMETYPE_UNKNOWNReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ClipDescription.html#compareMimeTypes(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool CompareMimeTypes(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "compareMimeTypes", "(Ljava/lang/String;Ljava/lang/String;)Z", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ClipDescription.html#getExtras()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.PersistableBundle"/></returns>
        public Android.Os.PersistableBundle GetExtras()
        {
            return IExecuteWithSignature<Android.Os.PersistableBundle>("getExtras", "()Landroid/os/PersistableBundle;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ClipDescription.html#hasMimeType(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool HasMimeType(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<bool>("hasMimeType", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ClipDescription.html#isStyledText()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsStyledText()
        {
            return IExecuteWithSignature<bool>("isStyledText", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ClipDescription.html#getConfidenceScore(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="float"/></returns>
        public float GetConfidenceScore(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<float>("getConfidenceScore", "(Ljava/lang/String;)F", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ClipDescription.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ClipDescription.html#getClassificationStatus()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetClassificationStatus()
        {
            return IExecuteWithSignature<int>("getClassificationStatus", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ClipDescription.html#getMimeTypeCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMimeTypeCount()
        {
            return IExecuteWithSignature<int>("getMimeTypeCount", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ClipDescription.html#getLabel()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence GetLabel()
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("getLabel", "()Ljava/lang/CharSequence;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ClipDescription.html#getMimeType(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetMimeType(int arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getMimeType", "(I)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ClipDescription.html#filterMimeTypes(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String[] FilterMimeTypes(Java.Lang.String arg0)
        {
            return IExecuteWithSignatureArray<Java.Lang.String>("filterMimeTypes", "(Ljava/lang/String;)[Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ClipDescription.html#getTimestamp()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetTimestamp()
        {
            return IExecuteWithSignature<long>("getTimestamp", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ClipDescription.html#setExtras(android.os.PersistableBundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.PersistableBundle"/></param>
        public void SetExtras(Android.Os.PersistableBundle arg0)
        {
            IExecuteWithSignature("setExtras", "(Landroid/os/PersistableBundle;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ClipDescription.html#writeToParcel(android.os.Parcel,int)"/>
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