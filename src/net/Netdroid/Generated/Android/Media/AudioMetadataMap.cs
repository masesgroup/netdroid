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

namespace Android.Media
{
    #region IAudioMetadataMap
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IAudioMetadataMap : Android.Media.IAudioMetadataReadMap
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioMetadataMap.html#remove(android.media.AudioMetadata.Key)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Media.AudioMetadata.Key"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        T Remove<T>(Android.Media.AudioMetadata.Key<T> arg0);
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioMetadataMap.html#set(android.media.AudioMetadata.Key,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Media.AudioMetadata.Key"/></param>
        /// <param name="arg1"><typeparamref name="T"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        T Set<T>(Android.Media.AudioMetadata.Key<T> arg0, T arg1);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region AudioMetadataMap
    public partial class AudioMetadataMap : Android.Media.IAudioMetadataMap
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
        /// <see href="https://developer.android.com/reference/android/media/AudioMetadataMap.html#remove(android.media.AudioMetadata.Key)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Media.AudioMetadata.Key"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        public T Remove<T>(Android.Media.AudioMetadata.Key<T> arg0)
        {
            return IExecuteWithSignature<T>("remove", "(Landroid/media/AudioMetadata$Key;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioMetadataMap.html#set(android.media.AudioMetadata.Key,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Media.AudioMetadata.Key"/></param>
        /// <param name="arg1"><typeparamref name="T"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        public T Set<T>(Android.Media.AudioMetadata.Key<T> arg0, T arg1)
        {
            return IExecute<T>("set", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}