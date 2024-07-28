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
*  This file is generated by MASES.JNetReflector (ver. 2.5.5.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util
{
    #region EventListenerProxy
    public partial class EventListenerProxy
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/EventListenerProxy.html#%3Cinit%3E(java.util.EventListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.EventListener"/></param>
        public EventListenerProxy(Java.Util.EventListener arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/EventListenerProxy.html#getListener()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.EventListener"/></returns>
        public Java.Util.EventListener GetListener()
        {
            return IExecuteWithSignature<Java.Util.EventListener>("getListener", "()Ljava/util/EventListener;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/EventListenerProxy.html#getListener()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.EventListener"/></returns>
        public Java.Util.EventListener GetListenerDirect()
        {
            return IExecuteWithSignature<Java.Util.EventListenerDirect, Java.Util.EventListener>("getListener", "()Ljava/util/EventListener;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region EventListenerProxy<T>
    public partial class EventListenerProxy<T>
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/EventListenerProxy.html#%3Cinit%3E(java.util.EventListener)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        public EventListenerProxy(T arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.EventListenerProxy{T}"/> to <see cref="Java.Util.EventListenerProxy"/>
        /// </summary>
        public static implicit operator Java.Util.EventListenerProxy(Java.Util.EventListenerProxy<T> t) => t.Cast<Java.Util.EventListenerProxy>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/EventListenerProxy.html#getListener()"/>
        /// </summary>
        /// <returns><typeparamref name="T"/></returns>
        public T GetListener()
        {
            return IExecuteWithSignature<T>("getListener", "()Ljava/util/EventListener;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}