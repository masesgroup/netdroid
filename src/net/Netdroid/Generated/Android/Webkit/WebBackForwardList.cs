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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Webkit
{
    #region WebBackForwardList
    public partial class WebBackForwardList : Java.Lang.ICloneable, Java.Io.ISerializable
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.Webkit.WebBackForwardList"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Android.Webkit.WebBackForwardList t) => t.Cast<Java.Lang.Cloneable>();
        /// <summary>
        /// Converter from <see cref="Android.Webkit.WebBackForwardList"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Android.Webkit.WebBackForwardList t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebBackForwardList.html#getCurrentItem()"/>
        /// </summary>
        /// <returns><see cref="Android.Webkit.WebHistoryItem"/></returns>
        public Android.Webkit.WebHistoryItem GetCurrentItem()
        {
            return IExecuteWithSignature<Android.Webkit.WebHistoryItem>("getCurrentItem", "()Landroid/webkit/WebHistoryItem;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebBackForwardList.html#getItemAtIndex(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Webkit.WebHistoryItem"/></returns>
        public Android.Webkit.WebHistoryItem GetItemAtIndex(int arg0)
        {
            return IExecuteWithSignature<Android.Webkit.WebHistoryItem>("getItemAtIndex", "(I)Landroid/webkit/WebHistoryItem;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebBackForwardList.html#getCurrentIndex()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetCurrentIndex()
        {
            return IExecuteWithSignature<int>("getCurrentIndex", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebBackForwardList.html#getSize()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetSize()
        {
            return IExecuteWithSignature<int>("getSize", "()I");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}