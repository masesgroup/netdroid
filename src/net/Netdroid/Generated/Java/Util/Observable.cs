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
*  This file is generated by MASES.JNetReflector (ver. 2.5.6.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util
{
    #region Observable
    public partial class Observable
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
        /// <see href="https://developer.android.com/reference/java/util/Observable.html#hasChanged()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasChanged()
        {
            return IExecuteWithSignature<bool>("hasChanged", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Observable.html#countObservers()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int CountObservers()
        {
            return IExecuteWithSignature<int>("countObservers", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Observable.html#addObserver(java.util.Observer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Observer"/></param>
        public void AddObserver(Java.Util.Observer arg0)
        {
            IExecuteWithSignature("addObserver", "(Ljava/util/Observer;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Observable.html#deleteObserver(java.util.Observer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Observer"/></param>
        public void DeleteObserver(Java.Util.Observer arg0)
        {
            IExecuteWithSignature("deleteObserver", "(Ljava/util/Observer;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Observable.html#deleteObservers()"/>
        /// </summary>
        public void DeleteObservers()
        {
            IExecuteWithSignature("deleteObservers", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Observable.html#notifyObservers()"/>
        /// </summary>
        public void NotifyObservers()
        {
            IExecuteWithSignature("notifyObservers", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Observable.html#notifyObservers(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public void NotifyObservers(object arg0)
        {
            IExecuteWithSignature("notifyObservers", "(Ljava/lang/Object;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}