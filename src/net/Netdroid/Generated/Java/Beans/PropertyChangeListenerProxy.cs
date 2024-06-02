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

namespace Java.Beans
{
    #region PropertyChangeListenerProxy
    public partial class PropertyChangeListenerProxy
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/beans/PropertyChangeListenerProxy.html#%3Cinit%3E(java.lang.String,java.beans.PropertyChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Beans.PropertyChangeListener"/></param>
        public PropertyChangeListenerProxy(Java.Lang.String arg0, Java.Beans.PropertyChangeListener arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Beans.PropertyChangeListenerProxy"/> to <see cref="Java.Beans.PropertyChangeListener"/>
        /// </summary>
        public static implicit operator Java.Beans.PropertyChangeListener(Java.Beans.PropertyChangeListenerProxy t) => t.Cast<Java.Beans.PropertyChangeListener>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/beans/PropertyChangeListenerProxy.html#getPropertyName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetPropertyName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getPropertyName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/beans/PropertyChangeListenerProxy.html#propertyChange(java.beans.PropertyChangeEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.PropertyChangeEvent"/></param>
        public void PropertyChange(Java.Beans.PropertyChangeEvent arg0)
        {
            IExecuteWithSignature("propertyChange", "(Ljava/beans/PropertyChangeEvent;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}