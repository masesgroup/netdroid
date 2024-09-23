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

namespace Android.Os.Storage
{
    #region StorageVolume declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/os/storage/StorageVolume.html"/>
    /// </summary>
    public partial class StorageVolume : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.os.storage.StorageVolume";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public StorageVolume() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public StorageVolume(params object[] args) : base(args) { }
    
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

    #region StorageVolume implementation
    public partial class StorageVolume
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/storage/StorageVolume.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/storage/StorageVolume.html#EXTRA_STORAGE_VOLUME"/>
        /// </summary>
        public static Java.Lang.String EXTRA_STORAGE_VOLUME { get { if (!_EXTRA_STORAGE_VOLUMEReady) { _EXTRA_STORAGE_VOLUMEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_STORAGE_VOLUME"); _EXTRA_STORAGE_VOLUMEReady = true; } return _EXTRA_STORAGE_VOLUMEContent; } }
        private static Java.Lang.String _EXTRA_STORAGE_VOLUMEContent = default;
        private static bool _EXTRA_STORAGE_VOLUMEReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/storage/StorageVolume.html#createAccessIntent(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Content.Intent"/></returns>
        [global::System.Obsolete()]
        public Android.Content.Intent CreateAccessIntent(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Android.Content.Intent>("createAccessIntent", "(Ljava/lang/String;)Landroid/content/Intent;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/storage/StorageVolume.html#createOpenDocumentTreeIntent()"/>
        /// </summary>
        /// <returns><see cref="Android.Content.Intent"/></returns>
        public Android.Content.Intent CreateOpenDocumentTreeIntent()
        {
            return IExecuteWithSignature<Android.Content.Intent>("createOpenDocumentTreeIntent", "()Landroid/content/Intent;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/storage/StorageVolume.html#getOwner()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.UserHandle"/></returns>
        public Android.Os.UserHandle GetOwner()
        {
            return IExecuteWithSignature<Android.Os.UserHandle>("getOwner", "()Landroid/os/UserHandle;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/storage/StorageVolume.html#isEmulated()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsEmulated()
        {
            return IExecuteWithSignature<bool>("isEmulated", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/storage/StorageVolume.html#isPrimary()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsPrimary()
        {
            return IExecuteWithSignature<bool>("isPrimary", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/storage/StorageVolume.html#isRemovable()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsRemovable()
        {
            return IExecuteWithSignature<bool>("isRemovable", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/storage/StorageVolume.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/storage/StorageVolume.html#getDirectory()"/>
        /// </summary>
        /// <returns><see cref="Java.Io.File"/></returns>
        public Java.Io.File GetDirectory()
        {
            return IExecuteWithSignature<Java.Io.File>("getDirectory", "()Ljava/io/File;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/storage/StorageVolume.html#getDescription(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetDescription(Android.Content.Context arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getDescription", "(Landroid/content/Context;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/storage/StorageVolume.html#getMediaStoreVolumeName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetMediaStoreVolumeName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getMediaStoreVolumeName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/storage/StorageVolume.html#getState()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetState()
        {
            return IExecuteWithSignature<Java.Lang.String>("getState", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/storage/StorageVolume.html#getUuid()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetUuid()
        {
            return IExecuteWithSignature<Java.Lang.String>("getUuid", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/storage/StorageVolume.html#getStorageUuid()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.UUID"/></returns>
        public Java.Util.UUID GetStorageUuid()
        {
            return IExecuteWithSignature<Java.Util.UUID>("getStorageUuid", "()Ljava/util/UUID;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/storage/StorageVolume.html#writeToParcel(android.os.Parcel,int)"/>
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