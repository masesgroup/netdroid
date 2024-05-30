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

namespace Android.Content.Res.Loader
{
    #region ResourcesProvider
    public partial class ResourcesProvider : Java.Lang.IAutoCloseable, Java.Io.ICloseable
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.Content.Res.Loader.ResourcesProvider"/> to <see cref="Java.Lang.AutoCloseable"/>
        /// </summary>
        public static implicit operator Java.Lang.AutoCloseable(Android.Content.Res.Loader.ResourcesProvider t) => t.Cast<Java.Lang.AutoCloseable>();
        /// <summary>
        /// Converter from <see cref="Android.Content.Res.Loader.ResourcesProvider"/> to <see cref="Java.Io.Closeable"/>
        /// </summary>
        public static implicit operator Java.Io.Closeable(Android.Content.Res.Loader.ResourcesProvider t) => t.Cast<Java.Io.Closeable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/res/loader/ResourcesProvider.html#empty(android.content.res.loader.AssetsProvider)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Res.Loader.AssetsProvider"/></param>
        /// <returns><see cref="Android.Content.Res.Loader.ResourcesProvider"/></returns>
        public static Android.Content.Res.Loader.ResourcesProvider Empty(Android.Content.Res.Loader.AssetsProvider arg0)
        {
            return SExecuteWithSignature<Android.Content.Res.Loader.ResourcesProvider>(LocalBridgeClazz, "empty", "(Landroid/content/res/loader/AssetsProvider;)Landroid/content/res/loader/ResourcesProvider;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/res/loader/ResourcesProvider.html#loadFromApk(android.os.ParcelFileDescriptor,android.content.res.loader.AssetsProvider)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.ParcelFileDescriptor"/></param>
        /// <param name="arg1"><see cref="Android.Content.Res.Loader.AssetsProvider"/></param>
        /// <returns><see cref="Android.Content.Res.Loader.ResourcesProvider"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Android.Content.Res.Loader.ResourcesProvider LoadFromApk(Android.Os.ParcelFileDescriptor arg0, Android.Content.Res.Loader.AssetsProvider arg1)
        {
            return SExecute<Android.Content.Res.Loader.ResourcesProvider>(LocalBridgeClazz, "loadFromApk", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/res/loader/ResourcesProvider.html#loadFromApk(android.os.ParcelFileDescriptor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.ParcelFileDescriptor"/></param>
        /// <returns><see cref="Android.Content.Res.Loader.ResourcesProvider"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Android.Content.Res.Loader.ResourcesProvider LoadFromApk(Android.Os.ParcelFileDescriptor arg0)
        {
            return SExecuteWithSignature<Android.Content.Res.Loader.ResourcesProvider>(LocalBridgeClazz, "loadFromApk", "(Landroid/os/ParcelFileDescriptor;)Landroid/content/res/loader/ResourcesProvider;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/res/loader/ResourcesProvider.html#loadFromDirectory(java.lang.String,android.content.res.loader.AssetsProvider)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.Content.Res.Loader.AssetsProvider"/></param>
        /// <returns><see cref="Android.Content.Res.Loader.ResourcesProvider"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Android.Content.Res.Loader.ResourcesProvider LoadFromDirectory(Java.Lang.String arg0, Android.Content.Res.Loader.AssetsProvider arg1)
        {
            return SExecute<Android.Content.Res.Loader.ResourcesProvider>(LocalBridgeClazz, "loadFromDirectory", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/res/loader/ResourcesProvider.html#loadFromSplit(android.content.Context,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Content.Res.Loader.ResourcesProvider"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Android.Content.Res.Loader.ResourcesProvider LoadFromSplit(Android.Content.Context arg0, Java.Lang.String arg1)
        {
            return SExecute<Android.Content.Res.Loader.ResourcesProvider>(LocalBridgeClazz, "loadFromSplit", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/res/loader/ResourcesProvider.html#loadFromTable(android.os.ParcelFileDescriptor,android.content.res.loader.AssetsProvider)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.ParcelFileDescriptor"/></param>
        /// <param name="arg1"><see cref="Android.Content.Res.Loader.AssetsProvider"/></param>
        /// <returns><see cref="Android.Content.Res.Loader.ResourcesProvider"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Android.Content.Res.Loader.ResourcesProvider LoadFromTable(Android.Os.ParcelFileDescriptor arg0, Android.Content.Res.Loader.AssetsProvider arg1)
        {
            return SExecute<Android.Content.Res.Loader.ResourcesProvider>(LocalBridgeClazz, "loadFromTable", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/res/loader/ResourcesProvider.html#loadOverlay(android.content.om.OverlayInfo)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Om.OverlayInfo"/></param>
        /// <returns><see cref="Android.Content.Res.Loader.ResourcesProvider"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Android.Content.Res.Loader.ResourcesProvider LoadOverlay(Android.Content.Om.OverlayInfo arg0)
        {
            return SExecuteWithSignature<Android.Content.Res.Loader.ResourcesProvider>(LocalBridgeClazz, "loadOverlay", "(Landroid/content/om/OverlayInfo;)Landroid/content/res/loader/ResourcesProvider;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/res/loader/ResourcesProvider.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}