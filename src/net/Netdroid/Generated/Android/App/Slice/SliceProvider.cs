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

namespace Android.App.Slice
{
    #region SliceProvider
    public partial class SliceProvider
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/SliceProvider.html#%3Cinit%3E(java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
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
        public Android.App.Slice.Slice OnBindSlice(Android.Net.Uri arg0, Java.Util.Set<Android.App.Slice.SliceSpec> arg1)
        {
            return IExecute<Android.App.Slice.Slice>("onBindSlice", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/SliceProvider.html#onMapIntentToUri(android.content.Intent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Intent"/></param>
        /// <returns><see cref="Android.Net.Uri"/></returns>
        public Android.Net.Uri OnMapIntentToUri(Android.Content.Intent arg0)
        {
            return IExecuteWithSignature<Android.Net.Uri>("onMapIntentToUri", "(Landroid/content/Intent;)Landroid/net/Uri;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/SliceProvider.html#onGetSliceDescendants(android.net.Uri)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
        /// <returns><see cref="Java.Util.Collection"/></returns>
        public Java.Util.Collection<Android.Net.Uri> OnGetSliceDescendants(Android.Net.Uri arg0)
        {
            return IExecuteWithSignature<Java.Util.Collection<Android.Net.Uri>>("onGetSliceDescendants", "(Landroid/net/Uri;)Ljava/util/Collection;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/SliceProvider.html#onSlicePinned(android.net.Uri)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
        public void OnSlicePinned(Android.Net.Uri arg0)
        {
            IExecuteWithSignature("onSlicePinned", "(Landroid/net/Uri;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/SliceProvider.html#onSliceUnpinned(android.net.Uri)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
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