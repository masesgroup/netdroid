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
    #region ValueCallback
    public partial class ValueCallback
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
        /// <see href="https://developer.android.com/reference/android/webkit/ValueCallback.html#onReceiveValue(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public void OnReceiveValue(object arg0)
        {
            IExecuteWithSignature("onReceiveValue", "(Ljava/lang/Object;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region IValueCallback<T>
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IValueCallback<T>
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ValueCallback<T>
    public partial class ValueCallback<T> : Android.Webkit.IValueCallback<T>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.Webkit.ValueCallback{T}"/> to <see cref="Android.Webkit.ValueCallback"/>
        /// </summary>
        public static implicit operator Android.Webkit.ValueCallback(Android.Webkit.ValueCallback<T> t) => t.Cast<Android.Webkit.ValueCallback>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/ValueCallback.html#onReceiveValue(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        public void OnReceiveValue(T arg0)
        {
            IExecuteWithSignature("onReceiveValue", "(Ljava/lang/Object;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}