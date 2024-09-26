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

namespace Android.App.Slice
{
    #region SliceProvider declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/app/slice/SliceProvider.html"/>
    /// </summary>
    [global::System.Obsolete()]
    public partial class SliceProvider : Android.Content.ContentProvider
    {
        const string _bridgeClassName = "android.app.slice.SliceProvider";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("SliceProvider class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public SliceProvider() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("SliceProvider class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public SliceProvider(params object[] args) : base(args) { }

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

    #region SliceProvider implementation
    public partial class SliceProvider
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/SliceProvider.html#%3Cinit%3E(java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        [global::System.Obsolete()]
        public SliceProvider(params Java.Lang.String[] arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/SliceProvider.html#SLICE_TYPE"/>
        /// </summary>
        [global::System.Obsolete()]
        public static Java.Lang.String SLICE_TYPE { get { if (!_SLICE_TYPEReady) { _SLICE_TYPEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SLICE_TYPE"); _SLICE_TYPEReady = true; } return _SLICE_TYPEContent; } }
        private static Java.Lang.String _SLICE_TYPEContent = default;
        private static bool _SLICE_TYPEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/SliceProvider.html#onCreatePermissionRequest(android.net.Uri)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
        /// <returns><see cref="Android.App.PendingIntent"/></returns>
        [global::System.Obsolete()]
        public Android.App.PendingIntent OnCreatePermissionRequest(Android.Net.Uri arg0)
        {
            return IExecuteWithSignature<Android.App.PendingIntent>("onCreatePermissionRequest", "(Landroid/net/Uri;)Landroid/app/PendingIntent;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/SliceProvider.html#onBindSlice(android.net.Uri,java.util.Set)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
        /// <param name="arg1"><see cref="Java.Util.Set"/></param>
        /// <returns><see cref="Android.App.Slice.Slice"/></returns>
        [global::System.Obsolete()]
        public Android.App.Slice.Slice OnBindSlice(Android.Net.Uri arg0, Java.Util.Set<Android.App.Slice.SliceSpec> arg1)
        {
            return IExecuteWithSignature<Android.App.Slice.Slice>("onBindSlice", "(Landroid/net/Uri;Ljava/util/Set;)Landroid/app/slice/Slice;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/SliceProvider.html#onMapIntentToUri(android.content.Intent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Intent"/></param>
        /// <returns><see cref="Android.Net.Uri"/></returns>
        [global::System.Obsolete()]
        public Android.Net.Uri OnMapIntentToUri(Android.Content.Intent arg0)
        {
            return IExecuteWithSignature<Android.Net.Uri>("onMapIntentToUri", "(Landroid/content/Intent;)Landroid/net/Uri;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/SliceProvider.html#onGetSliceDescendants(android.net.Uri)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
        /// <returns><see cref="Java.Util.Collection"/></returns>
        [global::System.Obsolete()]
        public Java.Util.Collection<Android.Net.Uri> OnGetSliceDescendants(Android.Net.Uri arg0)
        {
            return IExecuteWithSignature<Java.Util.Collection<Android.Net.Uri>>("onGetSliceDescendants", "(Landroid/net/Uri;)Ljava/util/Collection;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/SliceProvider.html#onSlicePinned(android.net.Uri)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
        [global::System.Obsolete()]
        public void OnSlicePinned(Android.Net.Uri arg0)
        {
            IExecuteWithSignature("onSlicePinned", "(Landroid/net/Uri;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/SliceProvider.html#onSliceUnpinned(android.net.Uri)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
        [global::System.Obsolete()]
        public void OnSliceUnpinned(Android.Net.Uri arg0)
        {
            IExecuteWithSignature("onSliceUnpinned", "(Landroid/net/Uri;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}