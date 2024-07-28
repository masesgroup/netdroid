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

namespace Android.Media.Effect
{
    #region EffectContext
    public partial class EffectContext
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/effect/EffectContext.html#createWithCurrentGlContext()"/>
        /// </summary>
        /// <returns><see cref="Android.Media.Effect.EffectContext"/></returns>
        public static Android.Media.Effect.EffectContext CreateWithCurrentGlContext()
        {
            return SExecuteWithSignature<Android.Media.Effect.EffectContext>(LocalBridgeClazz, "createWithCurrentGlContext", "()Landroid/media/effect/EffectContext;");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/effect/EffectContext.html#getFactory()"/>
        /// </summary>
        /// <returns><see cref="Android.Media.Effect.EffectFactory"/></returns>
        public Android.Media.Effect.EffectFactory GetFactory()
        {
            return IExecuteWithSignature<Android.Media.Effect.EffectFactory>("getFactory", "()Landroid/media/effect/EffectFactory;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/effect/EffectContext.html#release()"/>
        /// </summary>
        public void Release()
        {
            IExecuteWithSignature("release", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}