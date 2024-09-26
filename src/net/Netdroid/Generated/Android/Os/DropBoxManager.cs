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

namespace Android.Os
{
    #region DropBoxManager declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/os/DropBoxManager.html"/>
    /// </summary>
    public partial class DropBoxManager : MASES.JCOBridge.C2JBridge.JVMBridgeBase<DropBoxManager>
    {
        const string _bridgeClassName = "android.os.DropBoxManager";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public DropBoxManager() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public DropBoxManager(params object[] args) : base(args) { }

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
        #region Entry declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/DropBoxManager.Entry.html"/>
        /// </summary>
        public partial class Entry : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Entry>
        {
            const string _bridgeClassName = "android.os.DropBoxManager$Entry";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Entry() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Entry(params object[] args) : base(args) { }

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
            public override bool IsBridgeStatic => true;

            // TODO: complete the class

        }
        #endregion

    
    }
    #endregion

    #region DropBoxManager implementation
    public partial class DropBoxManager
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/DropBoxManager.html#IS_EMPTY"/>
        /// </summary>
        public static int IS_EMPTY { get { if (!_IS_EMPTYReady) { _IS_EMPTYContent = SGetField<int>(LocalBridgeClazz, "IS_EMPTY"); _IS_EMPTYReady = true; } return _IS_EMPTYContent; } }
        private static int _IS_EMPTYContent = default;
        private static bool _IS_EMPTYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/DropBoxManager.html#IS_GZIPPED"/>
        /// </summary>
        public static int IS_GZIPPED { get { if (!_IS_GZIPPEDReady) { _IS_GZIPPEDContent = SGetField<int>(LocalBridgeClazz, "IS_GZIPPED"); _IS_GZIPPEDReady = true; } return _IS_GZIPPEDContent; } }
        private static int _IS_GZIPPEDContent = default;
        private static bool _IS_GZIPPEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/DropBoxManager.html#IS_TEXT"/>
        /// </summary>
        public static int IS_TEXT { get { if (!_IS_TEXTReady) { _IS_TEXTContent = SGetField<int>(LocalBridgeClazz, "IS_TEXT"); _IS_TEXTReady = true; } return _IS_TEXTContent; } }
        private static int _IS_TEXTContent = default;
        private static bool _IS_TEXTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/DropBoxManager.html#ACTION_DROPBOX_ENTRY_ADDED"/>
        /// </summary>
        public static Java.Lang.String ACTION_DROPBOX_ENTRY_ADDED { get { if (!_ACTION_DROPBOX_ENTRY_ADDEDReady) { _ACTION_DROPBOX_ENTRY_ADDEDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_DROPBOX_ENTRY_ADDED"); _ACTION_DROPBOX_ENTRY_ADDEDReady = true; } return _ACTION_DROPBOX_ENTRY_ADDEDContent; } }
        private static Java.Lang.String _ACTION_DROPBOX_ENTRY_ADDEDContent = default;
        private static bool _ACTION_DROPBOX_ENTRY_ADDEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/DropBoxManager.html#EXTRA_DROPPED_COUNT"/>
        /// </summary>
        public static Java.Lang.String EXTRA_DROPPED_COUNT { get { if (!_EXTRA_DROPPED_COUNTReady) { _EXTRA_DROPPED_COUNTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_DROPPED_COUNT"); _EXTRA_DROPPED_COUNTReady = true; } return _EXTRA_DROPPED_COUNTContent; } }
        private static Java.Lang.String _EXTRA_DROPPED_COUNTContent = default;
        private static bool _EXTRA_DROPPED_COUNTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/DropBoxManager.html#EXTRA_TAG"/>
        /// </summary>
        public static Java.Lang.String EXTRA_TAG { get { if (!_EXTRA_TAGReady) { _EXTRA_TAGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_TAG"); _EXTRA_TAGReady = true; } return _EXTRA_TAGContent; } }
        private static Java.Lang.String _EXTRA_TAGContent = default;
        private static bool _EXTRA_TAGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/DropBoxManager.html#EXTRA_TIME"/>
        /// </summary>
        public static Java.Lang.String EXTRA_TIME { get { if (!_EXTRA_TIMEReady) { _EXTRA_TIMEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_TIME"); _EXTRA_TIMEReady = true; } return _EXTRA_TIMEContent; } }
        private static Java.Lang.String _EXTRA_TIMEContent = default;
        private static bool _EXTRA_TIMEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/DropBoxManager.html#getNextEntry(java.lang.String,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="Android.Os.DropBoxManager.Entry"/></returns>
        public Android.Os.DropBoxManager.Entry GetNextEntry(Java.Lang.String arg0, long arg1)
        {
            return IExecuteWithSignature<Android.Os.DropBoxManager.Entry>("getNextEntry", "(Ljava/lang/String;J)Landroid/os/DropBoxManager$Entry;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/DropBoxManager.html#isTagEnabled(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsTagEnabled(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<bool>("isTagEnabled", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/DropBoxManager.html#addData(java.lang.String,byte[],int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void AddData(Java.Lang.String arg0, byte[] arg1, int arg2)
        {
            IExecuteWithSignature("addData", "(Ljava/lang/String;[BI)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/DropBoxManager.html#addFile(java.lang.String,java.io.File,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Io.File"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void AddFile(Java.Lang.String arg0, Java.Io.File arg1, int arg2)
        {
            IExecuteWithSignature("addFile", "(Ljava/lang/String;Ljava/io/File;I)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/DropBoxManager.html#addText(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public void AddText(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            IExecuteWithSignature("addText", "(Ljava/lang/String;Ljava/lang/String;)V", arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region Entry implementation
        public partial class Entry : Android.Os.IParcelable, Java.Io.ICloseable
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/DropBoxManager.Entry.html#%3Cinit%3E(java.lang.String,long,android.os.ParcelFileDescriptor,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="long"/></param>
            /// <param name="arg2"><see cref="Android.Os.ParcelFileDescriptor"/></param>
            /// <param name="arg3"><see cref="int"/></param>
            public Entry(Java.Lang.String arg0, long arg1, Android.Os.ParcelFileDescriptor arg2, int arg3)
                : base(arg0, arg1, arg2, arg3)
            {
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/DropBoxManager.Entry.html#%3Cinit%3E(java.lang.String,long,byte[],int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="long"/></param>
            /// <param name="arg2"><see cref="byte"/></param>
            /// <param name="arg3"><see cref="int"/></param>
            public Entry(Java.Lang.String arg0, long arg1, byte[] arg2, int arg3)
                : base(arg0, arg1, arg2, arg3)
            {
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/DropBoxManager.Entry.html#%3Cinit%3E(java.lang.String,long,java.io.File,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="long"/></param>
            /// <param name="arg2"><see cref="Java.Io.File"/></param>
            /// <param name="arg3"><see cref="int"/></param>
            /// <exception cref="Java.Io.IOException"/>
            public Entry(Java.Lang.String arg0, long arg1, Java.Io.File arg2, int arg3)
                : base(arg0, arg1, arg2, arg3)
            {
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/DropBoxManager.Entry.html#%3Cinit%3E(java.lang.String,long,java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="long"/></param>
            /// <param name="arg2"><see cref="Java.Lang.String"/></param>
            public Entry(Java.Lang.String arg0, long arg1, Java.Lang.String arg2)
                : base(arg0, arg1, arg2)
            {
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/DropBoxManager.Entry.html#%3Cinit%3E(java.lang.String,long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="long"/></param>
            public Entry(Java.Lang.String arg0, long arg1)
                : base(arg0, arg1)
            {
            }

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Android.Os.DropBoxManager.Entry"/> to <see cref="Android.Os.Parcelable"/>
            /// </summary>
            public static implicit operator Android.Os.Parcelable(Android.Os.DropBoxManager.Entry t) => t.Cast<Android.Os.Parcelable>();
            /// <summary>
            /// Converter from <see cref="Android.Os.DropBoxManager.Entry"/> to <see cref="Java.Io.Closeable"/>
            /// </summary>
            public static implicit operator Java.Io.Closeable(Android.Os.DropBoxManager.Entry t) => t.Cast<Java.Io.Closeable>();

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/DropBoxManager.Entry.html#CREATOR"/>
            /// </summary>
            public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
            private static Android.Os.Parcelable.Creator _CREATORContent = default;
            private static bool _CREATORReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/DropBoxManager.Entry.html#describeContents()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int DescribeContents()
            {
                return IExecuteWithSignature<int>("describeContents", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/DropBoxManager.Entry.html#getFlags()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetFlags()
            {
                return IExecuteWithSignature<int>("getFlags", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/DropBoxManager.Entry.html#getInputStream()"/>
            /// </summary>
            /// <returns><see cref="Java.Io.InputStream"/></returns>
            /// <exception cref="Java.Io.IOException"/>
            public Java.Io.InputStream GetInputStream()
            {
                return IExecuteWithSignature<Java.Io.InputStream>("getInputStream", "()Ljava/io/InputStream;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/DropBoxManager.Entry.html#getTag()"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String GetTag()
            {
                return IExecuteWithSignature<Java.Lang.String>("getTag", "()Ljava/lang/String;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/DropBoxManager.Entry.html#getText(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String GetText(int arg0)
            {
                return IExecuteWithSignature<Java.Lang.String>("getText", "(I)Ljava/lang/String;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/DropBoxManager.Entry.html#getTimeMillis()"/>
            /// </summary>
            /// <returns><see cref="long"/></returns>
            public long GetTimeMillis()
            {
                return IExecuteWithSignature<long>("getTimeMillis", "()J");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/DropBoxManager.Entry.html#close()"/>
            /// </summary>
            public void Close()
            {
                IExecuteWithSignature("close", "()V");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/DropBoxManager.Entry.html#writeToParcel(android.os.Parcel,int)"/>
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

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}