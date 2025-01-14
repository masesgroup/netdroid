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

namespace Android.Provider
{
    #region DocumentsProvider declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/provider/DocumentsProvider.html"/>
    /// </summary>
    public partial class DocumentsProvider : Android.Content.ContentProvider
    {
        const string _bridgeClassName = "android.provider.DocumentsProvider";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("DocumentsProvider class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public DocumentsProvider() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("DocumentsProvider class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public DocumentsProvider(params object[] args) : base(args) { }
    
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
    
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => true;
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

    #region DocumentsProvider implementation
    public partial class DocumentsProvider
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
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/DocumentsProvider.html#queryChildDocuments(java.lang.String,java.lang.String[],java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Database.Cursor"/></returns>
        /// <exception cref="Java.Io.FileNotFoundException"/>
        public Android.Database.Cursor QueryChildDocuments(Java.Lang.String arg0, Java.Lang.String[] arg1, Java.Lang.String arg2)
        {
            return IExecuteWithSignature<Android.Database.Cursor>("queryChildDocuments", "(Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/DocumentsProvider.html#queryDocument(java.lang.String,java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Database.Cursor"/></returns>
        /// <exception cref="Java.Io.FileNotFoundException"/>
        public Android.Database.Cursor QueryDocument(Java.Lang.String arg0, Java.Lang.String[] arg1)
        {
            return IExecuteWithSignature<Android.Database.Cursor>("queryDocument", "(Ljava/lang/String;[Ljava/lang/String;)Landroid/database/Cursor;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/DocumentsProvider.html#queryRoots(java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Database.Cursor"/></returns>
        /// <exception cref="Java.Io.FileNotFoundException"/>
        public Android.Database.Cursor QueryRoots(Java.Lang.String[] arg0)
        {
            return IExecuteWithSignature<Android.Database.Cursor>("queryRoots", "([Ljava/lang/String;)Landroid/database/Cursor;", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/DocumentsProvider.html#openDocument(java.lang.String,java.lang.String,android.os.CancellationSignal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Android.Os.CancellationSignal"/></param>
        /// <returns><see cref="Android.Os.ParcelFileDescriptor"/></returns>
        /// <exception cref="Java.Io.FileNotFoundException"/>
        public Android.Os.ParcelFileDescriptor OpenDocument(Java.Lang.String arg0, Java.Lang.String arg1, Android.Os.CancellationSignal arg2)
        {
            return IExecuteWithSignature<Android.Os.ParcelFileDescriptor>("openDocument", "(Ljava/lang/String;Ljava/lang/String;Landroid/os/CancellationSignal;)Landroid/os/ParcelFileDescriptor;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/DocumentsProvider.html#createWebLinkIntent(java.lang.String,android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.Os.Bundle"/></param>
        /// <returns><see cref="Android.Content.IntentSender"/></returns>
        /// <exception cref="Java.Io.FileNotFoundException"/>
        public Android.Content.IntentSender CreateWebLinkIntent(Java.Lang.String arg0, Android.Os.Bundle arg1)
        {
            return IExecuteWithSignature<Android.Content.IntentSender>("createWebLinkIntent", "(Ljava/lang/String;Landroid/os/Bundle;)Landroid/content/IntentSender;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/DocumentsProvider.html#openDocumentThumbnail(java.lang.String,android.graphics.Point,android.os.CancellationSignal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.Point"/></param>
        /// <param name="arg2"><see cref="Android.Os.CancellationSignal"/></param>
        /// <returns><see cref="Android.Content.Res.AssetFileDescriptor"/></returns>
        /// <exception cref="Java.Io.FileNotFoundException"/>
        public Android.Content.Res.AssetFileDescriptor OpenDocumentThumbnail(Java.Lang.String arg0, Android.Graphics.Point arg1, Android.Os.CancellationSignal arg2)
        {
            return IExecuteWithSignature<Android.Content.Res.AssetFileDescriptor>("openDocumentThumbnail", "(Ljava/lang/String;Landroid/graphics/Point;Landroid/os/CancellationSignal;)Landroid/content/res/AssetFileDescriptor;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/DocumentsProvider.html#openTypedDocument(java.lang.String,java.lang.String,android.os.Bundle,android.os.CancellationSignal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Android.Os.Bundle"/></param>
        /// <param name="arg3"><see cref="Android.Os.CancellationSignal"/></param>
        /// <returns><see cref="Android.Content.Res.AssetFileDescriptor"/></returns>
        /// <exception cref="Java.Io.FileNotFoundException"/>
        public Android.Content.Res.AssetFileDescriptor OpenTypedDocument(Java.Lang.String arg0, Java.Lang.String arg1, Android.Os.Bundle arg2, Android.Os.CancellationSignal arg3)
        {
            return IExecuteWithSignature<Android.Content.Res.AssetFileDescriptor>("openTypedDocument", "(Ljava/lang/String;Ljava/lang/String;Landroid/os/Bundle;Landroid/os/CancellationSignal;)Landroid/content/res/AssetFileDescriptor;", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/DocumentsProvider.html#queryChildDocuments(java.lang.String,java.lang.String[],android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Android.Os.Bundle"/></param>
        /// <returns><see cref="Android.Database.Cursor"/></returns>
        /// <exception cref="Java.Io.FileNotFoundException"/>
        public Android.Database.Cursor QueryChildDocuments(Java.Lang.String arg0, Java.Lang.String[] arg1, Android.Os.Bundle arg2)
        {
            return IExecuteWithSignature<Android.Database.Cursor>("queryChildDocuments", "(Ljava/lang/String;[Ljava/lang/String;Landroid/os/Bundle;)Landroid/database/Cursor;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/DocumentsProvider.html#queryRecentDocuments(java.lang.String,java.lang.String[],android.os.Bundle,android.os.CancellationSignal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Android.Os.Bundle"/></param>
        /// <param name="arg3"><see cref="Android.Os.CancellationSignal"/></param>
        /// <returns><see cref="Android.Database.Cursor"/></returns>
        /// <exception cref="Java.Io.FileNotFoundException"/>
        public Android.Database.Cursor QueryRecentDocuments(Java.Lang.String arg0, Java.Lang.String[] arg1, Android.Os.Bundle arg2, Android.Os.CancellationSignal arg3)
        {
            return IExecuteWithSignature<Android.Database.Cursor>("queryRecentDocuments", "(Ljava/lang/String;[Ljava/lang/String;Landroid/os/Bundle;Landroid/os/CancellationSignal;)Landroid/database/Cursor;", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/DocumentsProvider.html#queryRecentDocuments(java.lang.String,java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Database.Cursor"/></returns>
        /// <exception cref="Java.Io.FileNotFoundException"/>
        public Android.Database.Cursor QueryRecentDocuments(Java.Lang.String arg0, Java.Lang.String[] arg1)
        {
            return IExecuteWithSignature<Android.Database.Cursor>("queryRecentDocuments", "(Ljava/lang/String;[Ljava/lang/String;)Landroid/database/Cursor;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/DocumentsProvider.html#querySearchDocuments(java.lang.String,java.lang.String,java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Database.Cursor"/></returns>
        /// <exception cref="Java.Io.FileNotFoundException"/>
        public Android.Database.Cursor QuerySearchDocuments(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String[] arg2)
        {
            return IExecuteWithSignature<Android.Database.Cursor>("querySearchDocuments", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;)Landroid/database/Cursor;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/DocumentsProvider.html#querySearchDocuments(java.lang.String,java.lang.String[],android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Android.Os.Bundle"/></param>
        /// <returns><see cref="Android.Database.Cursor"/></returns>
        /// <exception cref="Java.Io.FileNotFoundException"/>
        public Android.Database.Cursor QuerySearchDocuments(Java.Lang.String arg0, Java.Lang.String[] arg1, Android.Os.Bundle arg2)
        {
            return IExecuteWithSignature<Android.Database.Cursor>("querySearchDocuments", "(Ljava/lang/String;[Ljava/lang/String;Landroid/os/Bundle;)Landroid/database/Cursor;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/DocumentsProvider.html#getDocumentMetadata(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Os.Bundle"/></returns>
        /// <exception cref="Java.Io.FileNotFoundException"/>
        public Android.Os.Bundle GetDocumentMetadata(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Android.Os.Bundle>("getDocumentMetadata", "(Ljava/lang/String;)Landroid/os/Bundle;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/DocumentsProvider.html#findDocumentPath(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Provider.DocumentsContract.Path"/></returns>
        /// <exception cref="Java.Io.FileNotFoundException"/>
        public Android.Provider.DocumentsContract.Path FindDocumentPath(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return IExecuteWithSignature<Android.Provider.DocumentsContract.Path>("findDocumentPath", "(Ljava/lang/String;Ljava/lang/String;)Landroid/provider/DocumentsContract$Path;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/DocumentsProvider.html#isChildDocument(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsChildDocument(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return IExecuteWithSignature<bool>("isChildDocument", "(Ljava/lang/String;Ljava/lang/String;)Z", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/DocumentsProvider.html#revokeDocumentPermission(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void RevokeDocumentPermission(Java.Lang.String arg0)
        {
            IExecuteWithSignature("revokeDocumentPermission", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/DocumentsProvider.html#copyDocument(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Java.Io.FileNotFoundException"/>
        public Java.Lang.String CopyDocument(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return IExecuteWithSignature<Java.Lang.String>("copyDocument", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/DocumentsProvider.html#createDocument(java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Java.Io.FileNotFoundException"/>
        public Java.Lang.String CreateDocument(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String arg2)
        {
            return IExecuteWithSignature<Java.Lang.String>("createDocument", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/DocumentsProvider.html#getDocumentType(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Java.Io.FileNotFoundException"/>
        public Java.Lang.String GetDocumentType(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getDocumentType", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/DocumentsProvider.html#moveDocument(java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Java.Io.FileNotFoundException"/>
        public Java.Lang.String MoveDocument(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String arg2)
        {
            return IExecuteWithSignature<Java.Lang.String>("moveDocument", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/DocumentsProvider.html#renameDocument(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Java.Io.FileNotFoundException"/>
        public Java.Lang.String RenameDocument(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return IExecuteWithSignature<Java.Lang.String>("renameDocument", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/DocumentsProvider.html#getDocumentStreamTypes(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String[] GetDocumentStreamTypes(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return IExecuteWithSignatureArray<Java.Lang.String>("getDocumentStreamTypes", "(Ljava/lang/String;Ljava/lang/String;)[Ljava/lang/String;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/DocumentsProvider.html#deleteDocument(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Io.FileNotFoundException"/>
        public void DeleteDocument(Java.Lang.String arg0)
        {
            IExecuteWithSignature("deleteDocument", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/DocumentsProvider.html#ejectRoot(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void EjectRoot(Java.Lang.String arg0)
        {
            IExecuteWithSignature("ejectRoot", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/DocumentsProvider.html#removeDocument(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Io.FileNotFoundException"/>
        public void RemoveDocument(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            IExecuteWithSignature("removeDocument", "(Ljava/lang/String;Ljava/lang/String;)V", arg0, arg1);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}